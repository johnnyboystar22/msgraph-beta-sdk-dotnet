// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Teams Device Usage User Detail.
    /// </summary>
    public partial class TeamsDeviceUsageUserDetail : Entity
    {
    
		///<summary>
		/// The TeamsDeviceUsageUserDetail constructor
		///</summary>
        public TeamsDeviceUsageUserDetail()
        {
            this.ODataType = "microsoft.graph.teamsDeviceUsageUserDetail";
        }
	
        /// <summary>
        /// Gets or sets deleted date.
        /// The date when the delete operation happened. Default value is 'null' when the user has not been deleted.
        /// </summary>
        [JsonPropertyName("deletedDate")]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// Whether this user has been deleted or soft deleted.
        /// </summary>
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets is licensed.
        /// Whether the user has been assigned a Teams license.
        /// </summary>
        [JsonPropertyName("isLicensed")]
        public bool? IsLicensed { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// The last date that the user participated in a Microsoft Teams activity.
        /// </summary>
        [JsonPropertyName("lastActivityDate")]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// The number of days the report covers.
        /// </summary>
        [JsonPropertyName("reportPeriod")]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// The latest date of the content.
        /// </summary>
        [JsonPropertyName("reportRefreshDate")]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets used android phone.
        /// Whether the user was active on the Teams mobile client for Android.
        /// </summary>
        [JsonPropertyName("usedAndroidPhone")]
        public bool? UsedAndroidPhone { get; set; }
    
        /// <summary>
        /// Gets or sets used chrome os.
        /// Whether the user was active in the Teams desktop client on a ChromeOS computer.
        /// </summary>
        [JsonPropertyName("usedChromeOS")]
        public bool? UsedChromeOS { get; set; }
    
        /// <summary>
        /// Gets or sets usedi os.
        /// Whether the user was active on the Teams mobile client for iOS.
        /// </summary>
        [JsonPropertyName("usediOS")]
        public bool? UsediOS { get; set; }
    
        /// <summary>
        /// Gets or sets used linux.
        /// Whether the user was active in the Teams desktop client on a Linux computer.
        /// </summary>
        [JsonPropertyName("usedLinux")]
        public bool? UsedLinux { get; set; }
    
        /// <summary>
        /// Gets or sets used mac.
        /// Whether the user was active in the Teams desktop client on a macOS computer.
        /// </summary>
        [JsonPropertyName("usedMac")]
        public bool? UsedMac { get; set; }
    
        /// <summary>
        /// Gets or sets used web.
        /// Whether the user was active in the Teams web client on devices.
        /// </summary>
        [JsonPropertyName("usedWeb")]
        public bool? UsedWeb { get; set; }
    
        /// <summary>
        /// Gets or sets used windows.
        /// Whether the user was active in the Teams desktop client on a Windows-based computer.
        /// </summary>
        [JsonPropertyName("usedWindows")]
        public bool? UsedWindows { get; set; }
    
        /// <summary>
        /// Gets or sets used windows phone.
        /// Whether the user was active on the Teams mobile client for Windows phone.
        /// </summary>
        [JsonPropertyName("usedWindowsPhone")]
        public bool? UsedWindowsPhone { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant’s collection of verified domains. This property is required when a user is created.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

