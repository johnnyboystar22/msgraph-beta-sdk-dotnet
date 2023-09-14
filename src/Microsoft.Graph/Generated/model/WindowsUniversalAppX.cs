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
    /// The type Windows Universal App X.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsUniversalAppX>))]
    public partial class WindowsUniversalAppX : MobileLobApp
    {
    
        ///<summary>
        /// The WindowsUniversalAppX constructor
        ///</summary>
        public WindowsUniversalAppX()
        {
            this.ODataType = "microsoft.graph.windowsUniversalAppX";
        }

        /// <summary>
        /// Gets or sets applicable architectures.
        /// The Windows architecture(s) for which this app can run on. Possible values are: none, x86, x64, arm, neutral; default value is none. Possible values are: none, x86, x64, arm, neutral, arm64.
        /// </summary>
        [JsonPropertyName("applicableArchitectures")]
        public WindowsArchitecture? ApplicableArchitectures { get; set; }
    
        /// <summary>
        /// Gets or sets applicable device types.
        /// The Windows device type(s) for which this app can run on. Possible values are: none, desktop, mobile, holographic, team; default value is none. Possible values are: none, desktop, mobile, holographic, team, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("applicableDeviceTypes")]
        public WindowsDeviceType? ApplicableDeviceTypes { get; set; }
    
        /// <summary>
        /// Gets or sets identity name.
        /// The Identity Name of the app, parsed from the appx file when it is uploaded through the Intune MEM console. For example: 'Contoso.DemoApp'.
        /// </summary>
        [JsonPropertyName("identityName")]
        public string IdentityName { get; set; }
    
        /// <summary>
        /// Gets or sets identity publisher hash.
        /// The Identity Publisher Hash of the app, parsed from the appx file when it is uploaded through the Intune MEM console. For example: 'AB82CD0XYZ'.
        /// </summary>
        [JsonPropertyName("identityPublisherHash")]
        public string IdentityPublisherHash { get; set; }
    
        /// <summary>
        /// Gets or sets identity resource identifier.
        /// The Identity Resource Identifier of the app, parsed from the appx file when it is uploaded through the Intune MEM console. For example: 'TestResourceId'.
        /// </summary>
        [JsonPropertyName("identityResourceIdentifier")]
        public string IdentityResourceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets identity version.
        /// The Identity Version of the app, parsed from the appx file when it is uploaded through the Intune MEM console.  For example: '1.0.0.0'.
        /// </summary>
        [JsonPropertyName("identityVersion")]
        public string IdentityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets is bundle.
        /// Whether or not the app is a bundle. If TRUE, app is a bundle; if FALSE, app is not a bundle.
        /// </summary>
        [JsonPropertyName("isBundle")]
        public bool? IsBundle { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable Windows operating system.
        /// </summary>
        [JsonPropertyName("minimumSupportedOperatingSystem")]
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets committed contained apps.
        /// The collection of contained apps in the committed mobileAppContent of a windowsUniversalAppX app.
        /// </summary>
        [JsonPropertyName("committedContainedApps")]
        public IWindowsUniversalAppXCommittedContainedAppsCollectionPage CommittedContainedApps { get; set; }

        /// <summary>
        /// Gets or sets committedContainedAppsNextLink.
        /// </summary>
        [JsonPropertyName("committedContainedApps@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CommittedContainedAppsNextLink { get; set; }
    
    }
}

