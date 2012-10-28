using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class IKO_control : UserControl
    {
        private const double SpeedIKO = 9;
        public target Targ1 = new target(1, 100, 100);
        public target Targ2 = new target(2, 150, 50, false);
        public target Targ3 = new target(3, 200, 144);
        public target Targ4 = new target(4, 30, 111, false);
        public target Targ5 = new target(5, 140, 150, false);
        public target Targ6 = new target(6, 340, 170, true, false);

        private double _angle;
        public int Brightness = 3;
        public bool Ctrl = false;
        private const double r = 230;
        private int rx, ry;
        public int SizeLigt = 17;
        private const int X0 = 250;
        private const int Y0 = 250;

        public IKO_control()
        {
            InitializeComponent();
            //    Targ1.shafl(); Targ2.shafl(); Targ3.shafl(); Targ4.shafl(); Targ5.shafl(); Targ6.shafl();
        }

        public void start()
        {
            timer1.Start();
        }

        public void stop()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rx = Convert.ToInt32(r*Math.Cos((_angle - 90)*Math.PI/180)) + X0;
            ry = Convert.ToInt32(r*Math.Sin((_angle - 90)*Math.PI/180)) + Y0;
            Graphics canvas = CreateGraphics();
            canvas.FillEllipse(Brushes.Orange, 20, 20, 460, 460);

            Targ1.draw(X0 - 30, Y0 - 30, canvas, r, _angle);
            Targ2.draw(X0 - 30, Y0 - 30, canvas, r, _angle);
            Targ3.draw(X0 - 30, Y0 - 30, canvas, r, _angle);
            Targ4.draw(X0 - 30, Y0 - 30, canvas, r, _angle);
            Targ5.draw(X0 - 30, Y0 - 30, canvas, r, _angle);
            Targ6.draw(X0 - 30, Y0 - 30, canvas, r, _angle);
            if (Brightness > 3)
            {
                canvas.DrawLine(new Pen(Brushes.GreenYellow, 1 + (Brightness - 1)/(SizeLigt + 8)), X0, Y0, rx, ry);

                for (int i = 0; i < 20; i++)
                {
                    const int step = 10;
                    canvas.DrawArc(new Pen(Brushes.GreenYellow, 1 + Brightness/SizeLigt), 20 + step*i, 20 + step*i,
                                   460 - step*2*i, 460 - step*2*i, Convert.ToInt32(_angle - 95), 10);
                }
                for (int i = 1; i < 3; i++)
                {
                    const int step = 50;
                    canvas.DrawArc(new Pen(Brushes.GreenYellow, 1 + Brightness/SizeLigt), 20 + step*i, 20 + step*i,
                                   460 - step*2*i, 460 - step*2*i, Convert.ToInt32(_angle - 95), 10);
                }
            }
            _angle = _angle + SpeedIKO;
            if (_angle > 359) _angle = 0;
        }

        #region Nested type: target

        public class target
        {
            private readonly Random _rnd = new Random();
            private bool _allign;
            public int Az;
            public double Dal;
            public int Num;
            public bool show;
            private const double Speed = 0.01;

            public target(int _num, int _az = 0, int _dal = 0, bool _align = true, bool _show = true)
            {
                Az = _az;
                Dal = _dal;
                _allign = _align;
                Num = _num;
                show = _show;
            }

            public void shafl()
            {
                Az = _rnd.Next(360);
                Dal = _rnd.Next(170);
            }

            public void draw(int x0, int y0, Graphics canvas, double r, double angle)
            {
                if (show)
                {
                    if (angle > Az - 10 && angle < Az + 90)
                    {
                        if (FormManager.IKO.ikO_control1.Ctrl)
                            FormManager.targetCtrl.refresh(Num);
                        int xtarg = Convert.ToInt32(x0 + Dal*Math.Cos((Az - 90)*Math.PI/180));
                        int ytarg = Convert.ToInt32(y0 + Dal*Math.Sin((Az - 90)*Math.PI/180));
                        if (FormManager.IKO.ikO_control1.Brightness > 3)
                            canvas.DrawArc(
                                new Pen(Brushes.GreenYellow,
                                        (FormManager.IKO.ikO_control1.Brightness - 2)/
                                        FormManager.IKO.ikO_control1.SizeLigt), xtarg + 10, ytarg + 10, 50, 50,
                                Convert.ToInt32(((Az + 76*Math.PI))), 40);
                    }
                    else
                    {
                        move(r);
                    }
                }
            }

            private void move(double r)
            {
                if (_allign) Dal = (Dal + Speed);
                else Dal = (Dal - Speed);
                if (Dal < 7)
                {
                    Az = Az + 180;
                    _allign = !_allign;
                }
                if (Dal > r - 50)
                {
                    _allign = !_allign;
                    Az = Az + _rnd.Next(70);
                }
                if (Az > 360) Az = Az - 360;
            }
        }

        #endregion
    }
}