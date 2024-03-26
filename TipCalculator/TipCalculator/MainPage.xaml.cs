using CoreBluetooth;
using IntentsUI;

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
            PercentagesSlider.Value = 15;
        }

        private void ButtonPercento30_Clicked(object sender, EventArgs e)
        {
            PercentagesSlider.Value = 30;

        }

        private void ButtonUp_Clicked(object sender, EventArgs e)
        {
            double tip = CalculateTip();
            tip = Math.Ceiling(tip);
            TigLabel.Text = Convert.ToString("C2");
            double valort = tip + Convert.ToDouble(ValueEntry.Text);
            TotalLabel.Text = valort.ToString("C2");
        }

        private void ButtonDown_Clicked(object sender, EventArgs e)
        {
            
        }

        private double CalculateTip()
        {
            double valorT = Convert.ToDouble(ValueEntry.Text);
            double porcntagem = PercentagesSlider.Value;
            double valorGorgeta = valorT * (porcntagem / 100) ;
            return (valorGorgeta);



        }

        private void PercentagesSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PorcenLabel.Text = $"{PercentagesSlider.Value.ToString ()}%";     
        }
    }

}
