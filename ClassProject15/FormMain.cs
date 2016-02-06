using System;
using System.Windows.Forms;

namespace ClassProject15
{
    public partial class FormMain : Form
    {
        private int _n, _nMax;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            for (var x = -360; x < 361; x += 8)
            {
                var xrad = x*Math.PI/180.0;
                var y = Math.Sin(xrad);
                chartAnimation.Series[0].Points.AddXY(x, y);
            }

            _n = 0;
            _nMax = chartAnimation.Series[0].Points.Count;
            timerMovement.Enabled = true;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
                buttonPause.PerformClick();

            else if (e.KeyCode == Keys.R)
                buttonResume.PerformClick();
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            _n++;
            if (_n == _nMax)
                _n = 0;

            var xBall = chartAnimation.Series[0].Points[_n].XValue;
            var yBall = chartAnimation.Series[0].Points[_n].YValues[0];

            chartAnimation.Series[1].Points[0].SetValueXY(xBall, yBall);
            chartAnimation.Refresh();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timerMovement.Enabled = false;
            trackBarSpeed.Focus();
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            timerMovement.Interval = trackBarSpeed.Value;
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            timerMovement.Enabled = true;
            trackBarSpeed.Focus();
        }
    }
}