using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class ground : UserControl
    {
        public ground()
        {
            InitializeComponent();
        }

        public void wireOn()
        {
            BackgroundImage = Resources.groungWire;
        }

        public void wireOff()
        {
            BackgroundImage = Resources.ground;
        }
    }
}