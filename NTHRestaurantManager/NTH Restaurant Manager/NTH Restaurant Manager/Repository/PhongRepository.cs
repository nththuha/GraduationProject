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
    class PhongRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public PhongRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<PhongModel>> layDSPhong()
        {
            _response = await _client.GetAsync("phong");
            var json = await _response.Content.ReadAsStringAsync();
            var listLMA = JsonConvert.DeserializeObject<List<PhongModel>>(json);
            return listLMA;
        }

        public async Task<String> themPhong(PhongModel phong)
        {
            var phongAfter = JsonConvert.SerializeObject(phong);
            var buffer = Encoding.UTF8.GetBytes(phongAfter);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("phong", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> suaPhong(PhongModel phong)
        {
            var phongAftar = JsonConvert.SerializeObject(phong);
            var buffer = Encoding.UTF8.GetBytes(phongAftar);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("phong", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaPhong(String maPhong)
        {
            _response = await _client.DeleteAsync("phong/" + maPhong);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
