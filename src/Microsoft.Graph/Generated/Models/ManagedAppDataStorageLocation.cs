using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Storage locations where managed apps can potentially store their data</summary>
    public enum ManagedAppDataStorageLocation {
        /// <summary>OneDrive for business</summary>
        [EnumMember(Value = "oneDriveForBusiness")]
        OneDriveForBusiness,
        /// <summary>SharePoint</summary>
        [EnumMember(Value = "sharePoint")]
        SharePoint,
        /// <summary>Box</summary>
        [EnumMember(Value = "box")]
        Box,
        /// <summary>Local storage on the device</summary>
        [EnumMember(Value = "localStorage")]
        LocalStorage,
        /// <summary>The device&apos;s photo library</summary>
        [EnumMember(Value = "photoLibrary")]
        PhotoLibrary,
    }
}
