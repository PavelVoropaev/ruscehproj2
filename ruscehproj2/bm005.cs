using System;

namespace ruscehproj2
{
    public partial class bm005 : genericForm
    {
        public bm005()
        {
            InitializeComponent();
            voltmetr1.Set_Value = 67;
        }

        private void voltage_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + voltage.Name + "_" + voltage.Step.ToString());
            voltmetr1.Set_Value = voltage.Step == 0 ? 60 : 0;
        }
    }
}