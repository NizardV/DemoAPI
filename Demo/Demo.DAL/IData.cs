using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL
{
    public interface IData
    {
        public List<Customer> GetCustomers();
    }
}
