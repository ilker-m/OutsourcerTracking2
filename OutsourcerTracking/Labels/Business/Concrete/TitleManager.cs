using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Labels.DataAccess.Abstract;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class TitleManager : ITitleService
    {
        private ITitleDal _dal;
        public TitleManager(ITitleDal dal)
        {
            _dal = dal;
        }
        public void Add(Title title)
        {
            _dal.Add(title);
        }
        public List<Title> GetAll()
        {
            return _dal.GetList();
        }
    }
}
