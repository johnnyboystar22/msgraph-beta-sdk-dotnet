using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
    /// </summary>
    public class GroupPolicyDefinitionFile : Entity, IParsable {
        /// <summary>The group policy definitions associated with the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupPolicyDefinition>? Definitions {
            get { return BackingStore?.Get<List<GroupPolicyDefinition>?>("definitions"); }
            set { BackingStore?.Set("definitions", value); }
        }
#nullable restore
#else
        public List<GroupPolicyDefinition> Definitions {
            get { return BackingStore?.Get<List<GroupPolicyDefinition>>("definitions"); }
            set { BackingStore?.Set("definitions", value); }
        }
#endif
        /// <summary>The localized description of the policy settings in the ADMX file. The default value is empty.</summary>
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
        /// <summary>The localized friendly name of the ADMX file.</summary>
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
        /// <summary>The file name of the ADMX file without the path. For example: edge.admx</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>The supported language codes for the ADMX file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LanguageCodes {
            get { return BackingStore?.Get<List<string>?>("languageCodes"); }
            set { BackingStore?.Set("languageCodes", value); }
        }
#nullable restore
#else
        public List<string> LanguageCodes {
            get { return BackingStore?.Get<List<string>>("languageCodes"); }
            set { BackingStore?.Set("languageCodes", value); }
        }
#endif
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Type of Group Policy File or Definition.</summary>
        public GroupPolicyType? PolicyType {
            get { return BackingStore?.Get<GroupPolicyType?>("policyType"); }
            set { BackingStore?.Set("policyType", value); }
        }
        /// <summary>The revision version associated with the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Revision {
            get { return BackingStore?.Get<string?>("revision"); }
            set { BackingStore?.Set("revision", value); }
        }
#nullable restore
#else
        public string Revision {
            get { return BackingStore?.Get<string>("revision"); }
            set { BackingStore?.Set("revision", value); }
        }
#endif
        /// <summary>Specifies the URI used to identify the namespace within the ADMX file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetNamespace {
            get { return BackingStore?.Get<string?>("targetNamespace"); }
            set { BackingStore?.Set("targetNamespace", value); }
        }
#nullable restore
#else
        public string TargetNamespace {
            get { return BackingStore?.Get<string>("targetNamespace"); }
            set { BackingStore?.Set("targetNamespace", value); }
        }
#endif
        /// <summary>Specifies the logical name that refers to the namespace within the ADMX file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetPrefix {
            get { return BackingStore?.Get<string?>("targetPrefix"); }
            set { BackingStore?.Set("targetPrefix", value); }
        }
#nullable restore
#else
        public string TargetPrefix {
            get { return BackingStore?.Get<string>("targetPrefix"); }
            set { BackingStore?.Set("targetPrefix", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyDefinitionFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.groupPolicyUploadedDefinitionFile" => new GroupPolicyUploadedDefinitionFile(),
                _ => new GroupPolicyDefinitionFile(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definitions", n => { Definitions = n.GetCollectionOfObjectValues<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"languageCodes", n => { LanguageCodes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<GroupPolicyType>(); } },
                {"revision", n => { Revision = n.GetStringValue(); } },
                {"targetNamespace", n => { TargetNamespace = n.GetStringValue(); } },
                {"targetPrefix", n => { TargetPrefix = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinition>("definitions", Definitions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfPrimitiveValues<string>("languageCodes", LanguageCodes);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<GroupPolicyType>("policyType", PolicyType);
            writer.WriteStringValue("revision", Revision);
            writer.WriteStringValue("targetNamespace", TargetNamespace);
            writer.WriteStringValue("targetPrefix", TargetPrefix);
        }
    }
}
