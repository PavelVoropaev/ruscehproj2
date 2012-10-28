using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class phazoukaz : genericForm
    {
        private readonly Rectangle quadrat = new Rectangle(5, 5, 50, 50);
        private int angle;

        public phazoukaz()
        {
            InitializeComponent();
            //pictureBox1.BackgroundImage = Resources.phazeArrow;
            //pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics canvas = phaze.CreateGraphics();
            canvas.Clear(Color.White);
            canvas.DrawArc(new Pen(Brushes.Black, 2), quadrat, (angle*20), 40);
            angle++;
        }

        private void phazoukaz_Load(object sender, EventArgs e)
        {
            Graphics canvas = phaze.CreateGraphics();
            canvas.DrawArc(new Pen(Brushes.Black, 3), quadrat, (angle*20), 40);
        }

        private void phazoukaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void PUSK_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            FormManager.hlp.hlpRefresh("phazoukaz_PUSK_mouseDown");
        }

        private void PUSK_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            FormManager.hlp.hlpRefresh("phazoukaz_phaze_mouseUp");
        }

        private void phaseWires_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.phazePointerWires;
            FormManager.hlp.hlpRefresh(Name + "_phaseWires");
        }
    }
}