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
    class TienCocRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public TienCocRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<TienCocModel>> layDSTienCocTheoPDT(int idPDT)
        {
            _response = await _client.GetAsync("tiencoc/" + idPDT);
            var json = await _response.Content.ReadAsStringAsync();
            var listTC = JsonConvert.DeserializeObject<List<TienCocModel>>(json);
            return listTC;
        }

        public async Task<String> themTienCoc(TienCocModel tienCoc)
        {
            var tc = JsonConvert.SerializeObject(tienCoc);
            var buffer = Encoding.UTF8.GetBytes(tc);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("tiencoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaTienCoc(int idTC)
        {
            _response = await _client.DeleteAsync("tiencoc/" + idTC);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
