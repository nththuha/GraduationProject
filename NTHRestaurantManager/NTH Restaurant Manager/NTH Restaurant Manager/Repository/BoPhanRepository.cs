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
    class BoPhanRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public BoPhanRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<BoPhanModel>> layDSBoPhan()
        {
            _response = await _client.GetAsync("bophan");
            var json = await _response.Content.ReadAsStringAsync();
            var listBP = JsonConvert.DeserializeObject<List<BoPhanModel>>(json);
            return listBP;
        }
    }
}
