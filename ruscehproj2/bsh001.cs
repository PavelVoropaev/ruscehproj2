using System;

namespace ruscehproj2
{
    public partial class bsh001 : genericForm
    {
        #region Delegates

        public delegate void EventHandler(object _in, CustomEventArgs e);

        #endregion

        private readonly generator gen = new generator(true);
        private readonly priborC4353 pribor = new priborC4353();

        public bsh001()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            regZad.setPosNum(11);
            msek.setPosNum(11);
            imitator.setPosNum(4);
            voltageContr.setPosNum(9);
            codes.setPosNum(4);
        }

        public event EventHandler onRegZadChange;

        private void vkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name))
                bulb1.setState(true);
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name))
                bulb1.setState(false);
        }

        private void regZad_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + regZad.Name + "_" + regZad.Step.ToString());
            var regZadChanged = new CustomEventArgs(regZad.Step, msek.Step);
            if (onRegZadChange != null) onRegZadChange(this, regZadChanged);
        }

        private void msek_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + msek.Name + "_" + msek.Step.ToString());
            var regZadChanged = new CustomEventArgs(regZad.Step, msek.Step);
            if (onRegZadChange != null) onRegZadChange(this, regZadChanged);
        }

        private void vhod03_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bsh001_vhod03");
            pribor.setInitialValue(15);
            pribor.Show();
        }

        private void imitator_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + imitator.Name + "_" + imitator.Step.ToString());
            if (imitator.Step == 3 || imitator.Step == 0)
            {
                voltmetr1.Set_Value = 20;
            }
        }

        private void voltageContr_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + voltageContr.Name + "_" + voltageContr.Step.ToString());
            voltmetr1.Set_Value = 80;
            if (voltageContr.Step == 8 || voltageContr.Step == 4)
            {
                voltmetr1.Set_Value = 20;
            }
        }

        private void voltage_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + voltage.Name + "_" + voltage.getValue().ToString());
            voltmetr1.Set_Value = voltage.getValue() - 50;
        }

        private void eject_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_Off");
            }
            else
            {
                panel1.Visible = true;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_On");
            }
        }

        private void regNach_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_panel1_" + regNach.Name + "_" + regNach.getValue().ToString());
            voltmetr1.Set_Value = voltage.getValue();
        }

        private void vhodD_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_vhodD");
        }

        private void vyhodImit_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_vyhodImit");
        }

        private void kalibr_Value_Changed_1(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + kalibr.Name + "_" + kalibr.getValue());
            voltmetr1.Set_Value = kalibr.getValue();
        }

        private void razmer_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + izmer.Name);
            voltmetr1.Set_Value = 15;
            kalibr.Set_Value = 0;
            voltage.Set_Value = 0;
            generator.Visible = true;
        }

        private void generator_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + generator.Name);
            gen.Show();
            gen.TopMost = true;
            gen.Left = Left + Width;
            gen.Activate();
            FormManager.hlp.hlpRefresh("");
        }
    }
}