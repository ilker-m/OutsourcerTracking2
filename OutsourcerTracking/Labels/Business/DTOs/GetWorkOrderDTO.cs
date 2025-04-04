﻿using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.Business.DTOs
{
    public class GetWorkOrderDTO
    {
        #region AlkWorkOrder
        public string ReferenceWorkOrderNo { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string OrderGroup { get; set; }
        #endregion

        #region Outsource
        public int MachineNo { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        #endregion

        #region OutsourceWorkOrder
        public int Id { get; set; }
        public string WorkOrderNo { get; set; }
        public decimal Amount { get; set; }
        public string AlkUserName { get; set; }
        public string AlkNormalizedUserName { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public DateTime Deadline { get; set; }
        #endregion
    }
}
