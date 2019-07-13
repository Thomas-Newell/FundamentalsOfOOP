using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderitemID)
        {
            OrderItemID = orderitemID;
        }

        public int OrderItemID { get; private set; }
        public int ProductId{ get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }



        /// <summary>
        /// Retrieve one order item.
        /// <summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemID)
        {
            // Code that retrieves the defined order item.

            return new OrderItem();
        }



        /// <summary>
        /// Saves the current order item.
        /// <summary>
        /// <returns></returns>
        public bool Save(OrderItem orderitem)
        {
            var success = true;

            if (orderitem.HasChanges)
            {
                if (orderitem.IsValid)
                {
                    if (orderitem.IsNew)
                    {
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // Call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }



        /// <summary>
        /// Validates the Order Data.
        /// <summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}