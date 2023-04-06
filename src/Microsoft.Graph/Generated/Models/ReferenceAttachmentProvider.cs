using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ReferenceAttachmentProvider {
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "oneDriveBusiness")]
        OneDriveBusiness,
        [EnumMember(Value = "oneDriveConsumer")]
        OneDriveConsumer,
        [EnumMember(Value = "dropbox")]
        Dropbox,
    }
}
