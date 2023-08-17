using OutsourcerTracking.Models.OutsouceUserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IOutsourceUserService
    {
        List<OutsourceUserViewModel> GetAllFullRelation();
        void AddRelational(OutsourceUserCreateViewModel viewModel, string currentUserName);
        OutsourceUserEditViewModel GetRealtionalById(int id);
        void EditRelational(OutsourceUserEditViewModel viewModel, string currentUserName);
        void Delete(int id, string currentUserName);
    }
}
