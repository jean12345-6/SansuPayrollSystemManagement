using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SansuPayrollSystemManagement.Forms
{
    public static class LoginSession
    {
        public static int UserID { get; set; }
        public static int EmployeeID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
    }
}
