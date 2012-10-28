using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class Perecluchatel : UserControl
    {
        #region Delegates

        public delegate void SomeEventDelegate(object sender, SomeEventArgs e);

        #endregion

        private int Angle_min = -30;
        private int Angle_step = 30;
        private int Type;
        private int Value;
        private int Value_Max = 2;
        private bool Value_Up = true;

        public Perecluchatel()
        {
            InitializeComponent();
        }

        public int Set_Type
        {
            get { return Type; }
            set { Type = value; }
        }

        public int Set_Angle_Min
        {
            get { return Angle_min; }
            set { Angle_min = value; }
        }

        public int Set_Angle_Step
        {
            get { return Angle_step; }
            set { Angle_step = value; }
        }

        public int Set_Value_Max
        {
            get { return Value_Max; }
            set { Value_Max = value; }
        }

        public int Set_Value
        {
            get { return Value; }
            set
            {
                Value = value;
                OnValueChanged(new SomeEventArgs(Value));
            }
        }

        public bool Set_Value_Up
        {
            get { return Value_Up; }
            set { Value_Up = value; }
        }

        public event SomeEventDelegate Value_Changed;

        protected virtual void OnValueChanged(SomeEventArgs e)
        {
            if (Value_Changed != null)
            {
                Value_Changed(this, e);
            }
        }

        private void BackgroundImage_Change()
        {
            int Angle = Angle_min + Value*Angle_step;

            switch (Type)
            {
                case 0:
                    BackgroundImage = rotateImage(new Bitmap(Resources.tmb), Angle);
                    break;
                case 1:
                    BackgroundImage = rotateImage(new Bitmap(Resources.tmb), Angle);
                    break;
            }
        }

        private void Perecluchatel_Load(object sender, EventArgs e)
        {
            BackgroundImage_Change();
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

        private void Perecluchatel_Click(object sender, EventArgs e)
        {
            if (Value == Value_Max)
            {
                Value_Up = false;
            }
            if (Value == 0)
            {
                Value_Up = true;
            }

            if (Value_Up)
            {
                Value++;
            }
            if (Value_Up == false)
            {
                Value--;
            }

            OnValueChanged(new SomeEventArgs(Value));

            BackgroundImage_Change();
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