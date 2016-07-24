using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cerkes_Haber.Model.ResponseModel;

namespace Cerkes_Haber.Helper.Service
{
    public interface IServiceHelper
    {
        Task<List<Events>> GetEvents();

    }
}
