using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Quering_module
{

   // [Serializable()]
    public class Car
    {
        public string StockNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }


  //  [Serializable()]
    public class CarCollection
    {
        public List<Car> read()
        {
            List<Car> cars = new List<Car>();

            XmlSerializer serializer = new XmlSerializer(cars.GetType());

            StreamReader reader = new StreamReader("cars.xml");
            cars = (List<Car>)serializer.Deserialize(reader);
            reader.Close();
            return cars;

        }


    }
}
