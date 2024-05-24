namespace WebViewCrashMidLoad
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        ~AppShell()
        {
            Console.WriteLine("AppShell destroyed");
        }
    }
}
