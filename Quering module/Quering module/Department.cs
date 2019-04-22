using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Quering_module
{
    public class Department
    {
        public string ID { get;  set; }
        public string Name { get; set; }
    }

    public class DepartmentsList
    {

        public List<Department> ReadDepartments()
        {
            List<Department> departments = new List<Department>();

            XmlSerializer serializer = new XmlSerializer(departments.GetType());

            StreamReader reader = new StreamReader("Departments.xml");
            departments = (List<Department>)serializer.Deserialize(reader);
            reader.Close();
            return departments;

        }
    }
}
