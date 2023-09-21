using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using SQLitePCL;
using System.Linq;
using EcoPower_Logistics.Repository;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context):base(context) 
        {
        }

        public Customer GetMostRescentCustomer()
        {
            return _context.Customers.OrderByDescending(Customer => Customer.CustomerId).FirstOrDefault();

        }
    }
}
