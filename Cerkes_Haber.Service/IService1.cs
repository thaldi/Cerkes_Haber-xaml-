using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Cerkes_Haber.Models.Models;


namespace Cerkes_Haber.Service
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool SaveUSer(User user);

        [OperationContract]
        bool Login(Login login);



    }



}
