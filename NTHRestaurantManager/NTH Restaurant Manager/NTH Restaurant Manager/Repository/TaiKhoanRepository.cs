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
    class TaiKhoanRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public TaiKhoanRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<TokenModel> dangNhap(TaiKhoanModel taiKhoan)
        {
            var taikhoan = JsonConvert.SerializeObject(taiKhoan);
            var buffer = Encoding.UTF8.GetBytes(taikhoan);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("taikhoan/dangnhap", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<TokenModel>(json);
            return token;
        }
    }
}
