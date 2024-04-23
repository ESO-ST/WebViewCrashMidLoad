using Mopups.Pages;
using Mopups.Services;

namespace WebViewCrashMidLoad;

public partial class PopupPage2 : PopupPage
{
	public PopupPage2()
	{
		InitializeComponent();
	}

    private void OnCloseClicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}