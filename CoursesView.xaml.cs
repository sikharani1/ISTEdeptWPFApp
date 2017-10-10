
using ISTE.Models;
using ISTE.ViewModels;
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


namespace ISTE.Views
{
    /// <summary>
    /// Interaction logic for CoursesView.xaml
    /// </summary>
    public partial class CoursesView : UserControl
    {
        CoursesVM vm;
        public CoursesView()
        {
            InitializeComponent();
            vm = new CoursesVM();
            this.DataContext = vm;

            vm.GetData();
        }
        bool flag=false;
        bool flag1=false;
        private void UnderGraduate_Click(object sender1, RoutedEventArgs e1)
        {
            if (flag1 == false)
            {
                foreach (Undergraduate grad in vm.ItemData.undergraduate)
                {
                    var textb = new Button();
             
                    undergradpanel.Children.Add(textb);
                    textb.Content = grad.degreeName.ToUpper();
                    textb.Click += new RoutedEventHandler(ugdegreeEventHandler);
                    Console.WriteLine("graddegrees \t" + grad.degreeName);
                }
            }
            flag1 = true;
        }
        void ugdegreeEventHandler(object sender2, RoutedEventArgs e2)
        {
           
            var b = sender2 as Button;
           
  
                 myBorder1.Background = Brushes.SkyBlue;
                 myBorder1.BorderBrush = Brushes.Blue;
                 myBorder1.BorderThickness = new Thickness(2);
                 myBorder1.CornerRadius = new CornerRadius(8);
                 myBorder1.Padding = new Thickness(6);

             
            var degreeselected = b.Content.ToString().ToLower();

            if (undergradpaneldesc.Children.Count < 1)
            {


                var textb2 = new TextBlock();
                            textb2.Name = "textblock";

                undergradpaneldesc.Children.Add(textb2);

                foreach (Undergraduate grad in vm.ItemData.undergraduate)
                {
                    if (grad.degreeName == degreeselected)
                    {
                        textb2.TextDecorations = TextDecorations.Underline;
                        textb2.Text = grad.description+"\n\n";
                        foreach (var conc in grad.concentrations)
                        {
                            textb2.Text += conc + "\n";
                        }

                        textb2.TextWrapping = TextWrapping.Wrap;
                        return;
                    }
                }


            }
            else
            {

                foreach (Undergraduate grad in vm.ItemData.undergraduate)
                {
                    if (grad.degreeName == degreeselected)
                    {

                        foreach (TextBlock ch in undergradpaneldesc.Children)
                        {
                            ch.Text = "";
                            ch.TextDecorations = TextDecorations.Underline;
                            ch.Text = grad.description+"\n\n";
                            foreach (var conc in grad.concentrations)
                            {
                                ch.Text += conc + "\n";
                            }
                            ch.TextWrapping = TextWrapping.Wrap;
                            return;
                        }
                    }
                }
            }



        }
        private void Graduate_Click(object sender, RoutedEventArgs e)
        {

            if (flag == false)
            {
                foreach (Graduate grad in vm.ItemData.graduate)
                {
                   
                  
                        var textb = new Button();
                        gradpanel.Children.Add(textb);
                        textb.Content = grad.degreeName.ToUpper();
                        textb.IsDefault = true;
                        textb.Click += new RoutedEventHandler(degreeEventHandler);

                        Console.WriteLine("graddegrees \t" + grad.degreeName);
                    
                }
            }
            flag = true;
        }
       
        void degreeEventHandler(object sender, RoutedEventArgs e)
        {
           
            var b = sender as Button;
           
            
            var degreeselected = b.Content.ToString().ToLower();
            
                myBorder2.Background = Brushes.SkyBlue;
                myBorder2.BorderBrush = Brushes.Black;
                myBorder2.BorderThickness = new Thickness(2);

                myBorder2.CornerRadius = new CornerRadius(8);
                myBorder2.Padding = new Thickness(6);

             
            if (gradpaneldesc.Children.Count<1)
            {
              

                var textb1 = new TextBlock();
                textb1.Name = "textblock1";

                gradpaneldesc.Children.Add(textb1);

                foreach (Graduate grad in vm.ItemData.graduate)
                {
                    if (grad.degreeName == degreeselected)
                    {
                        if (grad.degreeName != "graduate advanced certificates")
                        {
                            textb1.Text = grad.description+"\n";
                            textb1.TextDecorations = TextDecorations.Underline;
                            foreach (var conc in grad.concentrations)
                            {
                                textb1.Text += conc + "\n";
                            }

                            textb1.TextWrapping = TextWrapping.Wrap;
                            return;
                        }
                        else
                        {
                           
                            textb1.TextDecorations = TextDecorations.Underline;
                            foreach (var conc in grad.availableCertificates)
                            {
                                textb1.Text += conc + "\n\n";
                            }

                            textb1.TextWrapping = TextWrapping.Wrap;
                            return;
                        }
                    }
                }


            }
            else
            {

                foreach (Graduate grad in vm.ItemData.graduate)
                {
                    if (grad.degreeName == degreeselected)
                    {
                        if (grad.degreeName != "graduate advanced certificates")
                        {
                            foreach (TextBlock ch in gradpaneldesc.Children)
                            {
                                ch.Text = "";
                                ch.Text = grad.description + "\n\n";
                                ch.TextDecorations = TextDecorations.Underline;
                                foreach (var conc in grad.concentrations)
                                {
                                    ch.Text += conc + "\n";
                                }

                                ch.TextWrapping = TextWrapping.Wrap;
                                return;
                            }
                        }
                        else
                        {
                            foreach (TextBlock ch in gradpaneldesc.Children)
                            {
                                ch.Text = "";
                                
                                ch.TextDecorations = TextDecorations.Underline;
                                foreach (var conc in grad.availableCertificates)
                                {
                                    ch.Text += conc + "\n\n";
                                }

                                ch.TextWrapping = TextWrapping.Wrap;
                                return;
                            }
                        }
                    }
                }
            }

           

        }

        private void Certifications_Click(object sender, RoutedEventArgs e)
        {
            var textb3 = new TextBlock();
            textb3.Name = "textblock3";

            certificatedesc.Children.Add(textb3);

            textb3.TextDecorations = TextDecorations.Underline;
            myBorder3.Background = Brushes.SkyBlue;
            myBorder3.BorderBrush = Brushes.Black;
            myBorder3.BorderThickness = new Thickness(2);

            myBorder3.CornerRadius = new CornerRadius(8);
            myBorder3.Padding = new Thickness(6);
            foreach (Graduate grad in vm.ItemData.graduate)
            {

                if (grad.degreeName == "graduate advanced certificates")
                {
                    if (certificatedesc.Children.Count < 1)
                    {
                        textb3.Text = grad.description;
                        textb3.TextDecorations = TextDecorations.Underline;
                        foreach (var conc in grad.availableCertificates)
                        {
                            textb3.Text += conc + "\n\n";
                        }

                        textb3.TextWrapping = TextWrapping.Wrap;
                        return;
                    }
                    else
                    {
                        foreach (TextBlock ch in certificatedesc.Children)
                        {
                            ch.Text = "";

                            ch.TextDecorations = TextDecorations.Underline;
                            foreach (var conc in grad.availableCertificates)
                            {
                                ch.Text += conc + "\n";
                            }

                            ch.TextWrapping = TextWrapping.Wrap;
                            return;
                        }
                    }
                }

            }
        }
    }
}
