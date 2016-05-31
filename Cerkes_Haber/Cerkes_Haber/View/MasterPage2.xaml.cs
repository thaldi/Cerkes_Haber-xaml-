using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cerkes_Haber.View
{
    public partial class MasterPage2 : MasterDetailPage
    {
        public MasterPage2()
        {
            InitializeComponent();
            SetContent();
        }

        private void SetContent()
        {
            this.Detail = new NavigationPage(new View.MainPage());
        }
    }
}
