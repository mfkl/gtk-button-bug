﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GTK_Button_bug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = new MainPage();
            NavigationPage.SetHasNavigationBar(mainPage, false);

            var navPage = new NavigationPage(mainPage);
            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
