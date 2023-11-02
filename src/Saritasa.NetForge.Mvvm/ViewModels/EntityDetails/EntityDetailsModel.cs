﻿using Saritasa.NetForge.Domain.Entities.Metadata;

namespace Saritasa.NetForge.Mvvm.ViewModels.EntityDetails;

/// <summary>
/// Entity details model.
/// </summary>
public class EntityDetailsModel
{
    /// <inheritdoc cref="EntityMetadata.Id"/>
    public Guid Id { get; set; }

    /// <inheritdoc cref="EntityMetadata.Name"/>
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.PluralName"/>
    public string PluralName { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.Description"/>
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.ClrType"/>
    public Type? ClrType { get; set; }

    /// <inheritdoc cref="EntityMetadata.Properties"/>
    public ICollection<PropertyMetadata> Properties { get; set; } = new List<PropertyMetadata>();
    public Func<object?, IQueryable<object>, string, IQueryable<object>> SearchFunction { get; set; }
}
