using Demo.DAL;
using Demo.Domain;

namespace Demo.BL
{
    public class Service : IService
    {
        private readonly IData _data;
                
        public Service(IData data)
        {
            _data = data;
        }
        public CustomerLight GetCustomer(int id)
        {
            return (CustomerLight)_data.GetCustomers()
                .Where(c => c.Id == id)
                .Select(c => new CustomerLight
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastOrderDate = c.Orders.Last().Date
                });
        }
    }
}
