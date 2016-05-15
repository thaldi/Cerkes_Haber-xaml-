
using System;
using Xamarin.Forms;

namespace Cerkes_Haber.Model
{
    public class Event
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string CreatedDate { get; set; } 
        public ImageSource EventTypeFlag { get; set; }
        public string Place { get; set; }
    }
}
