using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Models
{
    /// <summary>
    /// Represents a general Employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Employee Name.
        /// </summary>
        public string sEmployeeName { get; set; }

        /// <summary>
        /// Employee's Position.
        /// </summary>
        public string sPosition { get; set; }

        /// <summary>
        /// Employee's ID.
        /// </summary>
        public int iEmployeeId { get; set; }

        /// <summary>
        /// Employee's Manager's Epmployee ID.
        /// </summary>
        public int iManagerId { get; set; }

        /// <summary>
        /// All employees underneath the current employee.
        /// </summary>
        public List<Employee> lstUnderlings { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Employee()
        {
            this.lstUnderlings = new List<Employee>();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="sEmployeeName"></param>
        /// <param name="sPosition"></param>
        /// <param name="iEmployeeId"></param>
        /// <param name="iManagerId"></param>
        public Employee(string sEmployeeName, string sPosition, int iEmployeeId, int iManagerId)
        {
            this.sEmployeeName = sEmployeeName;
            this.sPosition = sPosition;
            this.iEmployeeId = iEmployeeId;
            this.iManagerId = iManagerId;
            this.lstUnderlings = new List<Employee>();
        }

        public override string ToString()
        {
            return this.sEmployeeName;
        }
    }
}
