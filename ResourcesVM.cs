using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTE.Services;
using ISTE.Models;

namespace ISTE.ViewModels
{
    class ResourcesVM
    {
        ResourcesDS datasvc2;
        public Resources ItemData { get; set; }

        public ResourcesVM()
        {
            datasvc2 = new ResourcesDS();


        }
        internal void GetData()
        {
            var item = datasvc2.GetItemDetails();
            
            ItemData = item;


        }

    }
}

