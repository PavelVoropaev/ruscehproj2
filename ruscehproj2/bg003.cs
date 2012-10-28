using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bg003 : genericForm
    {
        public bg003()
        {
            InitializeComponent();
            FormManager.BT006 = new bt006 {voltmetr1 = {Set_Value = 50}};
        }

        private void eject_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg003_eject_On"))
            {
                eject.BackgroundImage = Resources.bg003E;
                return;
            }
            if (FormManager.hlp.hlpRefresh("bg003_eject_Off"))
            {
                eject.BackgroundImage = null;
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg003_potenzhiomert1_" + potenzhiomert1.getValue().ToString()))
            {
                FormManager.bg21.Activate();
                FormManager.hlp.hlpRefresh("");
            }

            FormManager.bg21.voltmetr1.Set_Value = potenzhiomert1.getValue();
        }

        private void potenzhiomert2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg003_potenzhiomert2_" + potenzhiomert2.getValue().ToString()))
            {
                FormManager.bg21.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            FormManager.bg21.voltmetr1.Set_Value = potenzhiomert2.getValue();
        }

        private void potenzhiomert3_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg003_potenzhiomert3_" + potenzhiomert3.getValue().ToString()))
            {
                FormManager.bg21.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            FormManager.bg21.voltmetr1.Set_Value = potenzhiomert3.getValue();
        }

        private void potenzhiomert4_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg003_potenzhiomert4_" + potenzhiomert4.getValue().ToString()))
            {
                FormManager.bg21.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            FormManager.bg21.voltmetr1.Set_Value = potenzhiomert4.getValue();
        }

        private void potenzhiomert5_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg003_potenzhiomert5_" + potenzhiomert5.getValue().ToString()))
            {
                FormManager.bg21.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            FormManager.bg21.voltmetr1.Set_Value = potenzhiomert5.getValue();
        }

        private void contr_MouseUp(object sender, MouseEventArgs e)
        {
            FormManager.BT006.voltmetr1.Set_Value = 50;
        }

        private void contr_MouseDown(object sender, MouseEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg003_contr");
            FormManager.BT006.Show();
            FormManager.BT006.voltmetr1.Set_Value = 0;
        }
    }
}