using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cerkes_Haber.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            btnRegister.Clicked += BtnRegister_Clicked;
        }

        private async void BtnRegister_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new View.RegisterPage());
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new View.MainPage());
        }
    }
}
