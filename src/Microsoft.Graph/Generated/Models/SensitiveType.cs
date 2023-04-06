using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SensitiveType : Entity, IParsable {
        /// <summary>The classificationMethod property</summary>
        public Microsoft.Graph.Beta.Models.ClassificationMethod? ClassificationMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClassificationMethod?>("classificationMethod"); }
            set { BackingStore?.Set("classificationMethod", value); }
        }
        /// <summary>The description property</summary>
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
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The publisherName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherName {
            get { return BackingStore?.Get<string?>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
#nullable restore
#else
        public string PublisherName {
            get { return BackingStore?.Get<string>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
#endif
        /// <summary>The rulePackageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RulePackageId {
            get { return BackingStore?.Get<string?>("rulePackageId"); }
            set { BackingStore?.Set("rulePackageId", value); }
        }
#nullable restore
#else
        public string RulePackageId {
            get { return BackingStore?.Get<string>("rulePackageId"); }
            set { BackingStore?.Set("rulePackageId", value); }
        }
#endif
        /// <summary>The rulePackageType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RulePackageType {
            get { return BackingStore?.Get<string?>("rulePackageType"); }
            set { BackingStore?.Set("rulePackageType", value); }
        }
#nullable restore
#else
        public string RulePackageType {
            get { return BackingStore?.Get<string>("rulePackageType"); }
            set { BackingStore?.Set("rulePackageType", value); }
        }
#endif
        /// <summary>The scope property</summary>
        public SensitiveTypeScope? Scope {
            get { return BackingStore?.Get<SensitiveTypeScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>The sensitiveTypeSource property</summary>
        public Microsoft.Graph.Beta.Models.SensitiveTypeSource? SensitiveTypeSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SensitiveTypeSource?>("sensitiveTypeSource"); }
            set { BackingStore?.Set("sensitiveTypeSource", value); }
        }
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SensitiveType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classificationMethod", n => { ClassificationMethod = n.GetEnumValue<ClassificationMethod>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"publisherName", n => { PublisherName = n.GetStringValue(); } },
                {"rulePackageId", n => { RulePackageId = n.GetStringValue(); } },
                {"rulePackageType", n => { RulePackageType = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeSource", n => { SensitiveTypeSource = n.GetEnumValue<SensitiveTypeSource>(); } },
                {"state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ClassificationMethod>("classificationMethod", ClassificationMethod);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("rulePackageId", RulePackageId);
            writer.WriteStringValue("rulePackageType", RulePackageType);
            writer.WriteEnumValue<SensitiveTypeScope>("scope", Scope);
            writer.WriteEnumValue<SensitiveTypeSource>("sensitiveTypeSource", SensitiveTypeSource);
            writer.WriteStringValue("state", State);
        }
    }
}
