﻿using Saritasa.NetForge.Domain.Entities.Metadata;
using Saritasa.NetForge.Domain.Enums;

namespace Saritasa.NetForge.Infrastructure.Abstractions.Interfaces;

/// <summary>
/// Service for retrieving data from ORM.
/// </summary>
public interface IOrmDataService
{
    /// <summary>
    /// Get query of entity with specified type.
    /// </summary>
    /// <param name="clrType">CLR type.</param>
    /// <returns>Entity data.</returns>
    IQueryable<object> GetQuery(Type clrType);

    /// <summary>
    /// Get instance by primary key value.
    /// </summary>
    /// <param name="primaryKey">
    /// Primary key values.
    /// In case of composite primary key, they have to be separated by "--".
    /// </param>
    /// <param name="entityType">Type to get instance of.</param>
    /// <returns>Instance.</returns>
    Task<object> GetInstanceAsync(string primaryKey, Type entityType);

    /// <summary>
    /// Performs search.
    /// </summary>
    /// <param name="query">Query to search.</param>
    /// <param name="searchString">Search string.</param>
    /// <param name="entityType">Entity type.</param>
    /// <param name="properties">Properties.</param>
    /// <returns>Query with searched data.</returns>
    IQueryable<object> Search(
        IQueryable<object> query,
        string searchString,
        Type entityType,
        IEnumerable<(string Name, SearchType SearchType)> properties);

    /// <summary>
    /// Adds entity to the database.
    /// </summary>
    /// <param name="entity">Entity to add.</param>
    /// <param name="entityType">Entity type.</param>
    /// <param name="cancellationToken">Token to cancel the operation.</param>
    Task AddAsync(object entity, Type entityType, CancellationToken cancellationToken);

    /// <summary>
    /// Updates entity in the database.
    /// </summary>
    /// <param name="entity">Entity to update.</param>
    /// <param name="cancellationToken">Token to cancel the operation.</param>
    Task UpdateAsync(object entity, CancellationToken cancellationToken);
}
