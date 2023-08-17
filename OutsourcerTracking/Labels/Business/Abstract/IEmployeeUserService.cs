using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.EmployeeUserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IEmployeeUserService
    {
        List<EmployeeUserViewModel> GetAllFullRelation();
        void AddRelational(EmployeeUserCreateViewModel createVM, string currentUser);
        EmployeeUserEditViewModel GetRealtionalById(int id);
        void EditRelational(EmployeeUserEditViewModel editVM, string currentUserName);
        void Delete(int id, string currentUserName);
        List<User> GetTransporterNames();
    }
}
