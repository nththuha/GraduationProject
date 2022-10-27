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
    class CTDatBanTruocRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTDatBanTruocRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTDatBanTruocModel>> layDSCTDatBanTruocTheoPDT(int idPDT)
        {
            _response = await _client.GetAsync("ctdatbantruoc/" + idPDT);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTDBT = JsonConvert.DeserializeObject<List<CTDatBanTruocModel>>(json);
            return listCTDBT;
        }

        public async Task<String> themCTBan(CTDatBanTruocModel cTDatBanTruoc)
        {
            var ctdbt = JsonConvert.SerializeObject(cTDatBanTruoc);
            var buffer = Encoding.UTF8.GetBytes(ctdbt);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("ctdatbantruoc", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }

        public async Task<String> xoaCTBan(int idCTDBT)
        {
            _response = await _client.DeleteAsync("ctdatbantruoc/" + idCTDBT);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
