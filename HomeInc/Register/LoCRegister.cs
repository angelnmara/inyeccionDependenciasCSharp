using HomeInc.DTO.Mapper;
using HomeInc.DTO.Mapper.Implements;
using HomeInc.Repository;
using HomeInc.Repository.Implements;
using HomeInc.Services;
using HomeInc.Services.Implements;

namespace HomeInc.Register
{
    public static class LoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services) {
            AddRegisterServices(services);
            AddRegisterMappers(services);
            AddRegisterRepository(services);
            return services;
        }

        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {            
            services.AddTransient<IProductService, ProductServiceImpl>();
            return services;
        }

        private static IServiceCollection AddRegisterMappers(IServiceCollection services)
        {            
            services.AddTransient<IProductMapper, ProductMapperImpl>();
            return services;
        }

        private static IServiceCollection AddRegisterRepository(IServiceCollection services)
        {            
            services.AddTransient<IProductRepository, ProductRepositoryImpl>();
            return services;
        }

    }
}
