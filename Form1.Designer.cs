namespace AlgoLab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.lb_oper1 = new System.Windows.Forms.Label();
            this.lb_queue1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.np_arrive = new System.Windows.Forms.NumericUpDown();
            this.np_process = new System.Windows.Forms.NumericUpDown();
            this.lb_time = new System.Windows.Forms.Label();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.lb_oper2 = new System.Windows.Forms.Label();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.lb_oper3 = new System.Windows.Forms.Label();
            this.pb_4 = new System.Windows.Forms.PictureBox();
            this.lb_oper4 = new System.Windows.Forms.Label();
            this.n_of_cores = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_queue2 = new System.Windows.Forms.Label();
            this.lb_queue3 = new System.Windows.Forms.Label();
            this.lb_queue4 = new System.Windows.Forms.Label();
            this.lb_queue_total = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_clock_spd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.np_arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_of_cores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(255, 17);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(255, 51);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 1;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // lb_oper1
            // 
            this.lb_oper1.AutoSize = true;
            this.lb_oper1.Location = new System.Drawing.Point(30, 12);
            this.lb_oper1.Name = "lb_oper1";
            this.lb_oper1.Size = new System.Drawing.Size(38, 13);
            this.lb_oper1.TabIndex = 5;
            this.lb_oper1.Text = "Core 1";
            // 
            // lb_queue1
            // 
            this.lb_queue1.AutoSize = true;
            this.lb_queue1.Location = new System.Drawing.Point(30, 117);
            this.lb_queue1.Name = "lb_queue1";
            this.lb_queue1.Size = new System.Drawing.Size(139, 13);
            this.lb_queue1.TabIndex = 8;
            this.lb_queue1.Text = "App in queue for priority 1: 0";
            this.lb_queue1.Click += new System.EventHandler(this.lb_queue1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lambda Arrive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lambda Process";
            // 
            // np_arrive
            // 
            this.np_arrive.Location = new System.Drawing.Point(468, 25);
            this.np_arrive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.np_arrive.Name = "np_arrive";
            this.np_arrive.Size = new System.Drawing.Size(120, 20);
            this.np_arrive.TabIndex = 12;
            this.np_arrive.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // np_process
            // 
            this.np_process.Location = new System.Drawing.Point(468, 59);
            this.np_process.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.np_process.Name = "np_process";
            this.np_process.Size = new System.Drawing.Size(120, 20);
            this.np_process.TabIndex = 13;
            this.np_process.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(206, 117);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(36, 13);
            this.lb_time.TabIndex = 14;
            this.lb_time.Text = "Time: ";
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(106, 8);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(36, 20);
            this.pb_1.TabIndex = 15;
            this.pb_1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_2
            // 
            this.pb_2.Location = new System.Drawing.Point(106, 35);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(36, 20);
            this.pb_2.TabIndex = 17;
            this.pb_2.TabStop = false;
            // 
            // lb_oper2
            // 
            this.lb_oper2.AutoSize = true;
            this.lb_oper2.Location = new System.Drawing.Point(30, 39);
            this.lb_oper2.Name = "lb_oper2";
            this.lb_oper2.Size = new System.Drawing.Size(38, 13);
            this.lb_oper2.TabIndex = 16;
            this.lb_oper2.Text = "Core 2";
            // 
            // pb_3
            // 
            this.pb_3.Location = new System.Drawing.Point(106, 62);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(36, 20);
            this.pb_3.TabIndex = 19;
            this.pb_3.TabStop = false;
            // 
            // lb_oper3
            // 
            this.lb_oper3.AutoSize = true;
            this.lb_oper3.Location = new System.Drawing.Point(30, 66);
            this.lb_oper3.Name = "lb_oper3";
            this.lb_oper3.Size = new System.Drawing.Size(38, 13);
            this.lb_oper3.TabIndex = 18;
            this.lb_oper3.Text = "Core 3";
            // 
            // pb_4
            // 
            this.pb_4.Location = new System.Drawing.Point(106, 87);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(36, 20);
            this.pb_4.TabIndex = 21;
            this.pb_4.TabStop = false;
            // 
            // lb_oper4
            // 
            this.lb_oper4.AutoSize = true;
            this.lb_oper4.Location = new System.Drawing.Point(30, 91);
            this.lb_oper4.Name = "lb_oper4";
            this.lb_oper4.Size = new System.Drawing.Size(38, 13);
            this.lb_oper4.TabIndex = 20;
            this.lb_oper4.Text = "Core 4";
            // 
            // n_of_cores
            // 
            this.n_of_cores.Location = new System.Drawing.Point(468, 92);
            this.n_of_cores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.n_of_cores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_of_cores.Name = "n_of_cores";
            this.n_of_cores.Size = new System.Drawing.Size(120, 20);
            this.n_of_cores.TabIndex = 23;
            this.n_of_cores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "N of Active cores";
            // 
            // lb_queue2
            // 
            this.lb_queue2.AutoSize = true;
            this.lb_queue2.Location = new System.Drawing.Point(30, 140);
            this.lb_queue2.Name = "lb_queue2";
            this.lb_queue2.Size = new System.Drawing.Size(139, 13);
            this.lb_queue2.TabIndex = 24;
            this.lb_queue2.Text = "App in queue for priority 2: 0";
            this.lb_queue2.Click += new System.EventHandler(this.lb_queue2_Click);
            // 
            // lb_queue3
            // 
            this.lb_queue3.AutoSize = true;
            this.lb_queue3.Location = new System.Drawing.Point(30, 162);
            this.lb_queue3.Name = "lb_queue3";
            this.lb_queue3.Size = new System.Drawing.Size(139, 13);
            this.lb_queue3.TabIndex = 25;
            this.lb_queue3.Text = "App in queue for priority 3: 0";
            // 
            // lb_queue4
            // 
            this.lb_queue4.AutoSize = true;
            this.lb_queue4.Location = new System.Drawing.Point(30, 186);
            this.lb_queue4.Name = "lb_queue4";
            this.lb_queue4.Size = new System.Drawing.Size(139, 13);
            this.lb_queue4.TabIndex = 26;
            this.lb_queue4.Text = "App in queue for priority 4: 0";
            // 
            // lb_queue_total
            // 
            this.lb_queue_total.AutoSize = true;
            this.lb_queue_total.Location = new System.Drawing.Point(206, 140);
            this.lb_queue_total.Name = "lb_queue_total";
            this.lb_queue_total.Size = new System.Drawing.Size(105, 13);
            this.lb_queue_total.TabIndex = 27;
            this.lb_queue_total.Text = "App in queue total: 0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(317, 138);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(471, 300);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // lb_clock_spd
            // 
            this.lb_clock_spd.AutoSize = true;
            this.lb_clock_spd.Location = new System.Drawing.Point(30, 220);
            this.lb_clock_spd.Name = "lb_clock_spd";
            this.lb_clock_spd.Size = new System.Drawing.Size(114, 13);
            this.lb_clock_spd.TabIndex = 29;
            this.lb_clock_spd.Text = "Current clock speed: 0";
            this.lb_clock_spd.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_clock_spd);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb_queue_total);
            this.Controls.Add(this.lb_queue4);
            this.Controls.Add(this.lb_queue3);
            this.Controls.Add(this.lb_queue2);
            this.Controls.Add(this.n_of_cores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_4);
            this.Controls.Add(this.lb_oper4);
            this.Controls.Add(this.pb_3);
            this.Controls.Add(this.lb_oper3);
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.lb_oper2);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.np_process);
            this.Controls.Add(this.np_arrive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_queue1);
            this.Controls.Add(this.lb_oper1);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.np_arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_of_cores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Label lb_oper1;
        private System.Windows.Forms.Label lb_queue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown np_arrive;
        private System.Windows.Forms.NumericUpDown np_process;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.Label lb_oper2;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.Label lb_oper3;
        private System.Windows.Forms.PictureBox pb_4;
        private System.Windows.Forms.Label lb_oper4;
        private System.Windows.Forms.NumericUpDown n_of_cores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_queue2;
        private System.Windows.Forms.Label lb_queue3;
        private System.Windows.Forms.Label lb_queue4;
        private System.Windows.Forms.Label lb_queue_total;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lb_clock_spd;
    }
}

