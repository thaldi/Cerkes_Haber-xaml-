using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace Cerkes_Haber.View
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            SetLists();
            SetEvents();
        }


        private void SetEvents()
        {
            profileImage.GestureRecognizers.Add(new TapGestureRecognizer(this.SelectPic));        
        }

        private void SelectPic(Xamarin.Forms.View arg1, object arg2)
        {
           
        }

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
