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

        public string getCar(string colName)
        {

            if (colName == "StockNumber") return StockNumber;
            else if (colName == "Make") return Make;
            else if (colName == "Model") return Model;
            return null;
        }
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
        public List<string> colNames()
        {
            List<string> lst = new List<string>();
            lst.Add("StockNumber");
            lst.Add("Make");
            lst.Add("Model");
            return lst;
        }
        
    }
}
