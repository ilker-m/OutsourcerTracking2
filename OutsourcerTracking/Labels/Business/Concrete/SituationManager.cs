using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class SituationManager : ISituationService
    {
        private readonly ISituationDal _situationDal;
        public SituationManager(ISituationDal situationDal)
        {
            _situationDal = situationDal;
        }
        public List<Situation> GetAll()
        {
            return _situationDal.GetList(s => !s.IsDeleted);
        }

        public string GetNameById(int id)
        {
            return _situationDal.Get(s => s.Id == id).Name;
        }
    }
}
