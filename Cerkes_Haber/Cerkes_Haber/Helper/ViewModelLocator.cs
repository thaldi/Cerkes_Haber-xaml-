using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cerkes_Haber.ViewModel;


namespace Cerkes_Haber.Helper
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<EventViewModel>();
            SimpleIoc.Default.Register<ActivityViewModel>();

        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public EventViewModel Events
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EventViewModel>();
            }
        }

        public ActivityViewModel Activities
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ActivityViewModel>();
            }
        }

    }
}
