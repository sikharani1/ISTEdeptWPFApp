using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ISTE.Models;

namespace ISTE.Services
{
    public class MapDS
    {
        public Map GetItemDetails()
        {
            Map mapitem=new Map();
         try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri4 = $"http://ist.rit.edu/api/map/";

     //   var response1 = client.GetAsync(uri4).Result;
    //    var content2 = response1.Content.ReadAsStringAsync().Result;
                    // dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content1);
                    mapitem.map = uri4;

    }
}
            catch (System.Exception ex)
            {
                return mapitem;
            }
            return mapitem;
        }
    }
}

   
