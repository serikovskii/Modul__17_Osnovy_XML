using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace HomeWorkXml
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            String URLString = "https://habrahabr.ru/rss/interesting/";
            //XmlTextReader reader = new XmlTextReader(URLString);
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(URLString);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xNode in xRoot)
            {
                Item item = new Item();
                XmlNode attr = xNode.Attributes.GetNamedItem("title");
                if (attr != null)
                    item.Title = attr.Value;

                foreach (XmlNode childnode in xNode.ChildNodes)
                {
                    if (childnode.Name == "link")
                        item.Link = childnode.InnerText;
                    if (childnode.Name == "description")
                        item.Description = childnode.InnerText;
                }

                items.Add(item);
            }
            foreach (Item i in items)
                Console.WriteLine("{0}, {1}, {2}", i.Title, i.Link, i.Description);


            Console.ReadLine();

        }
    }
}
