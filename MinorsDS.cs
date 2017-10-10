using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTE.Models;
using System.Net.Http;

namespace ISTE.Services
{
    class MinorsDS
    {
        public Minors GetItemDetails()
        {
            Minors minorItem = new Minors();
            List<UgMinor> minors = new List<UgMinor>();


            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri1 = $"https://ist.rit.edu/api/minors";

                    var response1 = client.GetAsync(uri1).Result;
                    var content1 = response1.Content.ReadAsStringAsync().Result;
                    dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content1);
                    minors = item1.UgMinors.ToObject<List<UgMinor>>();
                    
                    minorItem.UgMinors= minors;
                    
                    foreach (UgMinor ug in minors)
                    {
                        Console.WriteLine("MINORS \t" + ug.title);
                    }

                }
            }
            catch (System.Exception ex)
            {
                return minorItem;
            }
            return minorItem;
        }
    }
}
