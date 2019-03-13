using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HomeWorkXmlStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {FullName = "Leo Messi", Age = 32, City = "Barcelona", Faculty = "Forward", University = "FC Barcelona"};

            XmlDocument xmlDocument = new XmlDocument();
            var rootElement = xmlDocument.CreateElement("student");

            var fullNameElement = xmlDocument.CreateElement("fullName");
            fullNameElement.InnerText = student.FullName;
            var ageElement = xmlDocument.CreateElement("age");
            ageElement.InnerText = student.Age.ToString();
            var cityElement = xmlDocument.CreateElement("city");
            cityElement.InnerText = student.City;
            var facultyElement = xmlDocument.CreateElement("faculty");
            facultyElement.InnerText = student.Faculty;
            var universityElement = xmlDocument.CreateElement("university");
            universityElement.InnerText = student.University;


            rootElement.AppendChild(fullNameElement);
            rootElement.AppendChild(ageElement);
            rootElement.AppendChild(cityElement);
            rootElement.AppendChild(facultyElement);
            rootElement.AppendChild(universityElement);

            xmlDocument.AppendChild(rootElement);

            xmlDocument.Save("student.xml");
        }
    }
}
