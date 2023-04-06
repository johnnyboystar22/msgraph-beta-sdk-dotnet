using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device type.</summary>
    public enum DeviceType {
        /// <summary>Desktop.</summary>
        [EnumMember(Value = "desktop")]
        Desktop,
        /// <summary>WindowsRT.</summary>
        [EnumMember(Value = "windowsRT")]
        WindowsRT,
        /// <summary>WinMO6.</summary>
        [EnumMember(Value = "winMO6")]
        WinMO6,
        /// <summary>Nokia.</summary>
        [EnumMember(Value = "nokia")]
        Nokia,
        /// <summary>Windows phone.</summary>
        [EnumMember(Value = "windowsPhone")]
        WindowsPhone,
        /// <summary>Mac.</summary>
        [EnumMember(Value = "mac")]
        Mac,
        /// <summary>WinCE.</summary>
        [EnumMember(Value = "winCE")]
        WinCE,
        /// <summary>WinEmbedded.</summary>
        [EnumMember(Value = "winEmbedded")]
        WinEmbedded,
        /// <summary>iPhone.</summary>
        [EnumMember(Value = "iPhone")]
        IPhone,
        /// <summary>iPad.</summary>
        [EnumMember(Value = "iPad")]
        IPad,
        /// <summary>iPodTouch.</summary>
        [EnumMember(Value = "iPod")]
        IPod,
        /// <summary>Android.</summary>
        [EnumMember(Value = "android")]
        Android,
        /// <summary>iSocConsumer.</summary>
        [EnumMember(Value = "iSocConsumer")]
        ISocConsumer,
        /// <summary>Unix.</summary>
        [EnumMember(Value = "unix")]
        Unix,
        /// <summary>Mac OS X client using built in MDM agent.</summary>
        [EnumMember(Value = "macMDM")]
        MacMDM,
        /// <summary>Representing the fancy Windows 10 goggles.</summary>
        [EnumMember(Value = "holoLens")]
        HoloLens,
        /// <summary>Surface HUB device.</summary>
        [EnumMember(Value = "surfaceHub")]
        SurfaceHub,
        /// <summary>Android for work device.</summary>
        [EnumMember(Value = "androidForWork")]
        AndroidForWork,
        /// <summary>Android enterprise device.</summary>
        [EnumMember(Value = "androidEnterprise")]
        AndroidEnterprise,
        /// <summary>Windows 10x device.</summary>
        [EnumMember(Value = "windows10x")]
        Windows10x,
        /// <summary>Android non Google managed device.</summary>
        [EnumMember(Value = "androidnGMS")]
        AndroidnGMS,
        /// <summary>ChromeOS device.</summary>
        [EnumMember(Value = "chromeOS")]
        ChromeOS,
        /// <summary>Linux device.</summary>
        [EnumMember(Value = "linux")]
        Linux,
        /// <summary>Blackberry.</summary>
        [EnumMember(Value = "blackberry")]
        Blackberry,
        /// <summary>Palm.</summary>
        [EnumMember(Value = "palm")]
        Palm,
        /// <summary>Represents that the device type is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Cloud PC device.</summary>
        [EnumMember(Value = "cloudPC")]
        CloudPC,
    }
}
