namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonPercento15_Clicked(object sender, EventArgs e)
        {
       
        }

        private void ButtonPercento30_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonUp_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonDown_Clicked(object sender, EventArgs e)
        {

        }

        private void PercentagesSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PorcenLabel.Text = $"{PercentagesSlider.Value.ToString ()}%";     
        }
    }

}
