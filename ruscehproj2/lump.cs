using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bulb : UserControl
    {
        private Bitmap _color = new Bitmap(Resources.lamp);
        private bool _isOn;
        private string _lampType = "";

        public bulb()
        {
            InitializeComponent();
        }

        public string SetColor
        {
            set { _lampType = value; }
            get { return _lampType; }
        }

        public bool getState()
        {
            return _isOn;
        }

        public void setState(bool _in)
        {
            _isOn = _in;
            if (_isOn)
            {
                BackgroundImage = _color;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (!_isOn)
            {
                BackgroundImage = Resources.lamp;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void setLampType(string _in)
        {
            switch (_in)
            {
                case "red":
                    _color = Resources.rdlamp;
                    break;
                case "green":
                    _color = Resources.grlamp;
                    break;

                case "yellow":
                    _color = Resources.ylamp;
                    break;
                default:
                    _color = Resources.grlamp;
                    break;
            }
        }

        private void bulb_Load(object sender, EventArgs e)
        {
            BackgroundImage = _isOn ? _color : Resources.lamp;
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (_lampType)
            {
                case "red":
                    _color = Resources.rdlamp;
                    break;
                case "green":
                    _color = Resources.grlamp;
                    break;
                case "yellow":
                    _color = Resources.ylamp;
                    break;
            }
        }
    }
}