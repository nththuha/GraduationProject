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
    class MonAnRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public MonAnRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<MonAnModel>> layDSMonAn()
        {
            _response = await _client.GetAsync("monan");
            var json = await _response.Content.ReadAsStringAsync();
            var listMA = JsonConvert.DeserializeObject<List<MonAnModel>>(json);
            return listMA;
        }

        public async Task<String> themMonAn(MonAnModel monAnModel)
        {
            var monAn = JsonConvert.SerializeObject(monAnModel);
            var buffer = Encoding.UTF8.GetBytes(monAn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("monan", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> suaMonAn(MonAnModel monAnModel)
        {
            var monAn = JsonConvert.SerializeObject(monAnModel);
            var buffer = Encoding.UTF8.GetBytes(monAn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("monan", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaMonAn(String maMA)
        {
            _response = await _client.DeleteAsync("monan/" + maMA);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
