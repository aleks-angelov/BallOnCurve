namespace ClassProject15
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-360D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartAnimation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.labelSlow = new System.Windows.Forms.Label();
            this.labelFast = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAnimation
            // 
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 90D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 360D;
            chartArea1.AxisX.Minimum = -360D;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.IntervalOffset = 0.1D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 1.1D;
            chartArea1.AxisY.Minimum = -1.1D;
            chartArea1.Name = "ChartAreaGraph";
            this.chartAnimation.ChartAreas.Add(chartArea1);
            this.chartAnimation.Location = new System.Drawing.Point(12, 12);
            this.chartAnimation.Name = "chartAnimation";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartAreaGraph";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "SeriesCurve";
            series2.ChartArea = "ChartAreaGraph";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.MarkerSize = 40;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "SeriesBall";
            series2.Points.Add(dataPoint1);
            this.chartAnimation.Series.Add(series1);
            this.chartAnimation.Series.Add(series2);
            this.chartAnimation.Size = new System.Drawing.Size(960, 380);
            this.chartAnimation.TabIndex = 0;
            this.chartAnimation.Text = "chartAnimation";
            // 
            // buttonPause
            // 
            this.buttonPause.AutoSize = true;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(124, 411);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(100, 31);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "(P)ause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResume.Location = new System.Drawing.Point(760, 411);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(100, 31);
            this.buttonResume.TabIndex = 3;
            this.buttonResume.Text = "(R)esume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // timerMovement
            // 
            this.timerMovement.Interval = 25;
            this.timerMovement.Tick += new System.EventHandler(this.timerMovement_Tick);
            // 
            // labelSlow
            // 
            this.labelSlow.AutoSize = true;
            this.labelSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSlow.Location = new System.Drawing.Point(594, 418);
            this.labelSlow.Name = "labelSlow";
            this.labelSlow.Size = new System.Drawing.Size(47, 16);
            this.labelSlow.TabIndex = 3;
            this.labelSlow.Text = "SLOW";
            this.labelSlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFast
            // 
            this.labelFast.AutoSize = true;
            this.labelFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFast.Location = new System.Drawing.Point(344, 418);
            this.labelFast.Name = "labelFast";
            this.labelFast.Size = new System.Drawing.Size(43, 16);
            this.labelFast.TabIndex = 3;
            this.labelFast.Text = "FAST";
            this.labelFast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 20;
            this.trackBarSpeed.Location = new System.Drawing.Point(393, 410);
            this.trackBarSpeed.Maximum = 75;
            this.trackBarSpeed.Minimum = 15;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(195, 45);
            this.trackBarSpeed.SmallChange = 10;
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.TickFrequency = 10;
            this.trackBarSpeed.Value = 25;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelFast);
            this.Controls.Add(this.labelSlow);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.chartAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Forms - Animation: Ball on Sine Curve - Aleks Angelov";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnimation;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.Label labelSlow;
        private System.Windows.Forms.Label labelFast;
        private System.Windows.Forms.TrackBar trackBarSpeed;

    }
}

