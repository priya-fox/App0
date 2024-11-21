namespace App0;

public partial class LightDark : ContentPage
{
    public LightDark()
    {
        InitializeComponent();
        SetTheme();
    }
    private void SetTheme()
    {
        if (App.Current.RequestedTheme == AppTheme.Dark)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }

    private void OnThemeToggled(object sender, ToggledEventArgs e)
    {
        SetTheme();
    }
}



   
   