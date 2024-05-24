﻿using CommunityToolkit.Maui.Views;
using Mopups.Pages;
using Mopups.PreBaked.Services;
using Mopups.Services;

namespace WebViewCrashMidLoad
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new AppShell();
        }

        ~MainPage()
        {
            Console.WriteLine("MainPage destroyed");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            GC.Collect();
            Console.WriteLine("GC.Collect()" + $" Memory used: {GC.GetTotalMemory(false)}");
            int count = Application.Current.Windows.Count;
        }
    }
}
