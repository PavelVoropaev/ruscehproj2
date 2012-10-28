using System;

namespace ruscehproj2
{
    public partial class vi001 : genericForm
    {
        public vi001()
        {
            InitializeComponent();
            tumb2.setPosNum(2);
        }

        private void tumb2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_tumb2_" + tumb2.Step.ToString()))

            {
                try
                {
                    FormManager.BT006.voltmetr1.Set_Value = 70;
                }
                catch
                {
                }
            }
        }

        private void wire_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("vi001_wire");
        }
    }
}