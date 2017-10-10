using ISTE.Models;
using ISTE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTE.ViewModels
{
    public class CoursesVM
    {

        CoursesDS datasvc;
        public Degrees ItemData { get; set; }
       
        public CoursesVM()
        {
            datasvc = new CoursesDS();


        }
        internal void GetData()
        {
            var item = datasvc.GetItemDetails();
                                                 
            foreach (Graduate grad in item.graduate)
            {
                Console.WriteLine("graddegrees \t" + grad.degreeName);
            }
            ItemData = item;
           
        }


    }
}
