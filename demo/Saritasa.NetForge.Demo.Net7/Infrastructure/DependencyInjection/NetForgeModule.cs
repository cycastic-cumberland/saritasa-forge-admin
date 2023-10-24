﻿using Saritasa.NetForge.Blazor.Extensions;
using Saritasa.NetForge.Demo.Net7.Models;
using Saritasa.NetForge.Infrastructure.EfCore.Extensions;

namespace Saritasa.NetForge.Demo.Net7.Infrastructure.DependencyInjection;

/// <summary>
/// Register NetForge admin panel as dependency.
/// </summary>
internal class NetForgeModule
{
    /// <summary>
    /// Register dependencies.
    /// </summary>
    public static void Register(IServiceCollection services)
    {
        services.AddNetForge(optionsBuilder =>
        {
            optionsBuilder.UseEntityFramework(efOptionsBuilder =>
            {
                efOptionsBuilder.UseDbContext<ShopDbContext>();
            });
            optionsBuilder.ConfigureEntity<Shop>(entityOptionsBuilder =>
            {
                entityOptionsBuilder.SetDescription("The base Shop entity.");
            });
            optionsBuilder.ConfigureEntity<ProductTag>(entityOptionsBuilder =>
            {
                entityOptionsBuilder.SetIsHidden(true);
            });
        });
    }
}