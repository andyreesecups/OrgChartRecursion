using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Models
{
    /// <summary>
    /// Represents a database table row for an employee structure.
    /// </summary>
    public class Employee_Table
    {
        /// <summary>
        /// ID for the row.
        /// </summary>
        public int iId { get; set; }

        /// <summary>
        /// Manager's ID (foreign key to match with Employee_Table.iId).
        /// </summary>
        public int? iManagerId { get; set; }

        /// <summary>
        /// Employee Position.
        /// </summary>
        public string sPosition { get; set; }
    }
}
