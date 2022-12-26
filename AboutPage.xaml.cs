namespace notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	public void InitialComponent()
	{

	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
		await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}