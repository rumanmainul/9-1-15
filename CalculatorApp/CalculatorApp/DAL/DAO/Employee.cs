using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApp.DAL.DAO
{
    public class Employee
    {
        public int DepartmentId { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }
        public bool IsConfirmed { set; get; }
    }
}
