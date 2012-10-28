using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class Oscilloscope : genericForm
    {
        #region Delegates

        public delegate void EventHandler(object potezhiometer, CustomEventArgs scrollInfo);

        #endregion

        private readonly generator gen = new generator();
        public double gain = 1;
        public double resX;
        public double resY;

        public Oscilloscope(string _in)
        {
            InitializeComponent();
            picture_Box_for_Oscilloscope1.loadData(_in);
        }

        public void loadData(string _in)
        {
            picture_Box_for_Oscilloscope1.loadData(_in);
        }

        public void refresh(string _in)
        {
            picture_Box_for_Oscilloscope1.refresh(_in);
        }

        public void refresh()
        {
            picture_Box_for_Oscilloscope1.refresh();
        }

        public event EventHandler onResolutionChange;
            // обработчик здесь только будет вызываться реализуется в подписчике

        public void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (voltageX.getValue() != 0)
            {
                picture_Box_for_Oscilloscope1.Set_mX = voltageX.getValue();
                picture_Box_for_Oscilloscope1.Set_mX *= 0.001*picture_Box_for_Oscilloscope1.Set_step_X;
                picture_Box_for_Oscilloscope1.pictureBox1.Invalidate();
            }
            resX = voltageX.getValue();
            var resValue = new CustomEventArgs(voltageX.getValue(), "x");
            if (onResolutionChange != null)
                onResolutionChange(this, resValue); //если есть подписчики то вызвать событие
        }

        public void potenzhiomert2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (voltageY.getValue() != 0)
            {
                picture_Box_for_Oscilloscope1.Set_mY = voltageY.Set_Value*gain;
                picture_Box_for_Oscilloscope1.Set_mY *= 0.001*picture_Box_for_Oscilloscope1.Set_step_Y;
                picture_Box_for_Oscilloscope1.pictureBox1.Invalidate();
            }
            resY = voltageY.getValue();
            var resValue = new CustomEventArgs(voltageY.getValue(), "y");
            if (onResolutionChange != null) onResolutionChange(this, resValue);
        }

        private void picture_Box_for_Oscilloscope1_Click(object sender, EventArgs e)
        {
        }

        private void generator_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + generator.Name))
            {
                gen.Show();
                gen.TopMost = true;
                gen.Top = Top + Height;
                gen.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void Oscilloscope_FormClosing(object sender, FormClosingEventArgs e)
        {
            gen.Dispose();
        }
    }

    //класс данных которые передаются при событии с помощью этого 
    //можно передавать различный мусор
    public class CustomEventArgs : EventArgs
    {
        public string axis;
        public int value;
        public int value1;

        public CustomEventArgs(int _in, string _axis)
        {
            value = _in; //в данном случае интовое значение скролл бара
            axis = _axis;
        }

        public CustomEventArgs(int _in1, int _in2)
        {
            value = _in1;
            value1 = _in2;
        }
    }
}