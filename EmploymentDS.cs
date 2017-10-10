using ISTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ISTE.Services
{
    public class EmploymentDS
    {
        public Employment GetItemDetails()
        {
            Employment empItem = new Employment();
            CoopTable coopt = new CoopTable();
            
            List<CoopInformation> coopinformation = new List<CoopInformation>();

            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri1 = $"https://ist.rit.edu/api/employment";

                    var response1 = client.GetAsync(uri1).Result;
                    var content1 = response1.Content.ReadAsStringAsync().Result;
                    dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content1);
                    empItem.coopTable= item1.coopTable.ToObject<CoopTable>();
                    coopinformation = item1.coopTable.coopInformation.ToObject<List<CoopInformation>>();
                    empItem.coopTable.coopInformation = coopinformation;
                 //   degItem.coopTable = item1.coopTable;

                    // var retItem1 = item1.undergraduate;
                    //    graddegrees = item1.graduate;
                    //  undergraddegrees = item1.undergraduate;
                    coopt.coopInformation = coopinformation;

                   
               /*     foreach(CoopInformation c in coopinformation)
                 {
                     Console.WriteLine("graddegrees \t" + c.employer);
                          Console.WriteLine("graddegrees \t" + c.degree);
                      Console.WriteLine("graddegrees \t" + c.city);
                       Console.WriteLine("graddegrees \t" + c.term);
                  }*/

                }
            }
            catch (System.Exception ex)
            {
                return empItem;
            }
            return empItem;
        }
    }
}
