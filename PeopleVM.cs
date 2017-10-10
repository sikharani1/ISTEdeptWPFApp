using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTE.Services;
using System.Windows.Data;
using System.ComponentModel;
using ISTE.Models;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace ISTE.ViewModels
{
    
    public class PeopleVM
    {
        PeopleDS datasvc3;
        public ICollectionView F { get; set; }
        public ICollectionView I { get; set; }
        public Uri IconUri { get; set; }
        public BitmapImage Imgsource { get; set; }

        public PeopleVM()
        {
            datasvc3 = new PeopleDS();
        }
        internal void GetData()
        {
            var item = datasvc3.GetItemDetails();
            var f = item;

           
            F = CollectionViewSource.GetDefaultView(f);
            Console.WriteLine(F);
           

         
            
        }

        

    }
}
