using Mopups.Pages;
using Mopups.Services;

namespace WebViewCrashMidLoad;

public partial class OtherPage : PopupPage
{
	public OtherPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(System.Object sender, System.EventArgs e)
    {
		MopupService.Instance.PopAsync();
    }
}