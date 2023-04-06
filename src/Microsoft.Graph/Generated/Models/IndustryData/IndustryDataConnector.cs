using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class IndustryDataConnector : Entity, IParsable {
        /// <summary>The name of the data connector. Maximum supported length is 100 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The sourceSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SourceSystemDefinition? SourceSystem {
            get { return BackingStore?.Get<SourceSystemDefinition?>("sourceSystem"); }
            set { BackingStore?.Set("sourceSystem", value); }
        }
#nullable restore
#else
        public SourceSystemDefinition SourceSystem {
            get { return BackingStore?.Get<SourceSystemDefinition>("sourceSystem"); }
            set { BackingStore?.Set("sourceSystem", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IndustryDataConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.industryData.azureDataLakeConnector" => new AzureDataLakeConnector(),
                "#microsoft.graph.industryData.fileDataConnector" => new FileDataConnector(),
                _ => new IndustryDataConnector(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"sourceSystem", n => { SourceSystem = n.GetObjectValue<SourceSystemDefinition>(SourceSystemDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<SourceSystemDefinition>("sourceSystem", SourceSystem);
        }
    }
}
