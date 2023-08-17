using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.EmployeeUserModels
{
    public class EmployeeUserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }
        public string DepartmentName { get; set; }
        public string TitleName { get; set; }
    }
}
