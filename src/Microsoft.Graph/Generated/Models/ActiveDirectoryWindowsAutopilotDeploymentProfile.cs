using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ActiveDirectoryWindowsAutopilotDeploymentProfile : WindowsAutopilotDeploymentProfile, IParsable {
        /// <summary>Configuration to join Active Directory domain</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsDomainJoinConfiguration? DomainJoinConfiguration {
            get { return BackingStore?.Get<WindowsDomainJoinConfiguration?>("domainJoinConfiguration"); }
            set { BackingStore?.Set("domainJoinConfiguration", value); }
        }
#nullable restore
#else
        public WindowsDomainJoinConfiguration DomainJoinConfiguration {
            get { return BackingStore?.Get<WindowsDomainJoinConfiguration>("domainJoinConfiguration"); }
            set { BackingStore?.Set("domainJoinConfiguration", value); }
        }
#endif
        /// <summary>The Autopilot Hybrid Azure AD join flow will continue even if it does not establish domain controller connectivity during OOBE.</summary>
        public bool? HybridAzureADJoinSkipConnectivityCheck {
            get { return BackingStore?.Get<bool?>("hybridAzureADJoinSkipConnectivityCheck"); }
            set { BackingStore?.Set("hybridAzureADJoinSkipConnectivityCheck", value); }
        }
        /// <summary>
        /// Instantiates a new ActiveDirectoryWindowsAutopilotDeploymentProfile and sets the default values.
        /// </summary>
        public ActiveDirectoryWindowsAutopilotDeploymentProfile() : base() {
            OdataType = "#microsoft.graph.activeDirectoryWindowsAutopilotDeploymentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ActiveDirectoryWindowsAutopilotDeploymentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActiveDirectoryWindowsAutopilotDeploymentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"domainJoinConfiguration", n => { DomainJoinConfiguration = n.GetObjectValue<WindowsDomainJoinConfiguration>(WindowsDomainJoinConfiguration.CreateFromDiscriminatorValue); } },
                {"hybridAzureADJoinSkipConnectivityCheck", n => { HybridAzureADJoinSkipConnectivityCheck = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WindowsDomainJoinConfiguration>("domainJoinConfiguration", DomainJoinConfiguration);
            writer.WriteBoolValue("hybridAzureADJoinSkipConnectivityCheck", HybridAzureADJoinSkipConnectivityCheck);
        }
    }
}
