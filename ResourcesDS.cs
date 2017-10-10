using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTE.Models;
using System.Net.Http;

namespace ISTE.Services
{
    class ResourcesDS
    {
        public Resources GetItemDetails()
        {
            Resources resItem = new Resources();
            List<Place> Studyabroadplaces = new List<Place>();
            StudyAbroad stdaitem = new StudyAbroad();


            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri1 = $"https://ist.rit.edu/api/resources";

                    var response1 = client.GetAsync(uri1).Result;
                    var content1 = response1.Content.ReadAsStringAsync().Result;
                    dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content1);
                    resItem.studentServices = item1.studentServices.ToObject<StudentServices>();
                    resItem.studyAbroad = item1.studyAbroad.ToObject<StudyAbroad>();
                    resItem.studentAmbassadors = item1.studentAmbassadors.ToObject<StudentAmbassadors>();

                    stdaitem = item1.studyAbroad.ToObject<StudyAbroad>(); 
                  //  resources=item1.s
                     Studyabroadplaces = stdaitem.places;

                //    resItem.studyAbroad.places = Studyabroadplaces;

                    foreach (Place p in Studyabroadplaces)
                    {
                        Console.WriteLine("MINORS \t" + p.nameOfPlace);
                    }

                }
            }
            catch (System.Exception ex)
            {
                return resItem;
            }
            return resItem;
        }
    }
}
