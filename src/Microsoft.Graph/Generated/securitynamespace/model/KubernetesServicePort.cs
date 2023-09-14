// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type KubernetesServicePort.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<KubernetesServicePort>))]
    public partial class KubernetesServicePort
    {

        /// <summary>
        /// Gets or sets appProtocol.
        /// The application protocol for this port.
        /// </summary>
        [JsonPropertyName("appProtocol")]
        public string AppProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of this port within the service.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets nodePort.
        /// The port on each node on which this service is exposed when the type is either NodePort or LoadBalancer.
        /// </summary>
        [JsonPropertyName("nodePort")]
        public Int32? NodePort { get; set; }
    
        /// <summary>
        /// Gets or sets port.
        /// The port that this service exposes.
        /// </summary>
        [JsonPropertyName("port")]
        public Int32? Port { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// The protocol name. Possible values are: udp, tcp, sctp, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("protocol")]
        public ContainerPortProtocol? Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets targetPort.
        /// The name or number of the port to access on the pods targeted by the service. The port number must be in the range 1 to 65535. The name must be an IANA_SVC_NAME.
        /// </summary>
        [JsonPropertyName("targetPort")]
        public string TargetPort { get; set; }
    
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
