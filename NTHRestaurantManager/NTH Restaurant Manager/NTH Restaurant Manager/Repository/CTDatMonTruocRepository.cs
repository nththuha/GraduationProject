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
    class CTDatMonTruocRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTDatMonTruocRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTDatMonTruocModel>> layDSDatMonTheoPhieuDatTruoc(int idPDT)
        {
            var id = JsonConvert.SerializeObject(idPDT);
            var buffer = Encoding.UTF8.GetBytes(id);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctdatmontruoc/" + idPDT, byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTDMT = JsonConvert.DeserializeObject<List<CTDatMonTruocModel>>(json);
            return listCTDMT;
        }
    }
}
