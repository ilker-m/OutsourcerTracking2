namespace OutsourcerTracking.Labels.Business.DTOs
{
    public class GetToEditReceiveDTO
    {
        public int Id { get; set; }
        public int OutsourceWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string WorkOrder { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public int EmployeeUserId { get; set; }
        public decimal WillProduceTotalAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountAgain { get; set; }
        public DateTime Date { get; set; }
    }
}
