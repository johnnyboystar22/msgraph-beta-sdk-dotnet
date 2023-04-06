using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Delivery state of Configuration Manager device action</summary>
    public enum ConfigurationManagerActionDeliveryStatus {
        /// <summary>Pending to deliver the action to ConfigurationManager</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Pending to deliver the action to ConfigurationManager</summary>
        [EnumMember(Value = "pendingDelivery")]
        PendingDelivery,
        /// <summary>Action is sent to ConfigurationManager Connector service (cloud)</summary>
        [EnumMember(Value = "deliveredToConnectorService")]
        DeliveredToConnectorService,
        /// <summary>Failed to send the action to ConfigurationManager Connector service (cloud)</summary>
        [EnumMember(Value = "failedToDeliverToConnectorService")]
        FailedToDeliverToConnectorService,
        /// <summary>Action is delivered to ConfigurationManager on-prem server</summary>
        [EnumMember(Value = "deliveredToOnPremisesServer")]
        DeliveredToOnPremisesServer,
    }
}
