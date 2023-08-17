using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User? GetByEmail(string email)
        {
            return _userDal.Get(u => u.Email == email && !u.IsDeleted);
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id && !u.IsDeleted);
        }
    }
}
