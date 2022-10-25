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
    class ThucDonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public ThucDonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<ThucDonModel>> layDSThucDon()
        {
            _response = await _client.GetAsync("thucdon");
            var json = await _response.Content.ReadAsStringAsync();
            var listTD = JsonConvert.DeserializeObject<List<ThucDonModel>>(json);
            return listTD;
        }

        public async Task<String> themThucDon(ThucDonModel thucDon)
        {
            var thucdon = JsonConvert.SerializeObject(thucDon);
            var buffer = Encoding.UTF8.GetBytes(thucdon);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("thucdon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaThucDon(int idTD)
        {
            _response = await _client.DeleteAsync("thucdon/" + idTD);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
