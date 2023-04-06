using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Web Browser Cookie Settings.</summary>
    public enum WebBrowserCookieSettings {
        /// <summary>Browser default value, no intent.</summary>
        [EnumMember(Value = "browserDefault")]
        BrowserDefault,
        /// <summary>Always block cookies.</summary>
        [EnumMember(Value = "blockAlways")]
        BlockAlways,
        /// <summary>Allow cookies from current Web site.</summary>
        [EnumMember(Value = "allowCurrentWebSite")]
        AllowCurrentWebSite,
        /// <summary>Allow Cookies from websites visited.</summary>
        [EnumMember(Value = "allowFromWebsitesVisited")]
        AllowFromWebsitesVisited,
        /// <summary>Always allow cookies.</summary>
        [EnumMember(Value = "allowAlways")]
        AllowAlways,
    }
}
