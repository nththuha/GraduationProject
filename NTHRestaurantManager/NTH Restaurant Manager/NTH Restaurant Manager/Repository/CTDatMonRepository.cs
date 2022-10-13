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
    class CTDatMonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTDatMonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTDatMonModel>> layDSCTDatMonTheoPhieuDat(int idPD)
        {
            _response = await _client.GetAsync("ctdatmon/" + idPD);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTDM = JsonConvert.DeserializeObject<List<CTDatMonModel>>(json);
            return listCTDM;
        }
    }
}
