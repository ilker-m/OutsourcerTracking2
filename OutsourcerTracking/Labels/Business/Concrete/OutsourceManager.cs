using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.Business.Concrete;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Labels.DataAccess.Enums;
using OutsourcerTracking.Models.APIModels;
using OutsourcerTracking.Models.EmployeeUserModels;
using OutsourcerTracking.Models.OutsouceUserModels;

namespace Business.Concrete
{
    public class OutsourceManager : IOutsourceService
    {
        private readonly IOutsourceDal _outsourceDal;
        private readonly IOutsourceUserService _outsourceUserService;
        private readonly IUserService _userService;
        public OutsourceManager(IOutsourceDal outsourceDal, IOutsourceUserService outsourceUserService, IUserService userService)
        {
            _outsourceDal = outsourceDal;
            _outsourceUserService = outsourceUserService;
            _userService = userService;
        }
        public List<Outsource> GetAll()
        {
            return _outsourceDal.GetList(o => !o.IsDeleted);
        }

        public List<Outsource> GetAllByOutsourceUserId(int id)
        {
            return _outsourceDal.GetAllByOutsourceUserId(id);
        }

        public string GetNameById(int id)
        {
            return _outsourceDal.Get(o => o.Id == id).MachineName;
        }

        public Outsource GetById(int id)
        {
            return _outsourceDal.Get(o => o.Id == id);
        }
        public int Add(Outsource outsource, string currentUser)
        {
            outsource.CreatedBy = currentUser;
            outsource.CreatedOn = DateTime.Now;
            _outsourceDal.Add(outsource);
            return _outsourceDal.GetLastId();
        }
        public void Edit(Outsource outsource, string currentUser)
        {
            var oldOutsource = _outsourceDal.Get(o => o.Id == outsource.Id);
            outsource.CreatedBy = oldOutsource.CreatedBy;
            outsource.CreatedOn = oldOutsource.CreatedOn;
            outsource.UpdatedBy = currentUser;
            outsource.UpdatedOn = DateTime.Now;
            _outsourceDal.Update(outsource);
        }
        public void Delete(int id, string currentUser)
        {
            var outsource = _outsourceDal.Get(o => o.Id == id);
            outsource.UpdatedBy = currentUser;
            outsource.UpdatedOn = DateTime.Now;
            outsource.IsDeleted = true;
            _outsourceDal.Update(outsource);
        }

        public Outsource GetByCurrentCode(string currentCode)
        {
            return _outsourceDal.Get(o => o.CurrentCode == currentCode.Trim() && !o.IsDeleted);
        }

        public void AddWithUser(AddEditOutsourceTrackingModel addEditOutsourceTrackingModel, string currentUser)
        {
            _outsourceDal.Add(new Outsource
            {
                CurrentCode = addEditOutsourceTrackingModel.CurrentCode,
                WarehouseCode = addEditOutsourceTrackingModel.WarehouseCode,
                MachineNo = addEditOutsourceTrackingModel.MachineNo,
                MachineCode = addEditOutsourceTrackingModel.MachineCode,
                MachineName =   addEditOutsourceTrackingModel.MachineName,
                Phone = addEditOutsourceTrackingModel.OutsourcePhone,
                Email = addEditOutsourceTrackingModel.Email,
                Address = addEditOutsourceTrackingModel.Address,
                CreatedBy = currentUser,
                CreatedOn = DateTime.Now,
                IsDeleted = false
            });
            var lastOutsourceId = _outsourceDal.GetLastId();
            var user = _userService.GetByEmail(addEditOutsourceTrackingModel.Email);
            if(user == null)
            {
                var password = Guid.NewGuid().ToString().Substring(0, 6);
                _outsourceUserService.AddRelational(new OutsourceUserCreateViewModel
                {
                    FirstName = addEditOutsourceTrackingModel.FirstName,
                    LastName = addEditOutsourceTrackingModel.LastName,
                    Email = addEditOutsourceTrackingModel.Email,
                    Phone = addEditOutsourceTrackingModel.UserPhone,
                    RoleId = (int)RoleEnum.OutsourceUser,
                    OutsourceIds = new List<int> { lastOutsourceId },
                    Password = password,
                    PasswordConfirm = password
                }, currentUser);
                new EmailManager().SendEmailToOutsourceAboutPassword(addEditOutsourceTrackingModel.Email, password);
            }
            else
            {
                _outsourceUserService.EditRelational(new OutsourceUserEditViewModel
                {
                    Id = user.Id,
                    FirstName = addEditOutsourceTrackingModel.FirstName,
                    LastName = addEditOutsourceTrackingModel.LastName,
                    Email = addEditOutsourceTrackingModel.Email,
                    Phone = addEditOutsourceTrackingModel.UserPhone,
                    RoleId = (int)RoleEnum.OutsourceUser,
                    OutsourceIds = new List<int> { lastOutsourceId },
                }, currentUser);
            }
        }

        public void EditWithUser(Outsource outsource, AddEditOutsourceTrackingModel addEditOutsourceTrackingModel, string currentUser)
        {
            outsource.CurrentCode = addEditOutsourceTrackingModel.CurrentCode;
            outsource.WarehouseCode = addEditOutsourceTrackingModel.WarehouseCode;
            outsource.MachineNo = addEditOutsourceTrackingModel.MachineNo;
            outsource.MachineCode = addEditOutsourceTrackingModel.MachineCode;
            outsource.MachineName = addEditOutsourceTrackingModel.MachineName;
            outsource.Phone = addEditOutsourceTrackingModel.OutsourcePhone;
            outsource.Email = addEditOutsourceTrackingModel.Email;
            outsource.Address = addEditOutsourceTrackingModel.Address;
            outsource.UpdatedBy = currentUser;
            outsource.UpdatedOn = DateTime.Now;
            _outsourceDal.Update(outsource);
            var user = _userService.GetByEmail(addEditOutsourceTrackingModel.Email);
            if (user == null)
            {
                var password = Guid.NewGuid().ToString().Substring(0, 6);
                _outsourceUserService.AddRelational(new OutsourceUserCreateViewModel
                {
                    FirstName = addEditOutsourceTrackingModel.FirstName,
                    LastName = addEditOutsourceTrackingModel.LastName,
                    Email = addEditOutsourceTrackingModel.Email,
                    Phone = addEditOutsourceTrackingModel.UserPhone,
                    RoleId = (int)RoleEnum.OutsourceUser,
                    OutsourceIds = new List<int> { outsource.Id },
                    Password = password,
                    PasswordConfirm = password
                }, currentUser);
                new EmailManager().SendEmailToOutsourceAboutPassword(addEditOutsourceTrackingModel.Email, password);
            }
            else
            {
                _outsourceUserService.EditRelational(new OutsourceUserEditViewModel
                {
                    Id = user.Id,
                    FirstName = addEditOutsourceTrackingModel.FirstName,
                    LastName = addEditOutsourceTrackingModel.LastName,
                    Email = addEditOutsourceTrackingModel.Email,
                    Phone = addEditOutsourceTrackingModel.UserPhone,
                    RoleId = (int)RoleEnum.OutsourceUser,
                    OutsourceIds = new List<int> { outsource.Id },
                }, currentUser);
            }
        }
    }
}
