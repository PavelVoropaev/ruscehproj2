using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class Picture_Box_for_Oscilloscope : UserControl
    {
        #region Delegates

        public delegate void SomeEventDelegate(object sender, SomeEventArgs e);

        #endregion

        private readonly double[] x = new double[200];
        private readonly double[] y = new double[200];

        private int Case_Grafics;
        //подгрузка данных и набивка массива

        // Параметры для рисования
        private double mX = 1, mY = 1; // Маштаб //пишется через "С"
        private int step_X = 10;
        private int step_Y = 10;

        public Picture_Box_for_Oscilloscope()
        {
            InitializeComponent();
        }

        public int Set_Case_Grafics
        {
            get { return Case_Grafics; }
            set
            {
                Case_Grafics = value;
                OnValueChanged(new SomeEventArgs(Case_Grafics));
            }
        }

        public double Set_mX
        {
            get { return mX; }
            set { mX = value; }
        }

        public double Set_mY
        {
            get { return mY; }
            set { mY = value; }
        }

        public int Set_step_X
        {
            get { return step_X; }
        }

        public int Set_step_Y
        {
            get { return step_Y; }
        }

        public void loadData(string _in)
        {
            var sr = new StreamReader(_in);
            string line;

            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                string[] numbers = line.Split(' ');
                x[i] = Convert.ToDouble(numbers[0]);
                y[i] = Convert.ToDouble(numbers[1]);
                i++;
            }
            while (i < x.Length)
            {
                x[i] = x[i - 1];
                y[i] = y[i - 1];
                i++;
            }
        }


        //рефрешь трололол

        public void refresh(string _in)
        {
            loadData(_in);
            pictureBox1.Invalidate();
        }

        public void refresh()
        {
            pictureBox1.Invalidate();
        }

        public event SomeEventDelegate Value_Changed;

        protected virtual void OnValueChanged(SomeEventArgs e)
        {
            if (Value_Changed != null)
            {
                Value_Changed(this, e);
            }
        }

        private void Picture_Box_for_Oscilloscope_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Шкала и Линии
            step_X = Width/8;
            step_Y = Height/6;
            using (var myPen = new Pen(Color.YellowGreen, 1))
            {
                for (int i = 0; i <= 8; i++)
                {
                    g.DrawLine(myPen, step_X*i, 0, step_X*i, step_Y*6);
                }
                for (int i = 0; i <= 6; i++)
                {
                    g.DrawLine(myPen, 0, step_Y*i, step_X*8, step_Y*i);
                }
            }

            // Рисование графика
            for (int j = 0; j < x.Length - 1; j++)
            {
                int auxX_1 = Convert.ToInt32(mX*x[j]);
                int auxY_1 = Convert.ToInt32((-1)*mY*y[j] + Height/2);
                int auxX_2 = Convert.ToInt32((mX*x[j + 1]));
                int auxY_2 = Convert.ToInt32((-1)*mY*y[j + 1] + Height/2);
                {
                    using (var myPen = new Pen(Color.Green, 2))
                    {
                        g.DrawLine(myPen, auxX_1, auxY_1, auxX_2, auxY_2);
                    }
                }
            }
        }

        private void Picture_Box_for_Oscilloscope_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("Oscilloscope_picture_Box_for_Oscilloscope1");
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