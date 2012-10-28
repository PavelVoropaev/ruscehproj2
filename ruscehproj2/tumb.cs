using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public sealed partial class tumbler : UserControl
    {
        private bool isOn;
        private bool sided;
        private int skin = 1;
        private Bitmap sw = new Bitmap(Resources.tmb);

        public tumbler()
        {
            InitializeComponent();

            BackgroundImage = sided ? rotateImage(sw, !isOn ? 90 : 270) : rotateImage(sw, !isOn ? 180 : 0);
        }

        public int Set_Skin
        {
            get { return skin; }
            set { skin = value; }
        }

        public bool isSided
        {
            get { return sided; }
            set { sided = value; }
        }

        public bool State
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public void Setskin(int skin_id)
        {
            skin = skin_id;
            switch (skin_id)
            {
                case 1:
                    sw = (Resources.tmb);
                    break;
                case 2:
                    sw = (Resources.tmb2);
                    break;
                case 3:
                    sw = Resources.tmb3;
                    break;
                default:
                    sw = (Resources.tmb);
                    break;
            }
        }

        private Bitmap rotateImage(Bitmap input, int angle)
        {
            var result = new Bitmap(input.Width, input.Height);
            Graphics g = Graphics.FromImage(result);
            g.TranslateTransform((float) input.Width/2, (float) input.Height/2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float) input.Width/2, -(float) input.Height/2);
            g.DrawImage(input, new Point(0, 0));
            return result;
        }

        private void tumbler_Click(object sender, EventArgs e)
        {
            if (skin != 3)
            {
                BackgroundImage = sided ? rotateImage(sw, !isOn ? 90 : 270) : rotateImage(sw, !isOn ? 180 : 0);
            }
            isOn = !isOn;
            if (skin == 3)
            {
                BackgroundImage = isOn ? Resources.tmb4 : Resources.tmb3;
            }
        }

        private void tumbler_Load(object sender, EventArgs e)
        {
            if (sided)
            {
                BackgroundImage = rotateImage(sw, isOn ? 270 : 90);
            }
            if (!sided)
            {
                BackgroundImage = rotateImage(sw, isOn ? 180 : 0);
            }
        }
    }
}