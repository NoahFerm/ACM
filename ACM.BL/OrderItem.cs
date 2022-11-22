using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemID = orderItemId;
        }
        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        
        public OrderItem Retrieve(int orderItemId)
        {
            //Code
            return new OrderItem();
        }

        public bool Save()
        {
            //Code
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;
            return isValid;
        }
    }
}
