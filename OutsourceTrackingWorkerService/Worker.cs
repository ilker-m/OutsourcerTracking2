using OutsourceTrackingWorkerService.Facade;
using OutsourceTrackingWorkerService.Models;
using OutsourceTrackingWorkerService.Models.ModelEnums;
using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace OutsourceTrackingWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly WorkerModel _workerModel;
        private readonly HttpClient _client;
        private readonly IFacade _facade;
        public Worker(ILogger<Worker> logger, WorkerModel workerModel, HttpClient httpClient, IFacade facade)
        {
            _logger = logger;
            _workerModel = workerModel;
            _client = httpClient;
            _facade = facade;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var response = await _facade.ControlChangesAsync();
                if(response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    _logger.LogInformation("{time} | Kullanýcý adý veya þifre doðru deðil.", DateTimeOffset.Now);
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    _logger.LogInformation("{time} | Entegrasyon baþlatýlýyor.", DateTimeOffset.Now);
                    await Entegrate(response);
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    _logger.LogInformation("{time} | Entegre edilecek deðiþiklik yok.", DateTimeOffset.Now);
                }
                await Task.Delay(1000 * _workerModel.PeriodSeconds, stoppingToken);
            }
        }
        private async Task Entegrate(HttpResponseMessage response)
        {
            
        }
        private async Task EntegrateOutsourcesTable()
        {
            var response = await _facade.GetOutsourceChangesAsync();
            //var outsources = await response.Content.ReadAsStringAsync();
            //var outsources = await response.Content.ReadFromJsonAsync<List<OutsourceModel>>();
            var ids = new List<int>();
            /*foreach (var outsource in outsources)
            {
                switch(outsource.IntegrationStatusId)
                {
                    case (int)IntegrationStatusEnum.Equal:
                        break;
                    case (int)IntegrationStatusEnum.Add:
                        _logger.LogInformation("{time} | Outsources tablosuna ekleniyor.", DateTimeOffset.Now);
                        try
                        {
                            //await _facade.AddOutsourceAsnc(outsource);
                            ids.Add(outsource.Id);
                        }
                        catch (Exception ex)
                        {

                        }
                        break;
                    case (int)IntegrationStatusEnum.Edit:
                        break;
                    case (int)IntegrationStatusEnum.Delete:
                        break;
                    default:
                        break;
                }
            }*/
            await _facade.SendOutsourceIntegratedIds(ids);
        }
    }
}