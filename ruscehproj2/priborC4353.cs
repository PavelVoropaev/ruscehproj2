namespace ruscehproj2
{
    public partial class priborC4353 : genericForm
    {
        public priborC4353()
        {
            InitializeComponent();
        }

        public void setInitialValue(int _in)
        {
            voltmetr1.Set_Value = _in;
        }

        public void setBarStep(int _in)
        {
            voltmetr1.Set_Bar_step = _in;
        }
    }
}