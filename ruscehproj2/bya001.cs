using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bya001 : genericForm
    {
        private readonly Random R = new Random();
        private readonly Timer T = new Timer();
        private int _gain = 7;
        private const int Time = 80;
        private int _tmp = -1;

        public bya001()
        {
            InitializeComponent();
            ContrPar.setPosNum(11);
            T.Tick += T_Tick;
            var timer = new Timer();
            timer.Tick += Time_Tick;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            _tmp = -_tmp;
            voltmetr1.Set_Value = 50 + (Time/2)*_tmp;
        }

        private void ContrPar_Click(object sender, EventArgs e)
        {
            if (ContrPar.Step < 7)
            {
                voltmetr1.Set_Value = 75;
                T.Stop();
            }
            else T.Start();
            if (FormManager.hlp.hlpRefresh("bya001_ContrPar_" + ContrPar.Step.ToString()) && ContrPar.Step != 9)
            {
                FormManager.tuts1.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            _gain *= -1;
            voltmetr1.Set_Value = 50 + _gain + R.Next(potenzhiomert1.getValue()/4);
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bya001_potenzhiomert1_" + potenzhiomert1.getValue().ToString()))
            {
                FormManager.tuts1.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }
    }
}