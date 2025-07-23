using CA_NorthwindEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindEF.Managers.Abstracts
{
    internal interface IShipperManager
    {
        string CreateShipper(Shipper shipper);

    }
}
