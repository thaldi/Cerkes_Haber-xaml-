using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Cerkes_Haber
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new View.LoginPage());
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


        #region Locator for BindingContext

        private static Helper.ViewModelLocator locator;

        public static Helper.ViewModelLocator Locator
        {
            get { return locator ?? (locator = new Helper.ViewModelLocator()); }
        }    

        #endregion

    }
}
