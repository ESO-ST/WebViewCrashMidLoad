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

    private async void OnCallActionSheetClicked(System.Object sender, System.EventArgs e)
    {
        await DisplayActionSheet("Action Sheet Clicked", "Cancel", "Destruction", "Action1", "Action2");
    }


}