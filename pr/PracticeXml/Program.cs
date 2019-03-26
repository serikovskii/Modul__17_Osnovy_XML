using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PracticeXml
{
    class Program
    {
        static void Main(string[] args)
        {
            var xDoc = new XmlDocument();
            xDoc.Load("xmlCar.xml");
            var root = xDoc.DocumentElement;
            Console.WriteLine(root.LocalName);
            foreach (XmlAttribute attr in root.Attributes)
                Console.WriteLine(attr.LocalName);
            foreach (XmlNode child in root.ChildNodes)
            {
                Console.WriteLine("  " + child.Name);
                foreach (XmlNode childName in child.ChildNodes)
                {
                    Console.WriteLine("    " + childName.Name);
                }
            }
                
            


        }
    }
}
