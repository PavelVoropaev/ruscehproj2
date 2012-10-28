using System;

namespace ruscehproj2
{
    public partial class bg001 : genericForm
    {
        private readonly Random _random = new Random();

        public bg001()
        {
            InitializeComponent();
            mode.setPosNum(5);
            mode.Step = 4;
        }

        private void mode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg001_mode_" + mode.Step.ToString());
            voltmetr1.Set_Value = _random.Next(15);
            if (mode.Step == 4)
            {
                voltmetr1.Set_Value = 0;
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg001_potenzhiomert1_" + potenzhiomert1.getValue().ToString());
            voltmetr1.Set_Value = potenzhiomert1.getValue();
        }

        private void potenzhiomert2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg001_potenzhiomert2_" + potenzhiomert2.getValue().ToString());
            voltmetr1.Set_Value = potenzhiomert2.getValue();
        }

        private void potenzhiomert3_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg001_potenzhiomert3_" + potenzhiomert3.getValue().ToString());
            voltmetr1.Set_Value = potenzhiomert3.getValue();
        }

        private void potenzhiomert4_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg001_potenzhiomert4_" + potenzhiomert4.getValue().ToString());
            voltmetr1.Set_Value = potenzhiomert4.getValue();
        }
    }
}