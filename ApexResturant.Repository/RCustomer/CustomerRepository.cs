using ApexResturant.Repository.Domain;
namespace ApexResturant.Repository.RCustomer
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}