using Newtonsoft.Json;
using OutsourceTrackingWorkerService.DataAccess.Repository;
using OutsourceTrackingWorkerService.Models;
using System.Net.Http.Json;
using System.Text;

namespace OutsourceTrackingWorkerService.Facade
{
    public class Facade : IFacade
    {
        private readonly WorkerModel _workerModel;
        private readonly HttpClient _client;
        public Facade(WorkerModel workerModel, HttpClient client)
        {
            _workerModel = workerModel;
            _client = client;
            string authorization = $"{_workerModel.UserName}:{_workerModel.Password}";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(authorization);
            _client.DefaultRequestHeaders.Add("Accept", "*/*");
            _client.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(bytes)}");
        }

        public async Task<HttpResponseMessage> ControlChangesAsync()
        {
            return await _client.GetAsync($"{_workerModel.BaseAddress}/IntegrationAPI/GetChangedTables");
        }

        public async Task<HttpResponseMessage> GetOutsourceChangesAsync()
        {
            return await _client.GetAsync($"{_workerModel.BaseAddress}/OutsourceAPI/GetChanged");
        }

        public async Task SendOutsourceIntegratedIds(List<int> ids)
        {
            var json = JsonConvert.SerializeObject(ids);
            HttpContent content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_workerModel.BaseAddress}/OutsourceAPI/EditIntegrationStatusEqual", content);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                
            }
        }
    }
}
