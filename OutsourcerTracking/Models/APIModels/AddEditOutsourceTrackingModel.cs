using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.APIModels
{
    public class AddEditOutsourceTrackingModel
    {
        #region UserAndOutsourceUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPhone { get; set; }
        #endregion

        #region Outsource
        public string CurrentCode { get; set; }
        public string WarehouseCode { get; set; }
        public int MachineNo { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public string OutsourcePhone { get; set; }
        public string Address { get; set; }
        #endregion

        #region Common
        public string Email { get; set; }
        #endregion
    }
}
