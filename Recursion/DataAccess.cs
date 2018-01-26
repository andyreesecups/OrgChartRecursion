using Recursion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class DataAccess
    {
        #region Variables

        /// <summary>
        /// This is being used in place of an auto-incremented id from a data-table. This is temporary!
        /// </summary>
        private static int iCurrentId = 0;

        /// <summary>
        /// This is being used to represent the actual data-table we'd be inserting into.
        /// </summary>
        public static List<Employee_Table> lstTable = new List<Employee_Table>();

        #endregion

        #region Queries

        /// <summary>
        /// Returns a list of employees (Temporary, this would be gathered from a data source!)
        /// </summary>
        /// <param name="lstEmployees"></param>
        /// <param name="sMessage"></param>
        /// <returns></returns>
        public static bool GetEmployeeTree(out List<Employee> lstEmployees, out string sMessage)
        {
            lstEmployees = new List<Employee>();
            sMessage = "";

            lstEmployees.Add(new Employee("John Andre", "CIO", 0, 0));

            Employee eTmp = new Employee("Victor Pham", "Senior Dev", 1, 0);
            eTmp.lstUnderlings.Add(new Employee("Ram Patel", "Junior Dev", 2, 1));
            eTmp.lstUnderlings.Add(new Employee("Kyle Phillips", "Junior Dev", 3, 1));
            lstEmployees.Last().lstUnderlings.Add(eTmp);

            eTmp = new Employee("Mark Walther", "IT Analyst Lead", 4, 4);
            eTmp.lstUnderlings.Add(new Employee("Vincent Trevino", "IT Analyst", 5, 4));
            eTmp.lstUnderlings.Add(new Employee("Jacob Martinez", "IT Analyst", 6, 4));
            lstEmployees.Last().lstUnderlings.Add(eTmp);

            return true;
        }

        /// <summary>
        /// Recursively inserts a general employee structure based on a tree-based structure of employees.
        /// </summary>
        /// <param name="lstEmployees"></param>
        /// <param name="iManagerId"></param>
        /// <param name="sMessage"></param>
        /// <returns></returns>
        public static bool InsertEmployees(List<Employee> lstEmployees, int? iManagerId, out string sMessage)
        {
            sMessage = "";

            foreach (Employee employee in lstEmployees)
            {
                //replace this with an SQL insert call
                lstTable.Add(new Employee_Table()
                    {
                        iId = iCurrentId++,
                        sPosition = employee.sPosition,
                        iManagerId = iManagerId,
                    });

                //replace this with a SQL select call for the largest / last ID
                int? iTmpId = lstTable.Last().iId;

                //BASE CASE: If we don't match this we're done, move to the next employee in our list
                if(employee.lstUnderlings.Count > 0)
                {
                    //Recursively call this function passing in the current employee's underlings and the current inserted records ID as a parent
                    if (InsertEmployees(employee.lstUnderlings, iTmpId, out sMessage) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion
    }
}
