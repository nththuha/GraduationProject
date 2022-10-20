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
    class KhachHangRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public KhachHangRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<KhachHangModel>> layDSKhachHang()
        {
            _response = await _client.GetAsync("khachhang");
            var json = await _response.Content.ReadAsStringAsync();
            var listKH = JsonConvert.DeserializeObject<List<KhachHangModel>>(json);
            return listKH;
        }

        public async Task<String> themKhachHang(KhachHangModel khachHang)
        {
            var khachhang = JsonConvert.SerializeObject(khachHang);
            var buffer = Encoding.UTF8.GetBytes(khachhang);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("khachhang", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> suaKhachHang(KhachHangModel khachHang)
        {
            var khachhang = JsonConvert.SerializeObject(khachHang);
            var buffer = Encoding.UTF8.GetBytes(khachhang);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("khachhang", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaKhachHang(int idKH)
        {
            _response = await _client.DeleteAsync("khachhang/" + idKH);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
