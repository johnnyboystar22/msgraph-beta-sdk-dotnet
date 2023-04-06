using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of Group Policy operation.</summary>
    public enum GroupPolicyOperationType {
        /// <summary>Group Policy invalid operation type.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Group Policy upload operation type.</summary>
        [EnumMember(Value = "upload")]
        Upload,
        /// <summary>Group Policy upload new version operation type.</summary>
        [EnumMember(Value = "uploadNewVersion")]
        UploadNewVersion,
        /// <summary>Group Policy add new language(ADML) files operation type.</summary>
        [EnumMember(Value = "addLanguageFiles")]
        AddLanguageFiles,
        /// <summary>Group Policy remove language(ADML) files operation type.</summary>
        [EnumMember(Value = "removeLanguageFiles")]
        RemoveLanguageFiles,
        /// <summary>Group Policy update language(ADML) files operation type.</summary>
        [EnumMember(Value = "updateLanguageFiles")]
        UpdateLanguageFiles,
        /// <summary>Group Policy remove uploaded file operation type.</summary>
        [EnumMember(Value = "remove")]
        Remove,
    }
}
