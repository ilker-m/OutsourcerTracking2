using OutsourcerTracking.Labels.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.OutsourceHomeModels
{
    public class OutsourceHomeEditTrackingViewModel
    {
        public int Id { get; set; }
        public int OutsourceWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string WorkOrder { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public decimal WillPoduceTotalAmount { get; set; }
        public decimal TotalProducedAmount { get; set; }
        public decimal WillProduceAmount { get; set; }
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [Compare(nameof(Amount), ErrorMessage = "Adet Alanları Aynı Olmak Zorundadır.")]
        public decimal AmountAgain { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public decimal Weight_Kg { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [Compare(nameof(Weight_KgAgain), ErrorMessage = "Ağırlık Alanları Aynı Olmak Zorundadır.")]
        public decimal Weight_KgAgain { get; set; }
    }
}
