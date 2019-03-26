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
            using (WebClient webClient = new WebClient())
            {
                List<Item> items = new List<Item>();
                webClient.Encoding = Encoding.UTF8;
                string xml = webClient.DownloadString("https://habrahabr.ru/rss/interesting/");
                XmlDocument xDoc = new XmlDocument();

                xDoc.LoadXml(xml);
                XmlNode titleElement = null;
                XmlNode linkElement = null;
                XmlNode descriptionElement = null;
                XmlNode pubDateElement = null;

                foreach (XmlElement element in xDoc.GetElementsByTagName("item"))
                {
                    

                    foreach (XmlElement child in element)
                    {
                        if (child.Name == "title")
                        {
                            titleElement = child;
                        }
                        else if (child.Name == "link")
                        {
                            linkElement = child;
                        }
                        else if (child.Name == "description")
                        {
                            descriptionElement = child;
                        }
                        else if (child.Name == "pubDate")
                        {
                            pubDateElement = child;
                        }
                    }
                    var item = new Item
                    {
                        Title = titleElement.InnerText,
                        Link = linkElement.InnerText,
                        Description = descriptionElement.InnerText,
                        PubDate = pubDateElement.InnerText
                    };

                    items.Add(item);
                }
                foreach (Item i in items)
                {
                    Console.WriteLine("Заголовок: \t{0}\nСсылка: \t{1}\nНовость: \t{2}\nДата: \t{3}", i.Title, i.Link, i.Description, i.PubDate);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }

            Console.ReadLine();

        }
    }
}
