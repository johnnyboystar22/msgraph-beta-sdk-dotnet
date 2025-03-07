// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Configures how the requested export job is localized.</summary>
    public enum DeviceManagementExportJobLocalizationType
    {
        /// <summary>Configures the export job to expose localized values as an additional column.</summary>
        [EnumMember(Value = "localizedValuesAsAdditionalColumn")]
        LocalizedValuesAsAdditionalColumn,
        /// <summary>Configures the export job to replace enumerable values with their localized values.</summary>
        [EnumMember(Value = "replaceLocalizableValues")]
        ReplaceLocalizableValues,
    }
}
