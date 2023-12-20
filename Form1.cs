using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoLab2
{
    public partial class Form1 : Form
    {
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        private Model model;
        private int totalQueue = 0;
        private Random rnd = new Random();
        public double currentClockSpeed = 0;
        int i = 0;
        int curr_total = 0;
        public Form1()
        {
            InitializeComponent();
            lb_clock_spd.Text = $"Current clock speed: {currentClockSpeed}";
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            ResetScene();
            ClearData();
            timer1.Start();
            bt_start.Enabled = false;
            bt_stop.Enabled = true;
            currentClockSpeed = -Math.Log(rnd.NextDouble()) / getLambdaProcess();
            lb_clock_spd.Text = $"Current clock speed: {currentClockSpeed}";
        }
        private void ClearData()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            i = 0;
            curr_total = 0;
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bt_start.Enabled = true;
            bt_stop.Enabled = false;
            ResetScene();
        }

        private void ResetScene()
        {
            pb_1.Image = null;
            pb_2.Image = null;
            pb_3.Image = null;
            pb_4.Image = null;
            for (int i = 0; i < 4; i++)
            {
                UpdateQueue(0, i);
            }
            UpdateQueueTotal(0);
            UpdateTime(0);
            model = new Model(this);
        }

        public void FillColor(int n, Color color)
        {
            PictureBox pb = null;
            switch (n)
            {
                case 1:
                    pb = pb_1;
                    break;
                case 2:
                    pb = pb_2;
                    break;
                case 3:
                    pb = pb_3;
                    break;
                case 4:
                    pb = pb_4;
                    break;
            }
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(color);
            pb.Image = bmp;
        }

        public void UpdateQueue(int mnt, int n)
        {
            Label lb = null;
            switch (n)
            {
                case 0:
                    lb = lb_queue1;
                    break;
                case 1:
                    lb = lb_queue2;
                    break;
                case 2:
                    lb = lb_queue3;
                    break;
                case 3:
                    lb = lb_queue4;
                    break;
            }
            lb.Text = $"App in queue for priority {n+1}: " + mnt;
        }

        public void UpdateQueueTotal(int mnt)
        {
            lb_queue_total.Text = $"App in queue total: " + mnt;
            curr_total = mnt;
        }
        public void UpdateTime(double T)
        {
            lb_time.Text = "Time: " + T;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Model.Run();
            chart1.Series[0].Points.AddXY(i++, curr_total);
        }

        public double getLambdaArrive()
        {
            return (double)np_arrive.Value;
        }
        public double getLambdaProcess()
        {
            return (double)np_process.Value;
        }
        public int getNOfCores()
        {
            return (int)n_of_cores.Value;
        }

        private void lb_queue2_Click(object sender, EventArgs e)
        {

        }

        private void lb_queue1_Click(object sender, EventArgs e)
        {

        }
    }
}
