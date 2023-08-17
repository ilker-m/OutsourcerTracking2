namespace OutsourcerTracking.Models.OutsouceUserModels
{
    public class OutsourceUserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }
        public List<string> OutsourceNames { get; set; }
    }
}
