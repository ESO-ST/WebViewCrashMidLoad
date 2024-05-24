namespace WebViewCrashMidLoad
{
    public partial class ShellPage : ContentPage
    {
        public ShellPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        ~ShellPage()
        {
            Console.WriteLine("ShellPage destroyed");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            GC.Collect();
            Console.WriteLine("GC.Collect()" + $" Memory used: {GC.GetTotalMemory(false)}");
            int count = Application.Current.Windows.Count;
        }
    }
}
