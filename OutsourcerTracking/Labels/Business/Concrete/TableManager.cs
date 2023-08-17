using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class TableManager : ITableService
    {
        private readonly ITableDal _tableDal;
        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }
        public List<Table> GetAll()
        {
            return _tableDal.GetList();
        }
        public bool CheckChanges()
        {
            return _tableDal.Get(t => t.Id == 1).IsChanged;
        }
    }
}
