using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoLab2
{
    internal class Model
    {
        static public Form1 form;
        private static double T = 0;
        public static double lambda_arrive, lambda_process;
        public static int n_of_cores;
        public static double Time
        {
            get { return T; }
        }
        private static List<Agent> agents = new List<Agent>();

        public Model(Form1 form)
        {
            agents = new List<Agent>();
            Model.form = form;
            Model.lambda_arrive = form.getLambdaArrive();
            Model.lambda_process = form.getLambdaProcess();
            Model.n_of_cores = form.getNOfCores();
            CPU cpu = new CPU();
            agents.Add(cpu);
            agents.Add(new AppProcess(cpu));
        }

        public static void Run()
        {
            Agent activeAgent = null;
            double tmin = double.MaxValue;
            foreach (Agent agent in agents)
            {
                double ta = agent.getNextEventTime();
                if (ta < tmin)
                {
                    tmin = ta;
                    activeAgent = agent;
                }
            }

            T = tmin;
            form.UpdateTime(T);
            if (activeAgent != null) activeAgent.processEvent();
        }
    }
}
