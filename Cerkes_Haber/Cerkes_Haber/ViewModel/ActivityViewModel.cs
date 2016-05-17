using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;

namespace Cerkes_Haber.ViewModel
{
    public class ActivityViewModel : ViewModelBase
    {
        public ActivityViewModel()
        {
            ActivityList = new ObservableCollection<Model.Activity>();
            ActivityList.Add(new Model.Activity { EventName = "Sample Event 1", EventID = 231312, Date = DateTime.Now.ToUniversalTime().ToString() });
            ActivityList.Add(new Model.Activity { EventName = "Sample Event 2", EventID = 231312, Date = DateTime.Now.ToUniversalTime().ToString() });
            ActivityList.Add(new Model.Activity { EventName = "Sample Event 3", EventID = 231312, Date = DateTime.Now.ToUniversalTime().ToString() });
            ActivityList.Add(new Model.Activity { EventName = "Sample Event 4", EventID = 231312, Date = DateTime.Now.ToUniversalTime().ToString() });
            ActivityList.Add(new Model.Activity { EventName = "Sample Event 5", EventID = 231312, Date = DateTime.Now.ToUniversalTime().ToString() });
        }


        private ObservableCollection<Model.Activity> activityList;

        public ObservableCollection<Model.Activity> ActivityList
        {
            get { return activityList; }
            set { Set(() => ActivityList, ref activityList, value); }
        }



    }
}
