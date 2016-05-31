using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Cerkes_Haber.View
{
    public class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            Master = new ContentPage()
            {
                //yeni bir page yazılacak soldan açılan hamburger menü için
                //to do: hamburger menü açık akapam olayı muallakta öğren
                




            };
            Detail = new NavigationPage(new MainPage());
        }


    }
}
