using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.OutsourceHomeModels
{
    public class OutsourceHomeAddTrackingViewModel
    {
        public int OutsourceWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string WorkOrderNo { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public decimal WillPoduceTotalAmount { get; set; }
        public decimal TotalProducedAmount { get; set; }
        public decimal WillProduceAmount { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [Compare(nameof(Amount), ErrorMessage = "Miktar Alanları Aynı Olmak Zorundadır.")]
        public decimal AmountAgain { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public decimal Weight_Kg { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [Compare(nameof(Weight_KgAgain), ErrorMessage = "Ağırlık Alanları Aynı Olmak Zorundadır.")]
        public decimal Weight_KgAgain { get; set; }

    }
}
