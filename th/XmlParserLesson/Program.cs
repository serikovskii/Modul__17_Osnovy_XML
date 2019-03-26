using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlParserLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var cities = new List<City>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("data.xml");

            var rootElement = xmlDocument.DocumentElement;
            foreach (XmlElement child in rootElement.ChildNodes)
            {
                var idElement = child.GetElementsByTagName("id")[0];
                if (idElement.Name == "id")
                {
                    var idType = (idElement as XmlElement).GetAttribute("type");
                    if (idType == "int") continue;
                }

                var nameElement = child.GetElementsByTagName("name")[0];
                var countryNameElement = child.GetElementsByTagName("countryName")[0];
                var latitudeElement = child.GetElementsByTagName("latitude")[0];
                var longitudeElement = child.GetElementsByTagName("longitude")[0];

                var city = new City
                {
                    id =Guid.Parse(idElement.InnerText),
                    Name = nameElement.InnerText,
                    CountryName = countryNameElement.InnerText,
                    Latitude = double.Parse(latitudeElement.InnerText),
                    Longitude = double.Parse(longitudeElement.InnerText)
                };
                cities.Add(city);
            }*/

            var city = new City
            {
                Name = "Караганда",
                CountryName = "Казахстан",
                Latitude = 57.8,
                Longitude = 22.2
            };

            XmlDocument xmlDocument = new XmlDocument();
            var rootElement = xmlDocument.CreateElement("city");

            

            var idElement = xmlDocument.CreateElement("id");
            idElement.SetAttribute("type", "Guid");
            idElement.InnerText = city.id.ToString();

            var nameElement = xmlDocument.CreateElement("name");
            nameElement.InnerText = city.Name;

            var countryNameElement = xmlDocument.CreateElement("countryName");
            countryNameElement.InnerText = city.CountryName;        

            var latitudeElement = xmlDocument.CreateElement("latitude");
            latitudeElement.InnerText = city.Latitude.ToString();

            var longitudeElement = xmlDocument.CreateElement("longitude");
            longitudeElement.InnerText = city.Longitude.ToString();



            rootElement.AppendChild(idElement);
            rootElement.AppendChild(nameElement);
            rootElement.AppendChild(countryNameElement);
            rootElement.AppendChild(latitudeElement);
            rootElement.AppendChild(longitudeElement);

            xmlDocument.AppendChild(rootElement);

            xmlDocument.Save("data2.xml");
        }
    }
}
