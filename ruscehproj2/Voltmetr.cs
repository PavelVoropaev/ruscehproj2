using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class Voltmetr : UserControl
    {
        #region Delegates

        public delegate void SomeEventDelegate(object sender, SomeEventArgs e);

        #endregion

        private int Bar_N_bolt = 10;
        private int Bar_N_not_bolt = 50;
        private int Bar_N_tzhifra = 10;
        private int Bar_min;
        private double Bar_step = 10;
        private string Center_str = "V";
        private int Value;
        private bool zoomed;

        public Voltmetr()
        {
            InitializeComponent();
        }

        public string Set_Center_str
        {
            get { return Center_str; }
            set { Center_str = value; }
        }

        public int Set_Value
        {
            get { return Value; }
            set
            {
                Value = value;
                Invalidate();
                OnValueChanged(new SomeEventArgs(Value));
            }
        }

        public int current_Value
        {
            get { return Convert.ToInt32(Value*Bar_step*Bar_N_tzhifra/200); }
            set { Bar_N_bolt = value; }
        }

        public int Set_Bar_N_bolt
        {
            get { return Bar_N_bolt; }
            set { Bar_N_bolt = value; }
        }

        public int Set_Bar_N_not_bolt
        {
            get { return Bar_N_not_bolt; }
            set { Bar_N_not_bolt = value; }
        }

        public int Set_Bar_N_tzhifra
        {
            get { return Bar_N_tzhifra; }
            set { Bar_N_tzhifra = value; }
        }

        public int Set_Bar_min
        {
            get { return Bar_min; }
            set { Bar_min = value; }
        }

        public double Set_Bar_step
        {
            get { return Bar_step; }
            set { Bar_step = value; }
        }


        public event SomeEventDelegate Value_Changed;

        protected virtual void OnValueChanged(SomeEventArgs e)
        {
            if (Value_Changed != null)
            {
                Value_Changed(this, e);
            }
        }

        private void Voltmetr_Load(object sender, EventArgs e)
        {
        }

        public void zoom(int ZoomRate)
        {
            if (!zoomed)
            {
                Width = Width + ZoomRate;
                Height = Height + ZoomRate;
            }
            else
            {
                Width = Width - ZoomRate;
                Height = Height - ZoomRate;
            }
            zoomed = !zoomed;
        }

        public void Voltmetr_Paint(object sender, PaintEventArgs e)
        {
            // Прорисовка стрелки
            double angle = (Value*0.9 + 180 + 45)*Math.PI/180;

            int r = Convert.ToInt16(Height/2.0);
            int x = Convert.ToInt16(r*Math.Cos(angle));
            int y = Convert.ToInt16(r*Math.Sin(angle));
            int aux_X0 = Width/2;
            int aux_Y0 = 2*Height/3 + Height/30;

            using (var pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawLine(pen, aux_X0, aux_Y0, aux_X0 + x, aux_Y0 + y);
            }

            int Size_Type = Width/15;
            var drawFont_Type = new Font("Arial", Size_Type);
            label1.Text = Center_str;
            label1.Font = drawFont_Type;
            label1.Left = Width/2 - label1.Width/2 + 1;
            label1.Top = Height/2 - label1.Height/2;


            // Прорисовка шкалы
            int R = r - r/15;

            int del = Bar_N_bolt;
            for (int i = 0; i <= del/2; i++)
            {
                using (var myPen = new Pen(Color.Black, 1))
                {
                    int auxX = aux_X0 + Convert.ToInt32(0.98*R*Math.Cos((Math.PI/del)*i - (3*Math.PI/4)));
                    int auxY = aux_Y0 + Convert.ToInt32(0.98*R*Math.Sin((Math.PI/del)*i - (3*Math.PI/4)));
                    int auxXm = aux_X0 + Convert.ToInt32(1.05*R*Math.Cos((Math.PI/del)*i - (3*Math.PI/4)));
                    int auxYm = aux_Y0 + Convert.ToInt32(1.05*R*Math.Sin((Math.PI/del)*i - (3*Math.PI/4)));
                    e.Graphics.DrawLine(myPen, auxX, auxY, auxXm, auxYm);
                }
            }

            del = Bar_N_not_bolt;
            for (int i = 0; i <= del/2; i++)
            {
                using (var myPen = new Pen(Color.Black, 1))
                {
                    int auxX = aux_X0 + Convert.ToInt32(0.95*R*Math.Cos((Math.PI/del)*i - (3*Math.PI/4)));
                    int auxY = aux_Y0 + Convert.ToInt32(0.95*R*Math.Sin((Math.PI/del)*i - (3*Math.PI/4)));
                    int auxXm = aux_X0 + Convert.ToInt32(R*Math.Cos((Math.PI/del)*i - (3*Math.PI/4)));
                    int auxYm = aux_Y0 + Convert.ToInt32(R*Math.Sin((Math.PI/del)*i - (3*Math.PI/4)));
                    e.Graphics.DrawLine(myPen, auxX, auxY, auxXm, auxYm);
                }
            }

            del = Bar_N_tzhifra;
            for (int i = 0; i <= del/2; i++)
            {
                int sizeFont = Width/20;
                var drawFont = new Font("Arial", sizeFont);
                int auxX = aux_X0 + Convert.ToInt32(0.9*R*Math.Cos((Math.PI/del)*i - (3*Math.PI/4))) - sizeFont + 1;
                int auxY = aux_Y0 + Convert.ToInt32(0.9*R*Math.Sin((Math.PI/del)*i - (3*Math.PI/4)));
                int auxXm = aux_X0 + Convert.ToInt32(1.25*R*Math.Cos((Math.PI/del)*i - (3*Math.PI/4))) - sizeFont + 1;
                int auxYm = aux_Y0 + Convert.ToInt32(1.25*R*Math.Sin((Math.PI/del)*i - (3*Math.PI/4)));
                if (i == 0 || i == del/2)
                {
                    if (i*Bar_step < 10)
                    {
                        e.Graphics.DrawString(" " + (i*Bar_step + Bar_min) + " ", drawFont, Brushes.Black, auxX, auxY);
                    }
                    else
                    {
                        e.Graphics.DrawString((i*Bar_step + Bar_min) + "", drawFont, Brushes.Black, auxX, auxY);
                    }
                }
                else
                {
                    if (i*Bar_step < 10)
                    {
                        e.Graphics.DrawString(" " + (i*Bar_step + Bar_min) + " ", drawFont, Brushes.Black, auxXm, auxYm);
                    }
                    else
                    {
                        e.Graphics.DrawString((i*Bar_step + Bar_min) + "", drawFont, Brushes.Black, auxXm, auxYm);
                    }
                }
            }
        }

        #region Nested type: SomeEventArgs

        public class SomeEventArgs : EventArgs
        {
            private int newValue;

            public SomeEventArgs(int newValue)
            {
                this.newValue = newValue;
            }
        }

        #endregion
    }
}