﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
               
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerID)
        {
            // Create the instance of the customer class
            // Pass in the requested id
            Customer customer = new Customer(customerID);

            // Code that retrieves the defined customer

            // Tempory hard-coded values to return
            // a populated customer
            if (customerID == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerID).ToList();
            }
            return customer;
        }



        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>


        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
