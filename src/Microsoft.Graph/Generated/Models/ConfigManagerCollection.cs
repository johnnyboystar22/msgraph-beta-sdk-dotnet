using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A ConfigManager defined collection of devices or users.
    /// </summary>
    public class ConfigManagerCollection : Entity, IParsable {
        /// <summary>The collection identifier in SCCM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CollectionIdentifier {
            get { return BackingStore?.Get<string?>("collectionIdentifier"); }
            set { BackingStore?.Set("collectionIdentifier", value); }
        }
#nullable restore
#else
        public string CollectionIdentifier {
            get { return BackingStore?.Get<string>("collectionIdentifier"); }
            set { BackingStore?.Set("collectionIdentifier", value); }
        }
#endif
        /// <summary>The created date.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The DisplayName.</summary>
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
        /// <summary>The Hierarchy Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HierarchyIdentifier {
            get { return BackingStore?.Get<string?>("hierarchyIdentifier"); }
            set { BackingStore?.Set("hierarchyIdentifier", value); }
        }
#nullable restore
#else
        public string HierarchyIdentifier {
            get { return BackingStore?.Get<string>("hierarchyIdentifier"); }
            set { BackingStore?.Set("hierarchyIdentifier", value); }
        }
#endif
        /// <summary>The HierarchyName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HierarchyName {
            get { return BackingStore?.Get<string?>("hierarchyName"); }
            set { BackingStore?.Set("hierarchyName", value); }
        }
#nullable restore
#else
        public string HierarchyName {
            get { return BackingStore?.Get<string>("hierarchyName"); }
            set { BackingStore?.Set("hierarchyName", value); }
        }
#endif
        /// <summary>The last modified date.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConfigManagerCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigManagerCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"collectionIdentifier", n => { CollectionIdentifier = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hierarchyIdentifier", n => { HierarchyIdentifier = n.GetStringValue(); } },
                {"hierarchyName", n => { HierarchyName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("collectionIdentifier", CollectionIdentifier);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("hierarchyIdentifier", HierarchyIdentifier);
            writer.WriteStringValue("hierarchyName", HierarchyName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
