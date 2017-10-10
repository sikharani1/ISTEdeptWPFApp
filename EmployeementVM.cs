using ISTE.Models;
using ISTE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.ComponentModel;



namespace ISTE.ViewModels
{
    public class EmployeementVM

    {
        EmploymentDS datasvc2;
        public ICollectionView C { get; set; }
        public EmployeementVM()
        {
            datasvc2 = new EmploymentDS();
        }
        internal void GetData()
        {
            var item = datasvc2.GetItemDetails();
            var c = item.coopTable.coopInformation;
            C = CollectionViewSource.GetDefaultView(c);
            Console.WriteLine(C);
        }
    }


           
       

    
}
