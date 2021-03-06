﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Havadis
{
    public class App : Application
    {
        public static string ApiUrl { get; set; } = "http://havadis.azurewebsites.net/";
        public static string AppName { get; set; } = "Havadis";
        public App()
        {
            MainPage = new NavigationPage(new Views.NewsPage());
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
