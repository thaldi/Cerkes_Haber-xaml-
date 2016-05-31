using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cerkes_Haber.View
{
    public partial class EventDetailPage : ContentPage
    {
        public EventDetailPage()
        {
            InitializeComponent();
            SetEventForImage();
        }


        private void SetEventForImage()
        {
            btnJoinEvent.GestureRecognizers.Add(new TapGestureRecognizer(this.JoinEventClick));
        }

        uint counter = 0;

        private async void JoinEventClick(Xamarin.Forms.View arg1, object arg2)
        {
            //await DisplayAlert("Katılım", "Bu etkiniği katılıyor olarak işaretlediniz.", "OK");
            counter++;
            txtCounter.Text = counter.ToString();
        }
    }
}
