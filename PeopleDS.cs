using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using ISTE.Models;
using System.Net.Http;

namespace ISTE.Services
{
    public class PeopleDS
    {
        public List<Faculty> GetItemDetails()
        {
            People facItem = new People();
            Faculty fa = new Faculty();

            List < Faculty > fac = new List<Faculty>();

            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri3 = $"https://ist.rit.edu/api/people";

                    var response1 = client.GetAsync(uri3).Result;
                    var content1 = response1.Content.ReadAsStringAsync().Result;
                    dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content1);
                    facItem.faculty = item1.faculty.ToObject<List<Faculty>>();
                     
                    fac = item1.faculty.ToObject<List<Faculty>>();
                    var designation=new Designation();
                    foreach (Faculty fy in fac)
                    {
                        Console.WriteLine("graddegrees \t" + fy.imagePath);


                        // try to parse the string as a TestEnum without throwing an exception
                        //   fy.desig=designation;
                        if (Enum.TryParse(fy.title, true, out designation))
                        {
                            // success
                            fy.desig = designation;
                            Console.WriteLine("designation \t" + fy.desig);
                        }
                        else if (fy.title == "Senior Lecturer")
                        {
                            // the string isn't an element of TestEnum
                            Enum.TryParse("SeniorLecturer", true, out designation);
                            fy.desig = designation;
                        }
                        else if (fy.title == "Assistant Professor")
                        {
                            Enum.TryParse("AssistantProfessor", true, out designation);
                            fy.desig = designation;
                        }
                        else if (fy.title == "Associate Professor")
                        {
                            Enum.TryParse("AssociateProfessor", true, out designation);
                            fy.desig = designation;
                        }
                        else if (fy.title == "Distinguished Profesoor")
                        {
                            Enum.TryParse("DistinguishedProfessor", true, out designation);
                            fy.desig = designation;
                        }
                        else if (fy.title == "Visiting Assistant Profesoor")
                        {
                            Enum.TryParse("VisitingAssistantProfessor", true, out designation);
                            fy.desig = designation;
                        }
                        else 
                        {
                            Enum.TryParse("VisitingLecturer", true, out designation);
                            fy.desig = designation;
                        }


                            // ...


                            //        fy.imagePath = fy.imagePath;
                            fy.IconUri = new Uri(fy.imagePath);
                        fy.image = new System.Windows.Media.Imaging.BitmapImage(fy.IconUri);
                    }

                   

                    //   coopinformation = item1.coopTable.coopInformation.ToObject<List<CoopInformation>>();
                    //  facItem.Fcaulty.coopInformation = coopinformation;
                    //   degItem.coopTable = item1.coopTable;
                   


                    // var retItem1 = item1.undergraduate;
                    //    graddegrees = item1.graduate;
                    //  undergraddegrees = item1.undergraduate;
                    //  coopt.coopInformation = coopinformation;


              /*      foreach (Faculty f in facItem.faculty)
                      {
                          Console.WriteLine("graddegrees \t" + f.name);
                               Console.WriteLine("graddegrees \t" + f.username);
                           Console.WriteLine("graddegrees \t" + f.tagline);
                            Console.WriteLine("graddegrees \t" + f.title);
                        Console.WriteLine("graddegrees \t" + f.interestArea);
                        Console.WriteLine("graddegrees \t" + f.office);
                        Console.WriteLine("graddegrees \t" + f.website);
                        Console.WriteLine("graddegrees \t" + f.phone);
                        Console.WriteLine("graddegrees \t" + f.email);
                        Console.WriteLine("graddegrees \t" + f.twitter);
                        Console.WriteLine("graddegrees \t" + f.facebook);
                      //  Console.WriteLine("graddegrees \t" + f.phone);
                    } */

                }
            }
            catch (System.Exception ex)
            {
                return fac;
            }
            return fac;
        }
    }
}
