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
    /// The type MobileAppSupportedDeviceType.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MobileAppSupportedDeviceType>))]
    public partial class MobileAppSupportedDeviceType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppSupportedDeviceType"/> class.
        /// </summary>
        public MobileAppSupportedDeviceType()
        {
            this.ODataType = "microsoft.graph.mobileAppSupportedDeviceType";
        }

        /// <summary>
        /// Gets or sets maximumOperatingSystemVersion.
        /// Maximum OS version
        /// </summary>
        [JsonPropertyName("maximumOperatingSystemVersion")]
        public string MaximumOperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimumOperatingSystemVersion.
        /// Minimum OS version
        /// </summary>
        [JsonPropertyName("minimumOperatingSystemVersion")]
        public string MinimumOperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Device type. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, linux, blackberry, palm, unknown, cloudPC.
        /// </summary>
        [JsonPropertyName("type")]
        public DeviceType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
