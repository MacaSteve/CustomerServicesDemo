using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerServicesDemo
{
    public class CustomerServices : Service
    {
        public object Post(Customer customer)
        {
            return CustomerRepository.Create(customer);
        }

        public object Get(Customer customer)
        {
            if (customer.CustomerId == null)
                return CustomerRepository.Read();

            return CustomerRepository.ReadCustomer(customer.CustomerId ?? -1);
        }

        public object Get()
        {
            return CustomerRepository.Read();
        }

        public object Put(Customer customer)
        {
            return CustomerRepository.Update(customer);
        }

        public object Delete(Customer customer)
        {
            CustomerRepository.Delete(customer);
            return null;
        }
    }
}