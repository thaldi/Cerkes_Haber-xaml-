using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerkes_Haber.Model.ResponseModel
{
    public class Events
    {
        public class Event
        {
            public string __invalid_name__ { get; set; }
        }

        public class UserListInEvent
        {
            public string __invalid_name__ { get; set; }
            public Events Events { get; set; }
            public int Id { get; set; }
            public int EventID { get; set; }
            public string UserID { get; set; }
        }

        public class RootObject
        {
            public string __invalid_name__ { get; set; }
            public List<object> JoinPerson { get; set; }
            public List<UserListInEvent> UserListInEvent { get; set; }
            public int Id { get; set; }
            public string EventName { get; set; }
            public string EventDate { get; set; }
            public string CreatedDate { get; set; }
            public string Place { get; set; }
            public string City { get; set; }
            public string EventDescription { get; set; }
            public string EventType { get; set; }
            public string WhoAdded { get; set; }
            public int EventCount { get; set; }
        }
    }

}
