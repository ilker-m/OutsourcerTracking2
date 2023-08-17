using Microsoft.AspNetCore.Identity;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.EmployeeUserModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class EmployeeUserManager : IEmployeeUserService
    {
        private readonly IEmployeeUserDal _employeeUserDal;
        private readonly IUserDal _userDal;
        private readonly IUsersRolesDal _usersRolesDal;
        private readonly IRoleDal _roleDal;
        private readonly UserManager<User> _userManager;
        public EmployeeUserManager(IEmployeeUserDal employeeUserDal, IUserDal userDal, IUsersRolesDal usersRolesDal, IRoleDal roleDal, UserManager<User> userManager)
        {
            _employeeUserDal = employeeUserDal;
            _userDal = userDal;
            _usersRolesDal = usersRolesDal;
            _roleDal = roleDal;
            _userManager = userManager;
        }

        public void AddRelational(EmployeeUserCreateViewModel viewModel, string currentUser)
        {
            var user = new User
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                UserName = viewModel.FirstName + " " + viewModel.LastName,
                Email = viewModel.Email,
                LockoutEnabled = false,
                PhoneNumber = viewModel.Phone,
                IsActive = true,
                IsFirst = true,
                CreatedOn = DateTime.Now,
                CreatedBy = currentUser
            };
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, viewModel.Password);
            _userDal.Add(user);
            int lastId = _userDal.GetLastUserId();
            var employeeUser = new EmployeeUser
            {
                Id = lastId,
                DepartmentId = viewModel.DeparmentId,
                TitleId = viewModel.TitleId,
            };
            _employeeUserDal.Add(employeeUser);
            var userRole = new UsersRoles
            {
                RoleId = viewModel.RoleId,
                UserId = lastId
            };
            _usersRolesDal.Add(userRole);
        }

        public List<EmployeeUserViewModel> GetAllFullRelation()
        {
            return _employeeUserDal.GetAllFullRelational();
        }
        public EmployeeUserEditViewModel GetRealtionalById(int id)
        {
            var employeeUesr = _employeeUserDal.GetByIdWithUser(id);
            var role = _usersRolesDal.Get(r => r.UserId == id);
            return new EmployeeUserEditViewModel
            {
                Id = id,
                FirstName = employeeUesr.User.FirstName,
                LastName = employeeUesr.User.LastName,
                Email = employeeUesr.User.Email,
                Phone = employeeUesr.User.PhoneNumber,
                RoleId = role.RoleId,
                DeparmentId = employeeUesr.DepartmentId,
                TitleId = employeeUesr.TitleId
            };
        }
        public void EditRelational(EmployeeUserEditViewModel viewModel, string currentUserName)
        {
            var user = _userDal.Get(u => u.Id == viewModel.Id);
            user.FirstName = viewModel.FirstName;
            user.LastName = viewModel.LastName;
            user.UserName = viewModel.FirstName + " " + viewModel.LastName;
            user.Email = viewModel.Email;
            user.LockoutEnabled = false;
            user.PhoneNumber = viewModel.Phone;
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.UpdatedOn = DateTime.Now;
            user.UpdatedBy = currentUserName;
            _userDal.Update(user);
            var employeeUser = new EmployeeUser
            {
                Id = viewModel.Id,
                DepartmentId = viewModel.DeparmentId,
                TitleId = viewModel.TitleId,
            };
            _employeeUserDal.Update(employeeUser);
            var usersroles = _usersRolesDal.Get(ur => ur.UserId == viewModel.Id);
            usersroles.RoleId = viewModel.RoleId;
            _usersRolesDal.Update(usersroles);
            /*var oldUsersRoles = _usersRolesDal.Get(ur => ur.UserId == viewModel.OutsourceWorkOrderId);
            var oldRoleName = _roleDal.Get(r => r.OutsourceWorkOrderId == oldUsersRoles.RoleId).Name;
            var newRoleName = _roleDal.Get(r => r.OutsourceWorkOrderId == viewModel.RoleId).Name;
            if(oldRoleName != newRoleName)
            {
                _ = _userManager.RemoveFromRoleAsync(user, oldRoleName).Result;
                _ = _userManager.AddToRoleAsync(user, newRoleName).Result;
            }*/
        }
        public void Delete(int id, string currentUserName)
        {
            var user = _userDal.Get(u => u.Id == id);
            user.IsDeleted = true;
            user.UpdatedOn = DateTime.Now;
            user.UpdatedBy = currentUserName;
            _userDal.Update(user);
        }

        public List<User> GetTransporterNames()
        {
            return _employeeUserDal.GetTransporterNames();
        }
    }
}
