using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bg005 : genericForm
    {
        public bg005()
        {
            InitializeComponent();
            FormManager.BT006 = new bt006 {voltmetr1 = {Set_Value = 50}};
        }

        private void eject_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg005_eject_On"))
            {
                eject.BackgroundImage = Resources.bg003E;
                return;
            }
            if (FormManager.hlp.hlpRefresh("bg005_eject_Off"))
            {
                eject.BackgroundImage = null;
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            try
            {
                FormManager.bg0041.voltmetr1.Set_Value = potenzhiomert1.getValue();
                if (FormManager.hlp.hlpRefresh("bg005_potenzhiomert1_" + potenzhiomert1.getValue().ToString()))
                {
                    FormManager.bp61.bulb1.setState(true);
                    FormManager.bg0041.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
            }
            catch
            {
            }
        }

        private void potenzhiomert2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            try
            {
                FormManager.bg0041.voltmetr1.Set_Value = potenzhiomert2.getValue();
                if (FormManager.hlp.hlpRefresh("bg005_potenzhiomert2_" + potenzhiomert2.getValue().ToString()))
                {
                    FormManager.bg0041.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
            }
            catch
            {
            }
        }

        private void potenzhiomert3_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            try
            {
                FormManager.bg0041.voltmetr1.Set_Value = potenzhiomert3.getValue();
                if (FormManager.hlp.hlpRefresh("bg005_potenzhiomert3_" + potenzhiomert3.getValue().ToString()))
                {
                    FormManager.bg0041.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
            }
            catch
            {
            }
        }


        private void bg005_Load(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg005_showBT006"))
            {
                FormManager.BT006 = new bt006();
                FormManager.BT006.Show();
                FormManager.BT006.TopMost = true;
                Top = 0;
                Left = 0;
                FormManager.BT006.voltmetr1.Set_Value = 50;
                FormManager.BT006.Top = 0;
                FormManager.BT006.Left = Width + 10;
            }
            else
            {
                FormManager.hlp.decrErrorCount();
            }
        }

        private void contr_MouseUp(object sender, MouseEventArgs e)
        {
            FormManager.BT006.voltmetr1.Set_Value = 50;
        }

        private void contr_MouseDown(object sender, MouseEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bg005_contr");

            FormManager.BT006.voltmetr1.Set_Value = 0;
        }
    }
}