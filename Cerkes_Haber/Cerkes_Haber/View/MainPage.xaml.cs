using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Cerkes_Haber.Enum;

namespace Cerkes_Haber.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Events;
            ActivityPanel.BindingContext = App.Locator.Activities;

            SetSelectedPivotImage(PivotEnum.Main);

            SetMenuItemEvents();

            SetLists();

            EventsList.ItemSelected += EventsList_ItemSelected;

        }

        private void EventsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new View.EventDetailPage(), true);
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
            btnEditProfile.GestureRecognizers.Add(new TapGestureRecognizer(this.EditProfileClick));
        }

        private async void EditProfileClick(Xamarin.Forms.View arg1, object arg2)
        {
            await DisplayAlert("Notice", "Navigated to Edit Profile Page", "OK", "CANCEL");
        }

        private void profileClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetAllCollapsed();
            ProfilePanel.IsVisible = true;
            SetSelectedPivotImage(PivotEnum.Profile);
        }

        private void activityClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetSelectedPivotImage(PivotEnum.Activity);
            SetAllCollapsed();
            ActivityPanel.IsVisible = true;
        }

        private void newsClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetSelectedPivotImage(PivotEnum.New);
            SetAllCollapsed();
            NewsPanel.IsVisible = true;
        }

        private void homeClick(Xamarin.Forms.View arg1, object arg2)
        {
            SetSelectedPivotImage(PivotEnum.Main);
            SetAllCollapsed();
            HomePanel.IsVisible = true;
        }
        //all pivot collapsed
        private void SetAllCollapsed()
        {
            ProfilePanel.IsVisible = false;
            HomePanel.IsVisible = false;
            ActivityPanel.IsVisible = false;
            NewsPanel.IsVisible = false;
        }


        private void SetSelectedPivotImage(PivotEnum pivot)
        {
            SetImageUri();
            switch (pivot)
            {
                case PivotEnum.Main:
                    home.Source = Device.OnPlatform(
                    Android: ImageSource.FromResource("home2.png"),
                    iOS: ImageSource.FromResource("home2.png"),
                    WinPhone: ImageSource.FromFile("Assets/images/home2.png"));
                    break;
                case PivotEnum.Profile:
                    profile.Source = Device.OnPlatform(
                    Android: ImageSource.FromResource("profile2.png"),
                    iOS: ImageSource.FromResource("profile2.png"),
                    WinPhone: ImageSource.FromFile("Assets/images/profile2.png"));
                    break;
                case PivotEnum.New:
                    news.Source = Device.OnPlatform(
                    Android: ImageSource.FromResource("new2.png"),
                    iOS: ImageSource.FromResource("new2.png"),
                    WinPhone: ImageSource.FromFile("Assets/images/new2.png"));
                    break;
                case PivotEnum.Activity:
                    activity.Source = Device.OnPlatform(
                    Android: ImageSource.FromResource("activity2.png"),
                    iOS: ImageSource.FromResource("activity2.png"),
                    WinPhone: ImageSource.FromFile("Assets/images/activity2.png"));
                    break;
            }
        }

        //pickerları doldurur
        private void SetLists()
        {
            foreach (var item in Helper.ListHelper.CityList)
                cmbEventCities.Items.Add(item);
            foreach (var item in Helper.ListHelper.CountryList)
                cmbEventCountry.Items.Add(item);
            cmbEventCountry.SelectedIndex = 0;
            cmbEventCities.SelectedIndex = 0;
        }



    }
}
