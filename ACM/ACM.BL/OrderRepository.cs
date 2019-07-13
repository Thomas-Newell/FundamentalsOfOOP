using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {   
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Create an instance of the order class
            // pass in the requested Id
            Order order = new Order(orderId);

            // Code that retrieves the defined order.

            // Temporary hard coded values to return
            // a populated order
            if (orderId == 10)
            {
                // :Use curent year in hard coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <return></return>
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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
    }
}
