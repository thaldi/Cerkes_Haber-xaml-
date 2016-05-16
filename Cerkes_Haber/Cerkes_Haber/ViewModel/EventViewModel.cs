using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using Cerkes_Haber.Model;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace Cerkes_Haber.ViewModel
{
    public class EventViewModel : ViewModelBase
    {
        private ObservableCollection<Event> eventList;
        public ObservableCollection<Event> EventList
        {
            get { return eventList; }
            set { Set(() => EventList, ref eventList, value); }
        }

        private RelayCommand refreshCommand;

        public RelayCommand RefreshCommand
        {
            get
            {
                return refreshCommand ?? (
                    refreshCommand = new RelayCommand(() =>
                    {
                        EventList.Add(new Event { Name = "Düğün", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd" });
                        EventList.Add(new Event { Name = "Düğün2", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd" });
                        EventList.Add(new Event { Name = "Düğün3", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd" });
                        EventList.Add(new Event { Name = "Düğün4", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd" });
                        EventList.Add(new Event { Name = "Düğün6", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd" });
                    }));
            }
        }

        private int count = 0;
        private RelayCommand addCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (

                    addCommand = new RelayCommand(() =>
                    {
                        count++;
                        EventList.Add(new Event { Name = "Düğün" + count, Description = "fdsafsdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now) });
                    }));
            }
        }

        private bool isRuning;
        public bool IsRuning
        {
            get { return isRuning; }
            set { Set(() => IsRuning, ref isRuning, value); }
        }

        //public EventViewModel(IMessenger messenger) : base(messenger)
        //{
        //}

        public EventViewModel()
        {
            EventList = new ObservableCollection<Event>();
            EventList.Add(new Event { Name = "Düğün", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Place = "Kayseri", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/dugun.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Sample Event" });
            EventList.Add(new Event { Name = "Düğün", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/dugun.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Sample Event", Place = "Sivas" });
            EventList.Add(new Event { Name = "Ceug", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/ceug.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Sample Event 2", Place = "Yeni Yapan" });
            EventList.Add(new Event { Name = "Cenaze", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/cenaze.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Samole Event 3" });
            EventList.Add(new Event { Name = "Düğün", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Place = "Kayseri", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/dugun.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Sample Event" });
            EventList.Add(new Event { Name = "Düğün", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/dugun.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Sample Event", Place = "Sivas" });
            EventList.Add(new Event { Name = "Ceug", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/ceug.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Sample Event 2", Place = "Yeni Yapan" });
            EventList.Add(new Event { Name = "Cenaze", Description = "sfsdfgghhfdjhbxcbcvbvc sdfsdfsd", Date = String.Format("{0:M/d/yyyy}", DateTime.Now), EventTypeFlag = ImageSource.FromFile("Assets/images/cenaze.png"), CreatedDate = String.Format("{0:M/d/yyyy}", DateTime.Now), Title = "Samole Event 3" });
        }

    }
}
