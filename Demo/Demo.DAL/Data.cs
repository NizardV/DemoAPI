using Demo.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.DAL
{
    public class Data : IData
    {
        DemoContext _dbContext;
        public Data()
        {
            _dbContext = new DemoContext();
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.Include(
                customer=>customer.Orders
                ).ToList();
        }

        
    }
}
