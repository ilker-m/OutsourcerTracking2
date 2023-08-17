using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IOutsourceService
    {
        List<Outsource> GetAll();
        List<Outsource> GetAllByOutsourceUserId(int id);
        Outsource GetById(int id);
        string GetNameById(int id);
        int Add(Outsource outsource, string currentUser);
        void Edit(Outsource outsource, string currentUser);
        void Delete(int id, string currentUser);
        Outsource GetByCurrentCode(string currentCode);
        void AddWithUser(AddEditOutsourceTrackingModel addEditOutsourceTrackingModel, string currentUser);
        void EditWithUser(Outsource outsource, AddEditOutsourceTrackingModel addEditOutsourceTrackingModel, string userName);
    }
}
