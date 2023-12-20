using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace AlgoLab2
{
    public abstract class Agent
    {
        public virtual double getNextEventTime()
        {
            return double.MaxValue;
        }

        public virtual void processEvent()
        {

        }
    }
    public class AppProcess : Agent
    {
        private Random rnd = new Random();
        public double lambda;
        private double nextArrivalTime = 0;
        private CPU cpu;

        public AppProcess(CPU cpu)
        {
            this.cpu = cpu;
            this.lambda = Model.lambda_arrive;
            nextArrivalTime = simulateInterarrivalTime();
        }

        private double simulateInterarrivalTime()
        {
            return -Math.Log(rnd.NextDouble()) / lambda;
        }

        private int generatePriority()
        {
            return rnd.Next(0, 4);
        }
        public override double getNextEventTime()
        {
            return nextArrivalTime;
        }
        public override void processEvent()
        {
            base.processEvent();
            App app = new App(generatePriority(), nextArrivalTime+simulateInterarrivalTime());
            cpu.appRequestedService(app);
            nextArrivalTime += simulateInterarrivalTime();
        }
    }
    public class App: Agent
    {
        public int priority;
        public double timeToProcess;
        public App(int priority, double timeToProcess)
        {
            this.priority = priority;
            this.timeToProcess = timeToProcess;
        }
    }

    public class CPU: Agent
    {
        private CoreManager coreManager;
        private QueueWrapper queue = new QueueWrapper();

        public CPU()
        {
            coreManager = new CoreManager(this, Model.n_of_cores);
        }

        internal void appRequestedService(App app)
        {
            if (coreManager.hasFreeCore()) coreManager.serviceTheRequest(app);
            else queue.putRequestInQueue(app);
        }
        public override double getNextEventTime()
        {
            return coreManager.getNextEventTime();
        }

        public void NotifyFreeCore(Core freeOp)
        {
            App customer = queue.getTopPriorityRequest();
            if (customer != null)
            {
                freeOp.acceptRequest(customer);
            }
        }

        public override void processEvent()
        {
            coreManager.processEvent();
        }
    }
    public class QueueWrapper : Agent
    {
        private MyQueue<App>[] queueArr = { new MyQueue<App>(), new MyQueue<App>(), new MyQueue<App>(), new MyQueue<App>() };

        private int allAppsPending = 0;
        internal void putRequestInQueue(App app)
        {
            queueArr[app.priority].Enqueue(app);
            allAppsPending++;
            Model.form.UpdateQueueTotal(allAppsPending);
            Model.form.UpdateQueue(queueArr[app.priority].Size, app.priority);
        }
        internal App getTopPriorityRequest()
        {
            for (int i = 0; i < 4; i++)
            {
                MyQueue<App> queue = queueArr[i];
                if (!queue.IsEmpty())
                {
                    allAppsPending--;
                    Model.form.UpdateQueueTotal(allAppsPending);
                    Model.form.UpdateQueue(queue.Size - 1, i);
                    return queue.Dequeue();
                }
            }

            return null;
        }
    }
    public class CoreManager : Agent
    {
        private List<Core> cores = new List<Core>();
        private CPU cpu;
        private double coreClock;
        private Random rnd = new Random();
        public CoreManager(CPU cpu, int nOfCores)
        {
            this.coreClock = -Math.Log(rnd.NextDouble()) / Model.lambda_process;
            this.cpu = cpu;
            for (int i = 1; i <= nOfCores; i++)
            {
                cores.Add(new Core(cpu, i, coreClock));
            }
        }
        internal void serviceTheRequest(App customer)
        {
            Core core = findFreeCore();
            if (core != null) core.acceptRequest(customer);
        }

        internal bool hasFreeCore()
        {
            Core core = findFreeCore();
            return core != null;
        }

        private Core findFreeCore()
        {
            foreach (Core core in cores)
                if (core.IsFree()) return core;
            return null;
        }
        public Core getFirstCore()
        {
            double tmin = Double.MaxValue;
            Core currCore = null;
            foreach (Core core in cores)
            {
                double top = core.getNextEventTime();
                if (top <= tmin)
                {
                    currCore = core;
                    tmin = top;
                }
            }
            return currCore;
        }

        public override double getNextEventTime()
        {
            return getFirstCore().getNextEventTime();
        }

        public override void processEvent()
        {
            getFirstCore().processEvent();
        }
    }

    public class Core : Agent
    {
        private App appInService = null;
        private double endOfServiceTime = double.MaxValue;
        private PictureBox pictureBox;
        private int n;
        private CPU cpu;
        private double constServiceTime;
        public Core(CPU cpu, int n, double coreClock)
        {
            this.n = n;
            this.cpu = cpu;
            this.constServiceTime = coreClock;
        }
        internal void acceptRequest(App app)
        {
            if (IsFree())
            {
                appInService = app;
                Model.form.FillColor(n, Color.Red);
                endOfServiceTime = Model.Time + simulateServiceTime();
            }
        }
        internal void discardRequest(bool isCompleted)
        {
            endOfServiceTime = double.MaxValue;
            Model.form.FillColor(n, Color.Green);
            if (isCompleted)
            {
                appInService = null;
                cpu.NotifyFreeCore(this);
            } else
            {
                cpu.appRequestedService(appInService);
                appInService = null;
            }
        }

        internal bool IsFree()
        {
            return appInService == null;
        }
        private double simulateServiceTime()
        {
            return constServiceTime;
        }

        public override void processEvent()
        {
            base.processEvent();
            if (!IsFree())
            {
                discardRequest(appInService.timeToProcess < endOfServiceTime);
            } else
            {
                cpu.NotifyFreeCore(this);
            }
        }
        public override double getNextEventTime()
        {
            return endOfServiceTime;
        }
    }
}