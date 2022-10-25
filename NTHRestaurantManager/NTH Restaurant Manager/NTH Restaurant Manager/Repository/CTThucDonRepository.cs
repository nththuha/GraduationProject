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
    class CTThucDonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTThucDonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTThucDonModel>> layDSCTThucDonTheoThucDon(int idTD)
        {
            _response = await _client.GetAsync("ctthucdon/" + idTD);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTTD = JsonConvert.DeserializeObject<List<CTThucDonModel>>(json);
            return listCTTD;
        }

        public async Task<String> themCTThucDon(CTThucDonModel ctTD)
        {
            var cttd = JsonConvert.SerializeObject(ctTD);
            var buffer = Encoding.UTF8.GetBytes(cttd);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctthucdon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaCTThucDon(int idCTTD)
        {
            _response = await _client.DeleteAsync("ctthucdon/" + idCTTD);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
