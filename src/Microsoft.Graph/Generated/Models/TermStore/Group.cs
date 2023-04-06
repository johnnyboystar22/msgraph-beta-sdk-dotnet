using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.TermStore {
    public class Group : Entity, IParsable {
        /// <summary>Date and time of the group creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description that gives details on the term usage.</summary>
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
        /// <summary>Name of the group.</summary>
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
        /// <summary>ID of the parent site of this group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentSiteId {
            get { return BackingStore?.Get<string?>("parentSiteId"); }
            set { BackingStore?.Set("parentSiteId", value); }
        }
#nullable restore
#else
        public string ParentSiteId {
            get { return BackingStore?.Get<string>("parentSiteId"); }
            set { BackingStore?.Set("parentSiteId", value); }
        }
#endif
        /// <summary>Returns the type of the group. Possible values are: global, system, and siteCollection.</summary>
        public TermGroupScope? Scope {
            get { return BackingStore?.Get<TermGroupScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>All sets under the group in a term [store].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Set>? Sets {
            get { return BackingStore?.Get<List<Set>?>("sets"); }
            set { BackingStore?.Set("sets", value); }
        }
#nullable restore
#else
        public List<Set> Sets {
            get { return BackingStore?.Get<List<Set>>("sets"); }
            set { BackingStore?.Set("sets", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Group CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Group();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"parentSiteId", n => { ParentSiteId = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetEnumValue<TermGroupScope>(); } },
                {"sets", n => { Sets = n.GetCollectionOfObjectValues<Set>(Set.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("parentSiteId", ParentSiteId);
            writer.WriteEnumValue<TermGroupScope>("scope", Scope);
            writer.WriteCollectionOfObjectValues<Set>("sets", Sets);
        }
    }
}
