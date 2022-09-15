using Firebase.Database;
using Newtonsoft.Json;
using NTH_Restaurant_Manager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Repository
{
    class HinhAnhRepository
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://nth-restaurant-default-rtdb.firebaseio.com/");
        FirebaseStorage firebaseStorage = new FirebaseStorage("gs://nth-restaurant.appspot.com");
        public async Task<bool> Save(HinhAnh hinhAnh)
        {
            var data = await firebaseClient.Child(nameof(HinhAnh)).PostAsync(JsonConvert.SerializeObject(hinhAnh));
            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Insert(HinhAnh hinhAnh)
        {
            await firebaseClient.Child(nameof(HinhAnh) + "/" + hinhAnh.imgURL).PostAsync(JsonConvert.SerializeObject(hinhAnh));
            return true;
        }

        public async Task<string> Upload(Stream img, string fileName)
        {
            return "";
        }
    }
}
