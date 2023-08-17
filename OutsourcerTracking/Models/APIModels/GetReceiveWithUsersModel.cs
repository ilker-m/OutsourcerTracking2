using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.DataAccess.Entities;
using System.ComponentModel;

namespace OutsourcerTracking.Models.APIModels
{
    public class GetReceiveWithUsersModel
    {
        public int Id { get; set; }
        public int OutsourceWorkOrderId { get; set; }
        public int EmployeeUserId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastname { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool IsSealed { get; set; }
        public DateTime? ApprovedDate { get; set; }
        
    }
}
