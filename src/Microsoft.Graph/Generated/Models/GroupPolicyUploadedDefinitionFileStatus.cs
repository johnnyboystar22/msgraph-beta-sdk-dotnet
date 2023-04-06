using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of Group Policy uploaded definition file status.</summary>
    public enum GroupPolicyUploadedDefinitionFileStatus {
        /// <summary>Group Policy uploaded definition file invalid upload status.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Group Policy uploaded definition file upload in progress.</summary>
        [EnumMember(Value = "uploadInProgress")]
        UploadInProgress,
        /// <summary>Group Policy uploaded definition file available.</summary>
        [EnumMember(Value = "available")]
        Available,
        /// <summary>Group Policy uploaded definition file assigned to policy.</summary>
        [EnumMember(Value = "assigned")]
        Assigned,
        /// <summary>Group Policy uploaded definition file removal in progress.</summary>
        [EnumMember(Value = "removalInProgress")]
        RemovalInProgress,
        /// <summary>Group Policy uploaded definition file upload failed.</summary>
        [EnumMember(Value = "uploadFailed")]
        UploadFailed,
        /// <summary>Group Policy uploaded definition file removal failed.</summary>
        [EnumMember(Value = "removalFailed")]
        RemovalFailed,
    }
}
