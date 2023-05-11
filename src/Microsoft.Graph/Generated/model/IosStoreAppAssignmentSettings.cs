// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type IosStoreAppAssignmentSettings.
    /// </summary>
    public partial class IosStoreAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosStoreAppAssignmentSettings"/> class.
        /// </summary>
        public IosStoreAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.iosStoreAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets isRemovable.
        /// When TRUE, indicates that the app can be uninstalled by the user. When FALSE, indicates that the app cannot be uninstalled by the user. By default, this property is set to null which internally is treated as TRUE.
        /// </summary>
        [JsonPropertyName("isRemovable")]
        public bool? IsRemovable { get; set; }
    
        /// <summary>
        /// Gets or sets preventManagedAppBackup.
        /// When TRUE, indicates that the app should not be backed up to iCloud. When FALSE, indicates that the app may be backed up to iCloud. By default, this property is set to null which internally is treated as FALSE.
        /// </summary>
        [JsonPropertyName("preventManagedAppBackup")]
        public bool? PreventManagedAppBackup { get; set; }
    
        /// <summary>
        /// Gets or sets uninstallOnDeviceRemoval.
        /// Whether or not to uninstall the app when device is removed from Intune.
        /// </summary>
        [JsonPropertyName("uninstallOnDeviceRemoval")]
        public bool? UninstallOnDeviceRemoval { get; set; }
    
        /// <summary>
        /// Gets or sets vpnConfigurationId.
        /// The VPN Configuration Id to apply for this app.
        /// </summary>
        [JsonPropertyName("vpnConfigurationId")]
        public string VpnConfigurationId { get; set; }
    
    }
}
