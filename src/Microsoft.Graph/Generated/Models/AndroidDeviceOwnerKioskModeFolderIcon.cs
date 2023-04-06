using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner Kiosk Mode folder icon type.</summary>
    public enum AndroidDeviceOwnerKioskModeFolderIcon {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Folder icon appears as dark square.</summary>
        [EnumMember(Value = "darkSquare")]
        DarkSquare,
        /// <summary>Folder icon appears as dark circle.</summary>
        [EnumMember(Value = "darkCircle")]
        DarkCircle,
        /// <summary>Folder icon appears as light square.</summary>
        [EnumMember(Value = "lightSquare")]
        LightSquare,
        /// <summary>Folder icon appears as light circle  .</summary>
        [EnumMember(Value = "lightCircle")]
        LightCircle,
    }
}
