using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParserLesson
{
    public class City
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public City()
        {
            id = Guid.NewGuid();
        }
    }
}
