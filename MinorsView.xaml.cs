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
    /// Interaction logic for MinorsView.xaml
    /// </summary>
    public partial class MinorsView : UserControl
    {
        MinorsVM vm5;
        public MinorsView()
        {
            InitializeComponent();
            vm5 = new MinorsVM();
            this.DataContext = vm5;
            
            vm5.GetData();


        }
    
        private void radioButton_Click(object sender1, RoutedEventArgs e1)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();
            

                foreach (UgMinor ug in vm5.ItemData.UgMinors)
                {
                    if (ug.name == minorselected)
                    {
                        minordetails.Text = "";
                    minordetails.Text = ug.title+"\n";
                        minordetails.Text = ug.description + "\n\n";
                        Console.WriteLine("ugminors \t" + ug.name);
                    foreach (var course in ug.courses)
                    {
                        minordetails.Text += course + "\n";
                    }
                    minordetails.FontWeight = FontWeights.Bold;
                    minordetails.Text += ug.note;
                    }
                
            }
    //        flag1 = true;
        }
  

        

        private void radioButton1_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                {
                    minordetails.Text = "";
                    minordetails.Text = ug.title + "\n";
                    minordetails.Text = ug.description + "\n\n";
                    Console.WriteLine("ugminors \t" + ug.name);
                    foreach (var course in ug.courses)
                    {
                        minordetails.Text += course + "\n";
                    }
                    minordetails.FontWeight = FontWeights.Bold;
                    minordetails.Text +="\n"+ ug.note;
                }

            }
          
        
    }

        private void radioButton2_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                {
                    minordetails.Text = "";
                    minordetails.Text = ug.title + "\n";
                    minordetails.Text = ug.description + "\n\n";
                    Console.WriteLine("ugminors \t" + ug.name);
                    foreach (var course in ug.courses)
                    {
                        minordetails.Text += course + "\n";
                    }
                    minordetails.FontWeight = FontWeights.Bold;
                    minordetails.Text += "\n"+ug.note;
                }

            }
        }

        private void radioButton3_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                    if (ug.name == minorselected)
                    {
                        minordetails.Text = "";
                        minordetails.Text = ug.title + "\n";
                        minordetails.Text = ug.description + "\n\n";
                        Console.WriteLine("ugminors \t" + ug.name);
                        foreach (var course in ug.courses)
                        {
                            minordetails.Text += course + "\n";
                        }
                        minordetails.FontWeight = FontWeights.Bold;
                        minordetails.Text += "\n"+ug.note;
                    }

            }
        }

        private void radioButton4_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                    if (ug.name == minorselected)
                    {
                        minordetails.Text = "";
                        minordetails.Text = ug.title + "\n";
                        minordetails.Text = ug.description + "\n\n";
                        Console.WriteLine("ugminors \t" + ug.name);
                        foreach (var course in ug.courses)
                        {
                            minordetails.Text += course + "\n";
                        }
                        minordetails.FontWeight = FontWeights.Bold;
                        minordetails.Text +="\n"+ ug.note;
                    }

            }
        }

        private void radioButton6_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                    if (ug.name == minorselected)
                    {
                        minordetails.Text = "";
                        minordetails.Text = ug.title + "\n";
                        minordetails.Text = ug.description + "\n\n";
                        Console.WriteLine("ugminors \t" + ug.name);
                        foreach (var course in ug.courses)
                        {
                            minordetails.Text += course + "\n";
                        }
                        minordetails.FontWeight = FontWeights.Bold;
                        minordetails.Text +="\n"+ ug.note;
                    }

            }
        }

        private void radioButton5_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                    if (ug.name == minorselected)
                    {
                        minordetails.Text = "";
                        minordetails.Text = ug.title + "\n";
                        minordetails.Text = ug.description + "\n\n";
                        Console.WriteLine("ugminors \t" + ug.name);
                        foreach (var course in ug.courses)
                        {
                            minordetails.Text += course+ "\n";
                        }
                        minordetails.FontWeight = FontWeights.Bold;
                        minordetails.Text += "\n"+ug.note;
                    }

            }
        }

        private void radioButton7_Click(object sender1, RoutedEventArgs e)
        {
            var b = sender1 as RadioButton;
            var minorselected = b.Content.ToString();


            foreach (UgMinor ug in vm5.ItemData.UgMinors)
            {
                if (ug.name == minorselected)
                    if (ug.name == minorselected)
                    {
                        minordetails.Text = "";
                        minordetails.Text = ug.title + "\n";
                        minordetails.Text = ug.description + "\n\n";
                        Console.WriteLine("ugminors \t" + ug.name);
                        foreach (var course in ug.courses)
                        {
                            minordetails.Text += course + "\n";
                        }
                        minordetails.FontWeight = FontWeights.Bold;
                        minordetails.Text += "\n"+ug.note;
                    }

            }
        }
    }
}
