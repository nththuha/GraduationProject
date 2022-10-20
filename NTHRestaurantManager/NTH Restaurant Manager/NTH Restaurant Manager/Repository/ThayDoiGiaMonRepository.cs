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
    class ThayDoiGiaMonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public ThayDoiGiaMonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<ThayDoiGiaMonModel>> layDSThayDoiGiaMonTheoMonAn(String maMA)
        {
            _response = await _client.GetAsync("thaydoigiamon/" + maMA);
            var json = await _response.Content.ReadAsStringAsync();
            var listTDGM = JsonConvert.DeserializeObject<List<ThayDoiGiaMonModel>>(json);
            return listTDGM;
        }

        public async Task<String> themThayDoiGiaMon(ThayDoiGiaMonModel thayDoiGiaMon)
        {
            var thaydoigiamon = JsonConvert.SerializeObject(thayDoiGiaMon);
            var buffer = Encoding.UTF8.GetBytes(thaydoigiamon);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("thaydoigiamon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaThayDoiGiaMon(int idTDGM)
        {
            _response = await _client.DeleteAsync("thaydoigiamon/" + idTDGM);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
