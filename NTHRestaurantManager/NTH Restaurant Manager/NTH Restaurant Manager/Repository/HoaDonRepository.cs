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
    class HoaDonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public HoaDonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<HoaDonPDModel> themHoaDon(HoaDonModel hoaDon)
        {
            var hd = JsonConvert.SerializeObject(hoaDon);
            var buffer = Encoding.UTF8.GetBytes(hd);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("hoadon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var hoadonPD = JsonConvert.DeserializeObject<HoaDonPDModel>(json);
            return hoadonPD;
        }

        public async Task<HoaDonPDTModel> themHoaDonPDT(HoaDonModel hoaDon)
        {
            var hd = JsonConvert.SerializeObject(hoaDon);
            var buffer = Encoding.UTF8.GetBytes(hd);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("hoadon/phieudattruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var hoadonPDT = JsonConvert.DeserializeObject<HoaDonPDTModel>(json);
            return hoadonPDT;
        }
    }
}
