using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace Cerkes_Haber.Helper.Database
{
    public interface DBHelper
    {
        SQLite.SQLiteConnection Connection();

    }
}
