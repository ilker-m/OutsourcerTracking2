using OutsourcerTracking.Labels.Core.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class EmployeeUser : IEntity
    { 
        public int Id { get; set; }
        public User User { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public ICollection<Receive> Receives { get; set; }
    }
}
