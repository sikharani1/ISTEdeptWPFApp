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

namespace ISTE.Views
{
    /// <summary>
    /// Interaction logic for Resources.xaml
    /// </summary>
    public partial class Resources : UserControl
    {
        ResourcesVM vm6;
        public Resources()
        {
            InitializeComponent();
            vm6 = new ResourcesVM();
            this.DataContext = vm6;

            vm6.GetData();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ritwebsite.Visibility = System.Windows.Visibility.Visible; ;
            this.ritwebsite.Navigate(new Uri("https://www.rit.edu"));
        }
       
      

        private void studyAbroad_MouseDown(object sender2, MouseButtonEventArgs e)
        {
            {
                var b = sender2 as Canvas;
                var selected = b.Name;
                var resselected = b.Name.ToString();

                if (resselected == "studyAbroad")
                {
                    res.Text = "";
                    res.Text = vm6.ItemData.studyAbroad.description+"\n";
                    foreach (Place p in vm6.ItemData.studyAbroad.places)
                    {
                       
                        
                         
                        res.Text += p.nameOfPlace + "\n";
                        res.Text+= p.description + "\n";
                            Console.WriteLine("places \t" + p.nameOfPlace);
                        

                    }

                }
                else if (resselected == "studentServices")
                {
                    res.Text = "";
                    res.Text = vm6.ItemData.studentServices.title +"\n";
                    res.Text += vm6.ItemData.studentServices.academicAdvisors.description;

                    
                }
                else
                {
                    res.Text = "";
                    res.Text = vm6.ItemData.studentAmbassadors.title ;
                        foreach(SubSectionContent s in vm6.ItemData.studentAmbassadors.subSectionContent)
                    {
                        if (s.title == "Duties")
                        {
                            break;

                        }
                        else
                        {
                            res.Text += "\n" + s.title;
                            res.Text += "\n" + s.description;
                        }
                    }

                        

                }


                 

            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
