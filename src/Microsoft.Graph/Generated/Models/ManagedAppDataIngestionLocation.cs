using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Locations which can be used to bring data into organization documents</summary>
    public enum ManagedAppDataIngestionLocation {
        /// <summary>OneDrive for business</summary>
        [EnumMember(Value = "oneDriveForBusiness")]
        OneDriveForBusiness,
        /// <summary>SharePoint Online</summary>
        [EnumMember(Value = "sharePoint")]
        SharePoint,
        /// <summary>The device&apos;s camera</summary>
        [EnumMember(Value = "camera")]
        Camera,
        /// <summary>The device&apos;s photo library</summary>
        [EnumMember(Value = "photoLibrary")]
        PhotoLibrary,
    }
}
