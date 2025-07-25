using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CodeFirst_Restoran.Models.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public Employee Employee { get; set; } // Navigation property to Employee
        public int EmployeeId { get; set; } // Foreign key to Employee
    }
}
