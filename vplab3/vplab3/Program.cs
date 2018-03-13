using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vplab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, password, name;
            double salary=0;
            id = password = name = null;
            employeeData obj = new employeeData();
            obj.getData(name, salary);
            Console.ReadLine();
        }
    }
}
