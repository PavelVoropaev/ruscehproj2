using System;

namespace ruscehproj2
{
    public partial class bp119 : genericForm
    {
        public bp119()
        {
            InitializeComponent();
            pwr.Setskin(2);
            bulb1.setLampType("green");
            voltageChk.isSided = true;
        }

        private void pwr_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + pwr.Name + "_" + pwr.State.ToString());
            bulb1.setState(pwr.State);
            if (pwr.State)
            {
                voltmetr1.Set_Value = voltageChk.State ? 75 : 40;
            }
            else voltmetr1.Set_Value = 0;
        }

        private void bp119_Load(object sender, EventArgs e)
        {
            try
            {
                bulb1.setState(FormManager.bv10.sar1.state);
            }
            catch
            {
            }
        }

        private void tumbler1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + voltageChk.Name + "_" + voltageChk.State.ToString());
            voltmetr1.Set_Value = voltageChk.State ? 75 : 35;
        }
    }
}