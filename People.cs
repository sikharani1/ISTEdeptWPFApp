using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace ISTE.Models
{
    public enum Designation
    {
        Lecturer,
        Professor,
        AssistantProfessor,
        SeniorLecturer,
        AssociateProfessor,
        VisitingLecturer,
        VistingAssistantProfessor,
        DistinguishedProfessor

    }
    public class Faculty
    {
        public BitmapImage _image;
        public Uri _IconUri;
        public string username { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
       
        public Uri IconUri
        {
            get;
        
            set; }
        
       
            

        public string title { get; set; }
        public string interestArea { get; set; }
        public string office { get; set; }
        public Uri website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
        [Browsable(false)]
        public Designation desig { get; set; }
        [Browsable(false)]
        public BitmapImage image { get; set; }
        [Browsable(false)]
        public string imagePath { get; set; }
    }

    public class Staff
    {
        public string username { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string imagePath { get; set; }
        public string title { get; set; }
        public string interestArea { get; set; }
        public string office { get; set; }
        public Uri website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
    }
   

    public class People
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public List<Faculty> faculty { get; set; }
        public List<Staff> staff { get; set; }
        
    }
}
