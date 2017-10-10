using ISTE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTE.ViewModels
{
    public class AboutVM
    {

        DataService datasvc;
        public string ItemDatatitle { get; set; }
        public string ItemDatadescription { get; set; }
        public string quote { get; set; }
        public string quoteAuthor { get; set; }
        public AboutVM()
        {
            datasvc = new DataService();
            
    
    }
        internal void GetData()
        {
            var item = datasvc.GetItemDetails();

            ItemDatatitle = item.title.ToString();
            ItemDatadescription = item.description.ToString();
            quote = item.quote.ToString();
            quoteAuthor = item.quoteAuthor.ToString();

        }

        
    }
}



