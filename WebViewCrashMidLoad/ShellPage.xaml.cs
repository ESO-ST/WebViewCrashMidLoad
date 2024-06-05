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
            long memoryUsed = GC.GetTotalMemory(false);
            Console.WriteLine("GC.Collect()" + $" Memory used: {memoryUsed}");
            memoryUsedBtn.Text = $"Memory used: {memoryUsed}";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            long memoryUsed = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory used: {memoryUsed}");
            memoryUsedBtn.Text = $"Memory used: {memoryUsed}";
        }
    }
}
