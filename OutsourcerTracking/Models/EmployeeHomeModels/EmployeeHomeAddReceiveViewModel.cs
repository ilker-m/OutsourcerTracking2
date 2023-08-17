

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace OutsourcerTracking.Models.EmployeeHomeModels
{
    public class EmployeeHomeAddReceiveViewModel
    {
        public int OutsourceWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string WorkOrderNo { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public decimal WillProduceTotalAmount { get; set; }
        public decimal TotalProducedAmount { get; set; }
        public decimal TotalReceivedAmount { get; set; }
        public decimal ReceivableAmount { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur..")]
        public int EmployeeUserId { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur..")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur..")]
        [Compare(nameof(Amount), ErrorMessage = "Adet Alanları Aynı Olmak Zorundadır.")]
        public decimal AmountAgain { get; set; }
    }
}
