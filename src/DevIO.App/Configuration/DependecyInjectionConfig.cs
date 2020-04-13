using DevIO.App.Extensions;
using DevIO.Business.Interfaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Validations;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DevIO.App.Configuration
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeProvider>();
            services.AddScoped<IProdutoService, IProdutoService>();
            services.AddScoped<IFornecedorService, IFornecedorService>();
            services.AddScoped<INotificador, Notificador>();
            return services;
        }
    }
}

