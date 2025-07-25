using CA_CodeFirst_Restoran.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CodeFirst_Restoran.Models.Seeds
{
    public class EmpolyeeSeedData
    {
        public static List<Employee> employeeData = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Ali",
                Surname = "Veli",
                Position = "Garson",
                DateOfBirth = new DateTime(1990, 5, 20),
                PhoneNumber = "555-1234"
            },
            new Employee
            {
                Id = 2,
                Name = "Ayşe",
                Surname = "Yılmaz",
                Position = "Aşçı",
                DateOfBirth = new DateTime(1985, 3, 15),
                PhoneNumber = "555-5678"
            }
        };

    }
}
