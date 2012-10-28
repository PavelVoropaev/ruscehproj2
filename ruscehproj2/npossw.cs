using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public sealed partial class nPosSwitch : UserControl
    {
        private int i;
        private int pos = 4;
        public int skin = 1;

        public nPosSwitch()
        {
            InitializeComponent();
            BackgroundImage = Resources.nPos;
            BackgroundImageLayout = ImageLayout.Stretch;
            draw();
        }

        public int Step
        {
            set { i = value; }
            get
            {
                int _i = i;
                _i++;
                if (_i > pos - 1) _i = 0;
                return _i;
            }
        }

        private void draw()
        {
            switch (pos)
            {
                case 2:
                    if (skin == 1)
                    {
                        BackgroundImage = rotateImage(Resources.nPos, 330 + i*45);
                    }
                    if (skin == 2)
                    {
                        BackgroundImage = rotateImage(Resources.nPos, 270 + 2*i*45);
                    }
                    break;

                case 3:
                    BackgroundImage = rotateImage(Resources.nPos, 315 + i*45);

                    break;
                case 4:
                    if (skin == 1)
                    {
                        BackgroundImage = rotateImage(Resources.nPos, 315 + i*30);
                    }
                    if (skin == 2)
                    {
                        BackgroundImage = rotateImage(Resources.nPos, 270 + i*90);
                    }
                    break;
                case 5:
                    BackgroundImage = rotateImage(Resources.nPos, 290 + i*35);
                    break;
                case 6:
                    BackgroundImage = rotateImage(Resources.nPos, 285 + i*30);
                    break;
                case 8:
                    BackgroundImage = rotateImage(Resources.nPos, 230 + i*30);
                    break;
                case 9:
                    BackgroundImage = rotateImage(Resources.nPos, 230 + i*32);
                    break;
                case 10:
                    BackgroundImage = rotateImage(Resources.nPos, 230 + i*30);
                    break;
                case 11:
                    BackgroundImage = rotateImage(Resources.nPos, 220 + 28*i);
                    break;
                case 12:
                    BackgroundImage = rotateImage(Resources.nPos, 220 + 28*i);
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

        public void setPosNum(int _pos)
        {
            pos = _pos;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            draw();
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            Width = Width;
            Height = Height;
        }


        private void nPosSwitch_MouseClick(object sender, MouseEventArgs e)
        {
            i++;
            if (i > pos - 1) i = 0;
            draw();
        }
    }
}