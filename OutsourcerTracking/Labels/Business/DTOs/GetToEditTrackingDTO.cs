namespace OutsourcerTracking.Labels.Business.DTOs
{
    public class GetToEditTrackingDTO
    {
        public int Id { get; set; }
        public int OutsourceWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string WorkOrder { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public decimal WillPoduceTotalAmount { get; set; }
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
        public decimal AmountAgain { get; set; }
        public decimal Weight_Kg { get; set; }
        public decimal Weight_KgAgain { get; set; }


    }
}
