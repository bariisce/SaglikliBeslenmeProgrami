
namespace Web.Utilities
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            // Burada DI olarak eklenecek servisleri kaydediyoruz. 
            // Örneğin, IRepository ve IUnitOfWork gibi servisleri ekleyebilirsiniz. 

            return services;
        }
    }
}
