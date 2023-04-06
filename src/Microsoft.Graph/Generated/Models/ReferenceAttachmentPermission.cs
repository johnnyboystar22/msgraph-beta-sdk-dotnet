using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ReferenceAttachmentPermission {
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "edit")]
        Edit,
        [EnumMember(Value = "anonymousView")]
        AnonymousView,
        [EnumMember(Value = "anonymousEdit")]
        AnonymousEdit,
        [EnumMember(Value = "organizationView")]
        OrganizationView,
        [EnumMember(Value = "organizationEdit")]
        OrganizationEdit,
    }
}
