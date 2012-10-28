using System;

namespace ruscehproj2
{
    public partial class uvch : genericForm
    {
        public uvch()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            bulb2.setLampType("green");
        }

        private void pwr1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + pwr1.Name + "_" + pwr1.State);
            bulb1.setState(pwr1.State);
        }

        private void pwr2_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + pwr2.Name + "_" + pwr2.State);
            bulb2.setState(pwr2.State);
        }
    }
}