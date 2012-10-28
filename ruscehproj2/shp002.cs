using System;

namespace ruscehproj2
{
    public partial class shp002 : genericForm
    {
        public shp002()
        {
            InitializeComponent();
            tumbler1.Setskin(3);
            tumbler2.Setskin(3);
            tumbler3.Setskin(3);
            tumbler5.Setskin(3);
            tumbler6.Setskin(3);
            tumbler7.Setskin(3);
        }

        private void signal()
        {
            FormManager.hlp.hlpRefresh(Name + "_" + vent.Name + "_" +
                                       vent.State.ToString() +
                                       tumbler1.State.ToString() +
                                       tumbler2.State.ToString() +
                                       tumbler3.State.ToString() +
                                       tumbler5.State.ToString() +
                                       tumbler6.State.ToString() +
                                       tumbler7.State.ToString());
        }

        private void vent_Click(object sender, EventArgs e)
        {
            signal();
        }

        private void tumbler1_Click(object sender, EventArgs e)
        {
            signal();
        }

        private void tumbler2_Click(object sender, EventArgs e)
        {
            signal();
        }

        private void tumbler3_Click(object sender, EventArgs e)
        {
            signal();
        }

        private void tumbler5_Click(object sender, EventArgs e)
        {
            signal();
        }

        private void tumbler6_Click(object sender, EventArgs e)
        {
            signal();
        }

        private void tumbler7_Click(object sender, EventArgs e)
        {
            signal();
        }
    }
}