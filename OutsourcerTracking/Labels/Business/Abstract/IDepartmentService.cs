using OutsourcerTracking.Labels.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
    }
}
