using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface ISituationService
    {
        List<Situation> GetAll();
        string GetNameById(int id);
    }
}
