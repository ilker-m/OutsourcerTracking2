using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.APIModels;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public sealed class EmailManager : IEmailService
    {
        private readonly IOutsourceWorkOrderService _outsourceWorkOrderService;
        public EmailManager()
        {

        }
        public EmailManager(IOutsourceWorkOrderService outsourceWorkOrderService)
        {
            _outsourceWorkOrderService = outsourceWorkOrderService;
        }
        public void SendEmailToEmployeesAboutAddedProduct(int outsourceWorkOrderId)
        {
            var htmlText = GetHtmlTextWithData(outsourceWorkOrderId).Replace("{{operation}}", "Ekleme").Replace("{{color}}", "green");
            SendEmails(htmlText, "Yeni Üretim Eklendi");
        }
        public void SendEmailToEmployeesAboutEditedProduct(int outsourceWorkOrderId)
        {
            var htmlText = GetHtmlTextWithData(outsourceWorkOrderId).Replace("{{operation}}", "Düzeltme").Replace("{{color}}", "blue");
            SendEmails(htmlText, "Üretim Düzeltildi");
        }
        public void SendEmailToEmployeesAboutDeletedProduct(int outsourceWorkOrderId)
        {
            var htmlText = GetHtmlTextWithData(outsourceWorkOrderId).Replace("{{operation}}", "Silme").Replace("{{color}}", "red");
            SendEmails(htmlText, "Üretim Silindi");
        }
        public void SendEmailForNewPasswordLink(string mail,string KeyCode)
        {
      


            SendEmails(KeyCode, "Onay Kodu",mail);


        }
        private string GetHtmlTextWithData(int outsourceWorkOrderId)
        {
            var data = _outsourceWorkOrderService.GetForEmployeeTableById(outsourceWorkOrderId);
            decimal willProduceQuantity = data.Amount - data.TotalProducedAmount;
            decimal willReceiveQuantity = data.Amount - data.TotalReceivedAmount;
            decimal receivableQuantity = data.TotalProducedAmount - data.TotalReceivedAmount;
            var htmlText = new StringBuilder(File.ReadAllText(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\MailIndex.html"))
                .Replace("{{outsourceName}}", data.OutsourceName)
                .Replace("{{referenceWorkOrder}}", data.ReferenceWorkOrder)
                .Replace("{{workOrder}}", data.WorkOrderNo)
                .Replace("{{quantity}}", data.Amount.ToString())
                .Replace("{{orderGroup}}", data.OrderGroup)
                .Replace("{{stockCode}}", data.StockCode)
                .Replace("{{situationName}}", data.SituationName)
                .Replace("{{totalProducedQuantity}}", data.TotalProducedAmount.ToString())
                .Replace("{{willProduceQuantity}}", willProduceQuantity.ToString())
                .Replace("{{totalReceivedQuantrity}}", data.TotalReceivedAmount.ToString())
                .Replace("{{willReceiveQuantity}}", willReceiveQuantity.ToString())
                .Replace("{{receivableQuantity}}", receivableQuantity.ToString());
            return htmlText.ToString();
        }

        public void SendEmailToEmployeesAboutAddedWorkOrder(WorkOrderEmailModel workOrderEmailModel)
        {
            var htmlText = $"<div>Merhaba</div><br /><div>{workOrderEmailModel.AlkNormalizedUserName} {workOrderEmailModel.StockCode} stock kodundan {workOrderEmailModel.Amount} miktar üretilmesi için {workOrderEmailModel.MachineName} fasoncusuna {workOrderEmailModel.WorkOrderNo} iş emrini atanmıştır.</div>";
            SendEmails(htmlText, $"{workOrderEmailModel.WorkOrderNo} İş Emrini Fasoncuya Atama");
        }

        public void SendEmailToEmployeesAboutEditedWorkOrder(WorkOrderEmailModel workOrderEmailModel)
        {
            var htmlText = $"<div>Merhaba,</div><br /><div>{workOrderEmailModel.AlkNormalizedUserName} {workOrderEmailModel.StockCode} stock kodundan {workOrderEmailModel.Amount} miktar üretilmesi için {workOrderEmailModel.MachineName} fasoncusuna {workOrderEmailModel.WorkOrderNo} iş emrini güncellemiştir.</div>";
            SendEmails(htmlText, $"{workOrderEmailModel.WorkOrderNo} İş Emrini Güncelleme");
        }

        public void SendEmailToOutsourceAboutPassword(string email, string password)
        {
            var htmlText = $"<div>Merhaba, <div>fason.alkbusiness.com adresinden {email} mail adresi ve {password} şifresi ile giriş yapabilirsiniz. </div><br /><div>";
            SendEmails(htmlText, "Fason Uygulaması Giriş Bilgileri", email);
        }
        private void SendEmails(string body, string subject, string? differentEmail = null)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).AddJsonFile("appsettings.json").Build();
            string workMode = builder.GetValue<string>("WorkMode");
            var smtpClient = new SmtpClient()
            {
                Host = builder.GetValue<string>($"{workMode}:Smtp:Host"),
                Port = builder.GetValue<int>($"{workMode}:Smtp:Port"),
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(builder.GetValue<string>($"{workMode}:Smtp:Username"), builder.GetValue<string>($"{workMode}:Smtp:Password")),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = false,
            };
            List<string> emailsTo = differentEmail == null ? builder.GetValue<string>($"{workMode}:Email:To").Split(";").ToList() : new List<string> { differentEmail };
            foreach (var emailTo in emailsTo)
            {
                using (var email = new MailMessage(builder.GetValue<string>($"{workMode}:Email:From"), emailTo))
                {
                    email.IsBodyHtml = true;
                    email.Subject = subject;
                    email.Body = body;
                    smtpClient.Send(email);
                }
            }
        }
    }
}
