﻿namespace OutsourcerTracking.Models.OutsourceHomeModels
{
    public class OutsourceHomeViewModel
    {
        public int OutsourceWorkOrderId { get; set; }
        public int AlkWorkOrderId { get; set; }
        public string ReferenceWorkOrder { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public int OutsourceId { get; set; }
        public string OutsourceName { get; set; }
        public int SituationId { get; set; }
        public string SituationName { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string WorkOrderNo { get; set; }
        public decimal Amount { get; set; }
        public DateTime Deadline { get; set; }
        public decimal TotalProducedAmount { get; set; }
        public decimal TotalReceivedAmount { get; set; }
        public bool IsTrackingEditable { get; set; }
    }
}
