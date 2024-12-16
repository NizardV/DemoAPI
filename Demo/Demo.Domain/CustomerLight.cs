using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    public class CustomerLight : Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? LastOrderDate { get; set; }


        public CustomerLight()
        {
            
        }

        public CustomerLight(Customer customer)
        {
            this.Id = customer.Id;
            this.Name = customer.Name;
        }
        
    }
}
