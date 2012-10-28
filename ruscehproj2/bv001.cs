using System;

namespace ruscehproj2
{
    public partial class bv001 : genericForm
    {
        public bool kit1 = false;
        public bool kit2 = false;

        public bv001()
        {
            InitializeComponent();
            kit2lump.setLampType("green");
            kit1lump.setLampType("green");
        }

        private void kit1on_Click(object sender, EventArgs e)
        {
            kit1 = true;
            kit2 = false;
            if (FormManager.hlp.hlpRefresh(Name + "_kit1on"))
            {
                kit1lump.setState(true);
            }
        }

        private void kit2on_Click(object sender, EventArgs e)
        {
            kit2 = true;
            kit1 = false;
            if (FormManager.hlp.hlpRefresh(Name + "_kit2on"))
            {
                kit2lump.setState(true);
            }
        }

        private void kit1off_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_kit1off"))
            {
                kit1lump.setState(false);
            }
        }

        private void kit2off_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_kit2off"))
            {
                kit2lump.setState(false);
            }
        }

        private void bv001_Load(object sender, EventArgs e)
        {
            if (Name == "bv002")
            {
                Title.Text = "Блок" + '\n' + "дальности";
                Text = "БВ-002";
            }
            if (Name == "bv001")
            {
                Title.Text = "Блок" + '\n' + "азимута";
                Text = "БВ-001";
            }
        }
    }
}