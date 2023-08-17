namespace OutsourcerTracking.Models
{
    public class WorkOrderEmailModel
    {
        public string AlkNormalizedUserName { get; set; }
        public string StockCode { get; set; }
        public decimal Amount { get; set; }
        public string MachineName { get; set; }
        public string WorkOrderNo { get; set; }
    }
}
