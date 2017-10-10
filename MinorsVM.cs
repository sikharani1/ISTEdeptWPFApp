using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTE.Services;

using ISTE.Models;
using System.Windows;

namespace ISTE.ViewModels
{
    class MinorsVM
    {
        MinorsDS datasvc2;
        public Minors ItemData { get; set; }

        public MinorsVM()
        {
            datasvc2 = new MinorsDS();


        }
        internal void GetData()
        {
            var item = datasvc2.GetItemDetails();

          //  foreach(Minors m in item.UgMinors)
          //  {
          //      Console.WriteLine("graddegrees \t" + m.UgMinors);
          //  }
            ItemData = item;

        }
       
    }
}
