namespace WebViewCrashMidLoad;

public partial class OtherPage : ContentPage
{
	public OtherPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}