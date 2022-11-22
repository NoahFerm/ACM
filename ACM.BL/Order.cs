using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderID = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        
        public Order Retrieve(int orderId)
        {
            //Code
            return new Order();
        }

        public bool Save()
        {
            //Code
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            
            return isValid;
        }
    }
}
