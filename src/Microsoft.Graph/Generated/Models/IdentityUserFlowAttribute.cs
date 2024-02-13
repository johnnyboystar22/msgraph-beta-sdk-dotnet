// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class IdentityUserFlowAttribute : Entity, IParsable {
        /// <summary>The dataType property</summary>
        public IdentityUserFlowAttributeDataType? DataType {
            get { return BackingStore?.Get<IdentityUserFlowAttributeDataType?>("dataType"); }
            set { BackingStore?.Set("dataType", value); }
        }
        /// <summary>The description of the user flow attribute that&apos;s shown to the user at the time of sign-up.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the user flow attribute.  Supports $filter (eq, ne).</summary>
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
        /// <summary>The userFlowAttributeType property</summary>
        public IdentityUserFlowAttributeType? UserFlowAttributeType {
            get { return BackingStore?.Get<IdentityUserFlowAttributeType?>("userFlowAttributeType"); }
            set { BackingStore?.Set("userFlowAttributeType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IdentityUserFlowAttribute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IdentityUserFlowAttribute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.identityBuiltInUserFlowAttribute" => new IdentityBuiltInUserFlowAttribute(),
                "#microsoft.graph.identityCustomUserFlowAttribute" => new IdentityCustomUserFlowAttribute(),
                _ => new IdentityUserFlowAttribute(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataType", n => { DataType = n.GetEnumValue<IdentityUserFlowAttributeDataType>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"userFlowAttributeType", n => { UserFlowAttributeType = n.GetEnumValue<IdentityUserFlowAttributeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<IdentityUserFlowAttributeDataType>("dataType", DataType);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<IdentityUserFlowAttributeType>("userFlowAttributeType", UserFlowAttributeType);
        }
    }
}
