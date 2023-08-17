using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface ITitleService
    {
        void Add(Title title);
        List<Title> GetAll();
    }
}
