using Recursion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployees;
            string sMessage;

            //Get all employees (in a tree structure)
            if(DataAccess.GetEmployeeTree(out lstEmployees, out sMessage) == false)
            {
                Console.WriteLine(sMessage);
                Console.ReadLine();
                return;
            }

            //Insert all employees
            if(DataAccess.InsertEmployees(lstEmployees, null, out sMessage) == false)
            {
                Console.WriteLine(sMessage);
                Console.ReadLine();
                return;
            }

            //View the "data table". Add a break point to Console.ReadLine(); and view lstTmp.
            List<Employee_Table> lstTmp = DataAccess.lstTable;
            Console.ReadLine();
        }
    }
}
