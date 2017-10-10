using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTE.Services;
using ISTE.Models;

namespace ISTE.ViewModels
{
    public class MapVM
    {
        MapDS datasvc;
        public string ItemData { get; set; }

        public MapVM()
        {
            datasvc = new MapDS();


        }
        internal void GetData()
        {
            var item = datasvc.GetItemDetails();

            
            ItemData = item.map.ToString();

        }


    }
}
