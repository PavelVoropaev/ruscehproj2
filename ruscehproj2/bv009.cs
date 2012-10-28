using System;

namespace ruscehproj2
{
    public partial class bv009 : genericForm
    {
        public bv009()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            bulb2.setLampType("green");
            bulb3.setLampType("green");
            bulb4.setLampType("green");
            bulb5.setLampType("green");
            bulb6.setLampType("green");
        }

        private void dalOn_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + dalOn.Name))
            {
                try
                {
                    FormManager.bp61.voltmetr1.Set_Value = 96;
                    FormManager.bp61.voltmetr5.Set_Value = 96;
                }
                catch
                {
                    FormManager.bp61 = new bp116();
                }
                bulb1.setState(true);
            }
        }

        private void azOn_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + azOn.Name))
            {
                try
                {
                    FormManager.bp61.voltmetr1.Set_Value = 96;
                    FormManager.bp61.voltmetr5.Set_Value = 96;
                }
                catch
                {
                    FormManager.bp61 = new bp116();
                }
                bulb3.setState(true);
            }
        }

        private void anod1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + anod1.Name))
            {
                bulb2.setState(true);
                bulb5.setState(true);
            }
        }

        private void anod2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + anod2.Name))
            {
                //if (FormManager.hlp.scenarioId == 7)
                {
                    try
                    {
                        FormManager.bp61.voltmetr1.Set_Value = 96;
                        FormManager.bp61.voltmetr5.Set_Value = 96;
                    }
                    catch
                    {
                        FormManager.bp61 = new bp116();
                    }
                }
                bulb4.setState(true);
                bulb6.setState(true);
                FormManager.Init_e("");
            }
        }

        private void anod1Off_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + anod1Off.Name))
            {
                bulb2.setState(false);
                bulb5.setState(false);
            }
        }

        private void anod2Off_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + anod2Off.Name))
            {
                bulb4.setState(false);
                bulb6.setState(false);
            }
        }

        private void dalOff_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + dalOff.Name))
            {
                bulb1.setState(false);
            }
        }

        private void azOff_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + azOff.Name))
            {
                bulb3.setState(false);
            }
        }
    }
}