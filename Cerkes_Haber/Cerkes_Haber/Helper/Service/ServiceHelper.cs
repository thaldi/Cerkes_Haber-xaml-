using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cerkes_Haber.Model.ResponseModel;
using Newtonsoft.Json;
using Windows.Data.Json;

namespace Cerkes_Haber.Helper.Service
{
    public class ServiceHelper
    {
        public async Task<List<Events.RootObject>> GetEvents()
        {
            using (var client = new HttpClient())
            {
                var data = await client.GetStringAsync(Constant.ApplicationConstant.EventUrl);
                

                var obj = JsonConvert.DeserializeObject<List<Events.RootObject>>(data);

                return (
                                obj
                    );

            }
        }
    }
}
