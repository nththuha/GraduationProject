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
    class PhieuDatTruocRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public PhieuDatTruocRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<PhieuDatTruocModel>> layDSPhieuDatTruoc()
        {
            _response = await _client.GetAsync("phieudattruoc");
            var json = await _response.Content.ReadAsStringAsync();
            var listPDT = JsonConvert.DeserializeObject<List<PhieuDatTruocModel>>(json);
            return listPDT;
        }

        public async Task<List<PhieuDatTruocModel>> layDSPhieuDatTruocTheoNgay(PhongNgay phongNgay)
        {
            var pn = JsonConvert.SerializeObject(phongNgay);
            var buffer = Encoding.UTF8.GetBytes(pn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("phieudattruoc/ngay", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var listPDT = JsonConvert.DeserializeObject<List<PhieuDatTruocModel>>(json);
            return listPDT;
        }

        public async Task<PhieuDatTruocModel> themPhieuDatTruoc(PhieuDatTruocModel phieuDatTruoc)
        {
            var pdt = JsonConvert.SerializeObject(phieuDatTruoc);
            var buffer = Encoding.UTF8.GetBytes(pdt);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("phieudattruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<PhieuDatTruocModel>(json);
            return check;
        }

        public async Task<String> suaPhieuDatTruoc(PhieuDatTruocModel phieuDatTruoc)
        {
            var pdt = JsonConvert.SerializeObject(phieuDatTruoc);
            var buffer = Encoding.UTF8.GetBytes(pdt);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("phieudattruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaPhieuDatTruoc(int idPDT)
        {
            _response = await _client.DeleteAsync("phieudattruoc/" + idPDT);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
