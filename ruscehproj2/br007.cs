using System;

namespace ruscehproj2
{
    public partial class br007 : genericForm
    {
        public br007()
        {
            InitializeComponent();
        }

        private void door3_Click(object sender, EventArgs e)
        {
            door2.BringToFront();
            FormManager.hlp.hlpRefresh(Name + "_door3");
        }

        private void door2_Click(object sender, EventArgs e)
        {
            door1.BringToFront();
            FormManager.hlp.hlpRefresh(Name + "_door2");
        }

        private void door1_Click(object sender, EventArgs e)
        {
            door3.BringToFront();
            FormManager.hlp.hlpRefresh(Name + "_door1");
        }

        private void tokSmes_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + tokSmes.Name + "_" + tokSmes.getValue());
            try
            {
                FormManager.br41.voltmetr1.Set_Value = tokSmes.getValue() + 20;
            }
            catch
            {
            }
        }

        private void getNastr_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + getNastr.Name + "_" + getNastr.getValue());
            try
            {
                FormManager.br41.Show();
                FormManager.br41.TopMost = true;
                FormManager.br41.Left = Left + Width;
                Activate();
                FormManager.hlp.hlpRefresh("");
                FormManager.br41.voltmetr1.Set_Value = getNastr.getValue();
            }
            catch
            {
            }
        }
    }
}