using OutsourceTrackingWorkerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourceTrackingWorkerService.Facade
{
    public interface IFacade
    {
        Task<HttpResponseMessage> ControlChangesAsync();
        Task<HttpResponseMessage> GetOutsourceChangesAsync();
        Task SendOutsourceIntegratedIds(List<int> ids);
    }
}
