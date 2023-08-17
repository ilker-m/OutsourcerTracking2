using OutsourcerTracking.Models;
using OutsourcerTracking.Models.APIModels;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IEmailService
    {
        void SendEmailToEmployeesAboutAddedProduct(int outsourceWorkOrderId);
        void SendEmailToEmployeesAboutEditedProduct(int outsourceWorkOrderId);
        void SendEmailToEmployeesAboutDeletedProduct(int outsourceWorkOrderId);
        void SendEmailToEmployeesAboutAddedWorkOrder(WorkOrderEmailModel addEditWorkOrderModel);
        void SendEmailToEmployeesAboutEditedWorkOrder(WorkOrderEmailModel addEditWorkOrderModel);
        void SendEmailToOutsourceAboutPassword(string email, string password);

        void SendEmailForNewPasswordLink(string mail, string KeyCode);
    }

}
