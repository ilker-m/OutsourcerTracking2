using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.Business.DTOs
{
    public class GetToAddReceiveDTO
    {
        public int OutsourceWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string WorkOrder { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public decimal WillProduceTotalAmount { get; set; }
    }
}
