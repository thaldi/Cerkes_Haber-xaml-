using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cerkes_Haber.Service.Helper
{
    public class QueryHelper
    {
        public string ConnectionString { get; set; }

        public QueryHelper()
        {
            ConnectionString = "Server=tcp:h10g2pylri.database.windows.net,1433;Database=CerkesHaber.Database;User ID=thaldi@h10g2pylri;Password=Apsuwa_.4529;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
        }


    }
}