namespace OutsourcerTracking.Models.APIModels
{
    public class AddEditWorkOrderModel
    {
        #region AlkWorkOrder
        public string ReferenceWorkOrderNo { get; set; }
        public string OrderGroup { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set;}
        #endregion

        #region Outsource
        public string CurrentCode { get; set; }
        public string WarehouseCode { get; set; }
        public int MachineNo { get; set; }
        public string MachineCode { get; set; }
        #endregion

        #region Operation
        public string OpNo { get; set; }
        public string OpCode { get; set; }
        #endregion

        #region OutsourceWorkOrder
        public string Description { get; set; }
        public int RawMaterialsWarehouseCode { get; set; }
        public int ProductWarehouseCode { get; set; }
        public string WorkOrderNo { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public decimal Amount { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime Deadline { get; set; }
        public string AlkUserName { get; set; }
        public string AlkNormalizedUserName { get; set; }
        #endregion
    }
}
