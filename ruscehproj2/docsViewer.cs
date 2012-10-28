using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class docsViewer : Form
    {
        public docsViewer()
        {
            InitializeComponent();
        }

        public docsViewer(string _docPath)
        {
            InitializeComponent();
            browser.Navigate(Application.StartupPath + _docPath);
        }
    }
}