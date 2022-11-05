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
    class ThongKeRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public ThongKeRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<ThongKeModel>> thongKeDoanhThuTheoThang(ThongKeModel thongKe)
        {
            var b = JsonConvert.SerializeObject(thongKe);
            var buffer = Encoding.UTF8.GetBytes(b);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("thongke", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var listTK = JsonConvert.DeserializeObject<List<ThongKeModel>>(json);
            return listTK;
        }
    }
}
