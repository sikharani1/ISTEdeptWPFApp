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

namespace ISTE.Views
{
    /// <summary>
    /// Interaction logic for MapView.xaml
    /// </summary>
    public partial class MapView : UserControl
    {
        MapVM vm5;
        public MapView()
        {
            InitializeComponent();
            vm5 = new MapVM();
            this.DataContext = vm5;

            vm5.GetData();
            googlemap.Source = new Uri(vm5.ItemData, UriKind.RelativeOrAbsolute);
        }
    }
}
