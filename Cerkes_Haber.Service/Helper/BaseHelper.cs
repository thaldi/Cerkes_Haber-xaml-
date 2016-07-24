using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Cerkes_Haber.Service.Helper
{
    public class BaseHelper
    {
        public SqlConnection SqlClient { get; set; }

        public BaseHelper()
        {
            Helper.QueryHelper qHelper = new QueryHelper();

            SqlClient = new SqlConnection(qHelper.ConnectionString);
            CheckConnection();
        }

        private void CheckConnection()
        {
            if (SqlClient.State == ConnectionState.Closed)
            {
                SqlClient.Open();
            }
        }



    }
}