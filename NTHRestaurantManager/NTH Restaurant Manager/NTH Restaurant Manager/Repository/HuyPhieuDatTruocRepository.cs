using Newtonsoft.Json;
using NTH_Restaurant_Manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Repository
{
    class HuyPhieuDatTruocRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public HuyPhieuDatTruocRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<String> themHuyPhieuDatTruoc(HuyPhieuDatTruocModel hpdt)
        {
            var huy = JsonConvert.SerializeObject(hpdt);
            var buffer = Encoding.UTF8.GetBytes(huy);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("huyphieudattruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
