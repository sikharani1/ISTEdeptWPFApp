using ISTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ISTE.Services
{
    class DataService
    {
        public About GetItemDetails()
        {
            About abtItem = new About();
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri = $"https://ist.rit.edu/api/about";
                    
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);


                    var retItem = item.title;
                    abtItem.title = retItem;
                 abtItem.description = item.description;
                    abtItem.quote = item.quote;
                    abtItem.quoteAuthor = item.quoteAuthor;
                    
                }
            }
            catch (System.Exception ex)
            {
                return abtItem;
            }
            return abtItem;
        }
    }
}
