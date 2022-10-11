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
    class BanRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public BanRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<BanModel>> layDSBan()
        {
            _response = await _client.GetAsync("ban");
            var json = await _response.Content.ReadAsStringAsync();
            var listLMA = JsonConvert.DeserializeObject<List<BanModel>>(json);
            return listLMA;
        }

        public async Task<String> themBan(BanModel ban)
        {
            var banAfter = JsonConvert.SerializeObject(ban);
            var buffer = Encoding.UTF8.GetBytes(banAfter);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ban", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> suaBan(BanModel ban)
        {
            var banAftar = JsonConvert.SerializeObject(ban);
            var buffer = Encoding.UTF8.GetBytes(banAftar);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("ban", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaBan(String maBan)
        {
            _response = await _client.DeleteAsync("ban/" + maBan);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
