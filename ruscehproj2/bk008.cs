using System;

namespace ruscehproj2
{
    public partial class bk008 : genericForm
    {
        public bk008()
        {
            InitializeComponent();
            mode.setPosNum(3);
        }

        private void mode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.Step.ToString());
        }

        private void pwr_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + pwr.Name + "_" + pwr.State.ToString());
        }

        private void ignite_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + ignite.Name);
            voltmetr1.Set_Value = 75;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + stop.Name);
        }

        private void tokSHG_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + tokSHG.Name + "_" + tokSHG.getValue().ToString());
            voltmetr1.Set_Value = tokSHG.getValue();
        }
    }
}