﻿using Newtonsoft.Json;
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
    class CTBanRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTBanRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTBanModel>> layDSCTBanTheoPhong(String maPhong)
        {
            _response = await _client.GetAsync("ctban/danhsach/" + maPhong);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTB = JsonConvert.DeserializeObject<List<CTBanModel>>(json);
            return listCTB;
        }

        public async Task<List<BanModel>> layDSBanTheoPhongTheoNgay(PhongNgay phongNgay)
        {
            var phongngay = JsonConvert.SerializeObject(phongNgay);
            var buffer = Encoding.UTF8.GetBytes(phongngay);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctban/dattruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var listB = JsonConvert.DeserializeObject<List<BanModel>>(json);
            return listB;
        }

        public async Task<String> themCTBan(CTBanModel ctBan)
        {
            var ctban = JsonConvert.SerializeObject(ctBan);
            var buffer = Encoding.UTF8.GetBytes(ctban);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctban", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaCTBan(int idCTB)
        {
            _response = await _client.DeleteAsync("ctban/" + idCTB);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
