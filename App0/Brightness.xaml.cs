using Microsoft.Maui.Controls; // Ensure the correct namespace is included
namespace App0
{
    public partial class Brightness : ContentPage
    {
        public Brightness()
        {
            InitializeComponent();
        }
        private void OnBrightnessSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double brightness = args.NewValue; // Use args instead of e
            brightnessLabel.Text = $"Brightness: {(int)(brightness * 100)}%";
            AdjustBrightness(brightness);
        }
        private void AdjustBrightness(double brightness)
        {
            // Convert double to float for Color constructor
            float lightness = (float)(1 - brightness);
            // Set background color based on brightness
            BackgroundColor = new Color(lightness, lightness, lightness);
            // Adjust text color for contrast
            brightnessLabel.TextColor = lightness < 0.5f ? Colors.White : Colors.Black;
        }
    }
}










