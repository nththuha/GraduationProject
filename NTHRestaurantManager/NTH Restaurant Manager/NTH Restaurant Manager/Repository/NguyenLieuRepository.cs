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
    class NguyenLieuRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public NguyenLieuRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<NguyenLieuModel>> layDSNguyenLieu()
        {
            _response = await _client.GetAsync("nguyenlieu");
            var json = await _response.Content.ReadAsStringAsync();
            var listLMA = JsonConvert.DeserializeObject<List<NguyenLieuModel>>(json);
            return listLMA;
        }

        public async Task<String> themNguyenLieu(NguyenLieuModel nguyenLieu)
        {
            var nguyenlieu = JsonConvert.SerializeObject(nguyenLieu);
            var buffer = Encoding.UTF8.GetBytes(nguyenlieu);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("nguyenlieu", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> suaNguyenLieu(NguyenLieuModel nguyenLieu)
        {
            var nguyenlieu = JsonConvert.SerializeObject(nguyenLieu);
            var buffer = Encoding.UTF8.GetBytes(nguyenlieu);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("nguyenlieu", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaNguyenLieu(String maNL)
        {
            _response = await _client.DeleteAsync("nguyenlieu/" + maNL);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
