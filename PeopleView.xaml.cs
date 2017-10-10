using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ISTE.ViewModels;
using ISTE.Models;
using ISTE.Views;

namespace ISTE.Views
{
    /// <summary>
    /// Interaction logic for PeopleView.xaml
    /// </summary>
    public partial class PeopleView : UserControl
    {
        
        PeopleVM vm4;
        public PeopleView()
        {
            InitializeComponent();
            vm4 = new PeopleVM();
            this.DataContext = vm4;

            vm4.GetData();
           


         



        }
    }
}
