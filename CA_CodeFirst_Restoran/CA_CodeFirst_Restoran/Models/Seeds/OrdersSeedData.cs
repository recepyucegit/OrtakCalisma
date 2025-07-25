using CA_CodeFirst_Restoran.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CodeFirst_Restoran.Models.Seeds
{
    public class OrdersSeedData
    {
        public static List<Orders> orderSeedData = new List<Orders>
        {
            new Orders
            {
                Id = 1,
                OrderName = "Kebap",
                Description = "Lezzetli kebap",
                Price = 50.00m,
                OrderDate = new DateTime(2023, 10, 1),
                EmployeeId = 1 // Assuming the first employee is the one who took this order
            },
            new Orders
            {
                Id = 2,
                OrderName = "Pizza",
                Description = "İtalyan pizzası",
                Price = 30.00m,
                OrderDate = new DateTime(2023, 10, 2),
                EmployeeId = 2 // Assuming the second employee is the one who took this order
            },
            new Orders
            {
                Id = 3,
                OrderName = "Salata",
                Description = "Taze sebzelerle hazırlanan salata",
                Price = 20.00m,
                OrderDate = new DateTime(2023, 10, 3),
                EmployeeId = 3
            }
        };
    }
}
