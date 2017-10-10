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

using ISTE.Models;
using ISTE.ViewModels;


namespace ISTE.Views
{
    /// <summary>
    /// Interaction logic for EmploymentView.xaml
    /// </summary>
    public partial class EmploymentView : UserControl
    {
        EmployeementVM vm2;
        public EmploymentView()
        {
            InitializeComponent();
            vm2 = new EmployeementVM();
            this.DataContext = vm2;

            vm2.GetData();
        }
    }
}
