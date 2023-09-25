﻿using Saritasa.NetForge.DomainServices;

namespace Saritasa.NetForge.Infrastructure.EfCore.Extensions;

/// <summary>
/// Provides extension methods to configure the admin panel with EF Core.
/// </summary>
public static class AdminExtensions
{
    /// <summary>
    /// Adds the EF Core handling.
    /// </summary>
    /// <param name="optionsBuilder">Admin panel options builder.</param>
    /// <param name="efCoreOptionsBuilderAction">Action to configure the EF Core options.</param>
    public static AdminOptionsBuilder UseEntityFramework(this AdminOptionsBuilder optionsBuilder,
        Action<EfCoreOptionsBuilder>? efCoreOptionsBuilderAction = null)
    {
        var efCoreOptionsBuilder = new EfCoreOptionsBuilder();
        efCoreOptionsBuilderAction?.Invoke(efCoreOptionsBuilder);
        optionsBuilder.OrmOptionsBuilder = efCoreOptionsBuilder;
        return optionsBuilder;
    }
}
