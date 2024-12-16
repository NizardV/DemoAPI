using Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL
{
    public interface IService
    {
        public CustomerLight GetCustomer(int id);
    }
}
