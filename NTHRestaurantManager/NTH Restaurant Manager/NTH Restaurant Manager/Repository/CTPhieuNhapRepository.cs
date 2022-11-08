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
    class CTPhieuNhapRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTPhieuNhapRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTPhieuNhapModel>> layDSCTPhieuNhapTheoPhieuNhap(int idPN)
        {
            _response = await _client.GetAsync("ctphieunhap/" + idPN);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTPN = JsonConvert.DeserializeObject<List<CTPhieuNhapModel>>(json);
            return listCTPN;
        }

        public async Task<String> themCTPhieuNhap(CTPhieuNhapModel ctPN)
        {
            var ctpn = JsonConvert.SerializeObject(ctPN);
            var buffer = Encoding.UTF8.GetBytes(ctpn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctphieunhap", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaCTPhieuNhap(int idCTPN)
        {
            _response = await _client.DeleteAsync("ctphieunhap/" + idCTPN);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
