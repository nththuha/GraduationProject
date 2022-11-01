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
    class PhieuMuaNguyenLieuRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public PhieuMuaNguyenLieuRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<NguyenLieuModel>> layDSNguyenLieuCanMuaTheoNgay(PhongNgay phongNgay)
        {
            var pn = JsonConvert.SerializeObject(phongNgay);
            var buffer = Encoding.UTF8.GetBytes(pn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("phieumuanguyenlieu", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var listNL = JsonConvert.DeserializeObject<List<NguyenLieuModel>>(json);
            return listNL;
        }
    }
}
