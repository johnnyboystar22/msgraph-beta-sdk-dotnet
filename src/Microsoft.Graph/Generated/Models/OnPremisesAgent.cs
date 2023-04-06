using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesAgent : Entity, IParsable {
        /// <summary>List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesAgentGroup>? AgentGroups {
            get { return BackingStore?.Get<List<OnPremisesAgentGroup>?>("agentGroups"); }
            set { BackingStore?.Set("agentGroups", value); }
        }
#nullable restore
#else
        public List<OnPremisesAgentGroup> AgentGroups {
            get { return BackingStore?.Get<List<OnPremisesAgentGroup>>("agentGroups"); }
            set { BackingStore?.Set("agentGroups", value); }
        }
#endif
        /// <summary>The external IP address as detected by the service for the agent machine. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalIp {
            get { return BackingStore?.Get<string?>("externalIp"); }
            set { BackingStore?.Set("externalIp", value); }
        }
#nullable restore
#else
        public string ExternalIp {
            get { return BackingStore?.Get<string>("externalIp"); }
            set { BackingStore?.Set("externalIp", value); }
        }
#endif
        /// <summary>The name of the machine that the aggent is running on. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MachineName {
            get { return BackingStore?.Get<string?>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#nullable restore
#else
        public string MachineName {
            get { return BackingStore?.Get<string>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#endif
        /// <summary>The status property</summary>
        public AgentStatus? Status {
            get { return BackingStore?.Get<AgentStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The supportedPublishingTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesPublishingType?>? SupportedPublishingTypes {
            get { return BackingStore?.Get<List<OnPremisesPublishingType?>?>("supportedPublishingTypes"); }
            set { BackingStore?.Set("supportedPublishingTypes", value); }
        }
#nullable restore
#else
        public List<OnPremisesPublishingType?> SupportedPublishingTypes {
            get { return BackingStore?.Get<List<OnPremisesPublishingType?>>("supportedPublishingTypes"); }
            set { BackingStore?.Set("supportedPublishingTypes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnPremisesAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentGroups", n => { AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>(OnPremisesAgentGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalIp", n => { ExternalIp = n.GetStringValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AgentStatus>(); } },
                {"supportedPublishingTypes", n => { SupportedPublishingTypes = n.GetCollectionOfEnumValues<OnPremisesPublishingType>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnPremisesAgentGroup>("agentGroups", AgentGroups);
            writer.WriteStringValue("externalIp", ExternalIp);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteEnumValue<AgentStatus>("status", Status);
            writer.WriteCollectionOfEnumValues<OnPremisesPublishingType>("supportedPublishingTypes", SupportedPublishingTypes);
        }
    }
}
