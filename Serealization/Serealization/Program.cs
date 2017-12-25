using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serealization
{
    class Program
    {
        static void Main(string[] args)
        {
            Order newOrder = new Order
            {
                FoodName = "Pasta",
                CreationDate = DateTime.Now,
                Price = 9990,
                Place = 5,
            };

            using(FileStream stream = new FileStream(@"C:\New Folder\order.xml", FileMode.OpenOrCreate))
            {
                //BinaryFormatter formatter = new BinaryFormatter();
                XmlSerializer formatter = new XmlSerializer(typeof(Order));




                //Serealization
                formatter.Serialize(stream, newOrder);

                //Deserialization
                Order gettingOrder = formatter.Deserialize(stream) as Order;
            }
        }
    }
}
