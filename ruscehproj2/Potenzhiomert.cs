using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class Potenzhiomert : UserControl
    {
        #region Delegates

        public delegate void SomeEventDelegate(object sender, SomeEventArgs e);

        #endregion

        private const int AngleMin = 180;
        private int _type;
        private int _value;
        private const int ValueMax = 75;
        private string _parent = "";

        public Potenzhiomert()
        {
            InitializeComponent();
        }

        public int Set_Value
        {
            get { return _value; }
            set
            {
                _value = value;
                BackgroundImage_Change();
                OnValueChanged(new SomeEventArgs(_value));
                trackBar1.Value = _value;
            }
        }

        public int Set_Type
        {
            get { return _type; }
            set
            {
                _type = value;
                Invalidate();
            }
        }

        public int getValue()
        {
            return trackBar1.Value;
        }

        public event SomeEventDelegate Value_Changed;

        protected virtual void OnValueChanged(SomeEventArgs e)
        {
            if (Value_Changed != null)
            {
                Value_Changed(this, e);
            }
        }

        private Bitmap rotateImage(Bitmap input, int angle)
        {
            var result = new Bitmap(input.Width, input.Height);
            Graphics g = Graphics.FromImage(result);
            g.TranslateTransform((float) input.Width/2, (float) input.Height/2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float) input.Width/2, -(float) input.Height/2);
            g.DrawImage(input, new Point(0, 0));
            return result;
        }

        public void BackgroundImage_Change()
        {
            int Angle = Convert.ToInt16(_value*3.6*ValueMax/100 + AngleMin);
            button1.BackgroundImage = rotateImage(Resources.pot, Angle);
        }

        private void Potenzhiometr_Load(object sender, EventArgs e)
        {
            double aux = 0;

            switch (_type)
            {
                case 0:
                    aux = 0.6;
                    break;
                case 1:
                    aux = 0.5;
                    break;
            }

            button1.Width = Convert.ToInt16(aux*Width);
            button1.Height = button1.Width;

            button1.Left = Width/2 - button1.Width/2;
            button1.Top = 0;

            trackBar1.Height = 25;
            trackBar1.Width = Width;

            trackBar1.Left = 0;
            trackBar1.Top = button1.Height + button1.Top;
            Height = trackBar1.Top + trackBar1.Height;

            trackBar1.Visible = false;

            BackgroundImage_Change();

            if (_type == 1)
            {
                var bmp = new Bitmap(Resources.potentBig, button1.Height, button1.Height);
                if (button1.Width < button1.Height)
                {
                    bmp = new Bitmap(Resources.potentBig, button1.Width, button1.Width);
                }
                button1.Image = bmp;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _value = trackBar1.Value;
            if (Parent.Name == "panel1") _parent = Parent.Parent.Name + "_" + Parent.Name;
            else _parent = Parent.Name;

            if (FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + (_value + 1).ToString())
                || FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + _value.ToString())
                || FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + (_value - 1).ToString())
                || FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + (_value + 2).ToString())
                || FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + (_value - 2).ToString())
                || FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + (_value + 2).ToString())
                || FormManager.hlp.hlpRefresh(_parent + "_" + Name + "_" + (_value - 2).ToString()))
            {
                //  trackBar1.Visible = false;
                //  trackBar1.Enabled = false;
            }
            OnValueChanged(new SomeEventArgs(_value));

            BackgroundImage_Change();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = !trackBar1.Visible;
            trackBar1.Enabled = true;
            Cursor.Position = PointToScreen(new Point(trackBar1.Width/2, trackBar1.Top + trackBar1.Height/2));
            trackBar1.BringToFront();
            //Random r = new Random();
            //trackBar1.Value = r.Next(99);
        }

        private void Potenzhiomert_Leave(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
            trackBar1.Enabled = false;
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