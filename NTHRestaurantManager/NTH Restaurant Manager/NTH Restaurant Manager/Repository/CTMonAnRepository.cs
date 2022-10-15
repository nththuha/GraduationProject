using Newtonsoft.Json;
using NTH_Restaurant_Manager.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Repository
{
    class CTMonAnRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTMonAnRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTMonAnModel>> layDSCTMonAnTheoMonAn(String maMA)
        {
            _response = await _client.GetAsync("ctmonan/" + maMA);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTMA = JsonConvert.DeserializeObject<List<CTMonAnModel>>(json);
            return listCTMA;
        }

        public async Task<String> themCTMonAn(CTMonAnModel ctMonAn)
        {
            var ctmonan = JsonConvert.SerializeObject(ctMonAn);
            var buffer = Encoding.UTF8.GetBytes(ctmonan);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctmonan", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaCTMonAn(int idCTMA)
        {
            _response = await _client.DeleteAsync("ctmonan/" + idCTMA);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
