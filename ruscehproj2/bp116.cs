namespace ruscehproj2
{
    public partial class bp116 : genericForm
    {
        public bp116()
        {
            InitializeComponent();
            mode.setPosNum(4);
            mode.skin = 2;
            mode2.setPosNum(4);
            mode2.skin = 2;
            mode.Step = 1;
            mode2.Step = 1;
            bulb1.setLampType("red");
        }

        private void mode_Click(object sender, System.EventArgs e)
        {
           //if ( !FormManager.hlp.hlpRefresh("bp116_forced"))
            FormManager.hlp.hlpRefresh("bp116_mode_" + mode.Step.ToString());

        }

        private void bp116_Click(object sender, System.EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bp116_forced");
        }

        private void bp116_Load(object sender, System.EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bp116_forced");
            FormManager.hlp.decrErrorCount();
        }

        private void mode2_Click(object sender, System.EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bp116_mode2_" + mode2.Step.ToString());
        }

        private void voltmetr1_Click(object sender, System.EventArgs e)
        {
            voltmetr1.zoom(50);
        }

        private void voltmetr5_Click(object sender, System.EventArgs e)
        {
            voltmetr5.zoom(50);
        }
    }
}
