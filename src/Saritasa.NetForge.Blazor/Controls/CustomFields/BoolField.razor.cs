﻿using Microsoft.AspNetCore.Components;
using Saritasa.NetForge.UseCases.Metadata.GetEntityById;

namespace Saritasa.NetForge.Blazor.Controls.CustomFields;

/// <summary>
/// Represents bool field.
/// </summary>
public partial class BoolField
{
    /// <summary>
    /// Property name.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public PropertyMetadataDto Property { get; init; } = null!;

    /// <summary>
    /// Entity instance that contains property value for this field.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public object EntityInstance { get; init; } = null!;

    /// <summary>
    /// Is field with read only access.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public bool IsReadOnly { get; init; }

    /// <summary>
    /// Property value.
    /// </summary>
    public bool? PropertyValue
    {
        get => (bool?)EntityInstance.GetType().GetProperty(Property.Name)?.GetValue(EntityInstance);
        set => EntityInstance.GetType().GetProperty(Property.Name)?.SetValue(EntityInstance, value);
    }
}
