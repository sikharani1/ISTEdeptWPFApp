using ISTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ISTE.Services
{
    class CoursesDS
    {
        public Degrees GetItemDetails()
        {
            Degrees degItem = new Degrees();
            List<Graduate> graddegrees = new List<Graduate>();
            List<Undergraduate> undergraddegrees = new List<Undergraduate>();
            
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri1 = $"https://ist.rit.edu/api/degrees";

                    var response1 = client.GetAsync(uri1).Result;
                    var content1 = response1.Content.ReadAsStringAsync().Result;
                    dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content1);
                    graddegrees = item1.graduate.ToObject<List<Graduate>>();
                    undergraddegrees = item1.undergraduate.ToObject<List<Undergraduate>>(); ;
                    degItem.graduate = graddegrees;
                    degItem.undergraduate = undergraddegrees;
                    foreach (Graduate grad in graddegrees)
                    {
                        Console.WriteLine("graddegrees \t" + grad.degreeName);
                    }

                }
            }
            catch (System.Exception ex)
            {
                return degItem;
            }
            return degItem;
        }
    }
}
