using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cerkes_Haber.Helper
{
    public class PlatformHelper
    {
        public Enum.Platform Platform { get; set; }


        public PlatformHelper()
        {
            Platform = Device.OnPlatform(
              Android: Enum.Platform.Android,
              iOS: Enum.Platform.iOS,
              WinPhone: Enum.Platform.UWP
              );
        }


    }
}
