using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class reg : UserControl
    {
        #region Delegates

        public delegate void SomeEventDelegate(object sender, CustomEventArgs e);

        #endregion

        public int max = 27;
        public int value = 50;

        public reg()
        {
            InitializeComponent();
        }

        public int cap
        {
            get { return max; }
            set { max = value; }
        }

        public event SomeEventDelegate Value_Changed;

        public void setValue(int val)
        {
            value = val;
        }

        public int getValue()
        {
            return value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BringToFront();
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value--;
            if (value < 1) value = 1;
            var args = new CustomEventArgs(value, max);
            Value_Changed(this, args);
            //int Angle = Convert.ToInt16(value * 3.6 * max / 100 + 1);
            //button3.BackgroundImage = rotateImage(Resources.kanals, 20 * Angle);
            FormManager.hlp.hlpRefresh(Parent.Name + "_" + Name + "_" + value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value++;
            if (value > max) value = max;
            FormManager.hlp.hlpRefresh(Parent.Name + "_" + Name + "_" + value);
            var args = new CustomEventArgs(value, max);
            Value_Changed(this, args);
        }

        private void reg_Leave(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }
    }
}