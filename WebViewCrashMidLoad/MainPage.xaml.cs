using CommunityToolkit.Maui.Views;
using Mopups.Pages;
using Mopups.PreBaked.Services;
using Mopups.Services;

namespace WebViewCrashMidLoad
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            MopupService.Instance.PushAsync(new PopupPage2());
        }
    }

}
