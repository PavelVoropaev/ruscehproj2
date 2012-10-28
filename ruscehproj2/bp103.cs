using System;

namespace ruscehproj2
{
    public partial class bp103 : genericForm
    {
        public bp103()
        {
            InitializeComponent();
            tumbler1.Setskin(2);
            bulb1.setLampType("green");
            bulb2.setLampType("green");
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (tumbler1.State)
            {
                voltmetr1.Set_Value = volt.getValue();
                if (FormManager.hlp.hlpRefresh(Name + "_" + volt.Name + "_" + voltmetr1.current_Value.ToString()))
                    volt.Enabled = false;
            }
        }

        private void bp001_tumbler1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + tumbler1.Name))
            {
                voltmetr1.Set_Value = 55;
                bulb1.setState(true);
                bulb2.setState(true);
                FormManager.shp1.bulb3.setState(true);
                FormManager.shp1.bulb4.setState(true);
                FormManager.shp1.bulb5.setState(true);
                tumbler1.Enabled = false;
            }
        }
    }
}