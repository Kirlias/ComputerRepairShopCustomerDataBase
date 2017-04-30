using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairShopCXDataBaseManager
{
    class Customer
    {
        //customers name REQUIRED
        private string name { get; set; }

        //customers email
        private string email { get; set; }

        //issue with computer REQUIRED
        private string issue { get; set; }

        //work done to correct issue REQUIRED
        private string workDone { get; set; }

        //customers phone number
        private string phoneNumber { get; set; }

        //Cost to complete work, tax on cost and final total REQUIRED
        private float costOfWork { get; set; }
        private float tax { get; set; }
        private float totalCost { get; set; }

    }
}
