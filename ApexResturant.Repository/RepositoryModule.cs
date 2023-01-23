using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexResturant.Repository.RCustomer;


namespace ApexResturant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(connection, builder =>
                builder.migrationsAssembly(migrationsAssembly)));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}