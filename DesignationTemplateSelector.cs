using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ISTE.Models
{
    class DesignationTemplateSelector: DataTemplateSelector
    {
        public DataTemplate LTemplate { get; set; }
        public DataTemplate PTemplate { get; set; }
        public DataTemplate VATemplate { get; set; }
        public DataTemplate VLTemplate { get; set; }
        public DataTemplate DPTemplate { get; set; }
        public DataTemplate SLTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item,
                      DependencyObject container)
        {
            var facy = item as Faculty;
            if (facy == null)
                return base.SelectTemplate(item, container);

            if (facy.desig.Equals(Designation.Lecturer))
            {
                return LTemplate;
            }
            else if (facy.desig.Equals(Designation.Professor))
            {
                return PTemplate;
            }
            else if (facy.desig.Equals(Designation.VistingAssistantProfessor))
            {
                return VATemplate;
            }
            else if (facy.desig.Equals(Designation.VisitingLecturer))
            {
                return VLTemplate;
            }
            else if (facy.desig.Equals(Designation.SeniorLecturer))
            {
                return SLTemplate;
            }
            else 
            {
                return DPTemplate;
            }
        }
       

    }
}

