using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerServicesDemo
{
    public class CustomerRepository
    {
        static int _index = 0;
        static List<Customer> _customers = new List<Customer>();

        public static Customer Create(Customer cust)
        {
            cust.CustomerId = _index++;
            _customers.Add(cust);
            return cust;
        }

        public static Customer ReadCustomer(int custId)
        {
            return _customers.FirstOrDefault(cust => cust.CustomerId == custId);
        }

        public static List<Customer> Read()
        {
            return _customers;
        }

        public static Customer Update(Customer cust)
        {
            var customer = _customers.FirstOrDefault(c => cust.CustomerId == cust.CustomerId);
            customer.Name = cust.Name;
            customer.Phone = cust.Phone;
            customer.Address = cust.Address;
            return customer;
        }

        public static void Delete(Customer cust)
        {
            var customer = _customers.FirstOrDefault(c => c.CustomerId == cust.CustomerId);
            _customers.Remove(customer);
        }
    }
}