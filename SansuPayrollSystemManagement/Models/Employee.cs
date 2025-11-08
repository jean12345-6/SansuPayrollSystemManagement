using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SansuPayrollSystemManagement.Models
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ContactInfo { get; set; }
        public decimal Salary { get; set; }
        public byte[] FingerprintTemplate { get; set; }
        public System.DateTime DateHired { get; set; }
    }
}
