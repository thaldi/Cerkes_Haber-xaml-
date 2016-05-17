using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cerkes_Haber.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Events;
            ActivityPanel.BindingContext = App.Locator.Activities;


            SetImageUri();
            SetMenuItemEvents();


        }

        //main menu image uri set
        private void SetImageUri()
        {
            profile.Source = Device.OnPlatform(
                Android: ImageSource.FromResource("profile.png"),
                iOS: ImageSource.FromResource("profile.png"),
                WinPhone: ImageSource.FromFile("Assets/images/profile.png")
                );
            activity.Source = Device.OnPlatform(
              Android: ImageSource.FromResource("activity.png"),
              iOS: ImageSource.FromResource("activity.png"),
              WinPhone: ImageSource.FromFile("Assets/images/activity.png")
              );
            news.Source = Device.OnPlatform(
              Android: ImageSource.FromResource("news.png"),
              iOS: ImageSource.FromResource("news.png"),
              WinPhone: ImageSource.FromFile("Assets/images/new.png")
              );
            home.Source = Device.OnPlatform(
              Android: ImageSource.FromResource("home.png"),
              iOS: ImageSource.FromResource("home.png"),
              WinPhone: ImageSource.FromFile("Assets/images/home.png")
              );
        }


        //main menu image events
        private void SetMenuItemEvents()
        {
            home.GestureRecognizers.Add(new TapGestureRecognizer(this.homeClick));
            profile.GestureRecognizers.Add(new TapGestureRecognizer(this.profileClick));
            activity.GestureRecognizers.Add(new TapGestureRecognizer(this.activityClick));
            news.GestureRecognizers.Add(new TapGestureRecognizer(this.newsClick));
        }

        private void profileClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetAllCollapsed();
            ProfilePanel.IsVisible = true;
        }

        private void activityClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetAllCollapsed();
            ActivityPanel.IsVisible = true;
        }

        private void newsClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetAllCollapsed();
            NewsPanel.IsVisible = true;
        }

        private void homeClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetAllCollapsed();
            HomePanel.IsVisible = true;
        }
        private void  SetAllCollapsed()
        {
            ProfilePanel.IsVisible = false;
            HomePanel.IsVisible = false;
            ActivityPanel.IsVisible = false;
            NewsPanel.IsVisible = false;
        }

    }
}
