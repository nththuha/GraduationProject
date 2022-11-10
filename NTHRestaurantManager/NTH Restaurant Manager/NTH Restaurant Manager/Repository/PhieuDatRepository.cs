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
    class PhieuDatRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public PhieuDatRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<PhieuDatModel>> layDSPhieuDat()
        {
            _response = await _client.GetAsync("phieudat");
            var json = await _response.Content.ReadAsStringAsync();
            var listPD = JsonConvert.DeserializeObject<List<PhieuDatModel>>(json);
            return listPD;
        }

        public async Task<List<PhieuDatModel>> layDSPhieuDatPhieuDatTruoc()
        {
            _response = await _client.GetAsync("phieudat/phieudattruoc");
            var json = await _response.Content.ReadAsStringAsync();
            var listPD = JsonConvert.DeserializeObject<List<PhieuDatModel>>(json);
            return listPD;
        }

        public async Task<String> themPhieuDatDuaTrenPhieuDatTruoc(PhieuDatTruocModel pdt)
        {
            var phieudattruoc = JsonConvert.SerializeObject(pdt);
            var buffer = Encoding.UTF8.GetBytes(phieudattruoc);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("phieudat/phieudattruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
