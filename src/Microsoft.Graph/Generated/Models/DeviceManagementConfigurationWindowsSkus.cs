using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DeviceManagementConfigurationWindowsSkus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "windowsHome")]
        WindowsHome,
        [EnumMember(Value = "windowsProfessional")]
        WindowsProfessional,
        [EnumMember(Value = "windowsEnterprise")]
        WindowsEnterprise,
        [EnumMember(Value = "windowsEducation")]
        WindowsEducation,
        [EnumMember(Value = "windowsMobile")]
        WindowsMobile,
        [EnumMember(Value = "windowsMobileEnterprise")]
        WindowsMobileEnterprise,
        [EnumMember(Value = "windowsTeamSurface")]
        WindowsTeamSurface,
        [EnumMember(Value = "iot")]
        Iot,
        [EnumMember(Value = "iotEnterprise")]
        IotEnterprise,
        [EnumMember(Value = "holoLens")]
        HoloLens,
        [EnumMember(Value = "holoLensEnterprise")]
        HoloLensEnterprise,
        [EnumMember(Value = "holographicForBusiness")]
        HolographicForBusiness,
        [EnumMember(Value = "windowsMultiSession")]
        WindowsMultiSession,
        [EnumMember(Value = "surfaceHub")]
        SurfaceHub,
    }
}
