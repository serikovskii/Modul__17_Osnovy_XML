using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkXmlStudent
{
    [Serializable]
    public class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }


    }
}
