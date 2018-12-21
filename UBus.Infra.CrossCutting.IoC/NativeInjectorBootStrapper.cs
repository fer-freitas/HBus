using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using UBus.Application.AutoMapper;
using UBus.Application.Interfaces;
using UBus.Application.Services;
using UBus.Domain.Interfaces;
using UBus.Infra.Data.Context;
using UBus.Infra.Data.Repository;

namespace UBus.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<HttpContextAccessor, HttpContextAccessor>();

            // Application
            services.AddSingleton<IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            services.AddScoped<IVeiculoAppService, VeiculoAppService>();
            services.AddScoped<IRotaAppService, RotaAppService>();
            services.AddScoped<IViagemAppService, ViagemAppService>();
            services.AddScoped<IFuncionarioAppService, FuncionarioAppService>();
            services.AddScoped<IItinerarioAppService, ItinerarioAppService>();

            // Infra - Data
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IRotaRepository, RotaRepository>();
            services.AddScoped<IViagemRepository, ViagemRepository>();
            services.AddScoped<IItinerarioRepository, ItinerarioRepository>();
            services.AddScoped<IItemAdicionalRepository, ItemAdicionalRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<UBusContext>();
        }
    }
}