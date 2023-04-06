using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ItemActivityStat : Entity, IParsable {
        /// <summary>Statistics about the access actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActionStat? Access {
            get { return BackingStore?.Get<ItemActionStat?>("access"); }
            set { BackingStore?.Set("access", value); }
        }
#nullable restore
#else
        public ItemActionStat Access {
            get { return BackingStore?.Get<ItemActionStat>("access"); }
            set { BackingStore?.Set("access", value); }
        }
#endif
        /// <summary>Exposes the itemActivities represented in this itemActivityStat resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ItemActivity>? Activities {
            get { return BackingStore?.Get<List<ItemActivity>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<ItemActivity> Activities {
            get { return BackingStore?.Get<List<ItemActivity>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>Statistics about the create actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActionStat? Create {
            get { return BackingStore?.Get<ItemActionStat?>("create"); }
            set { BackingStore?.Set("create", value); }
        }
#nullable restore
#else
        public ItemActionStat Create {
            get { return BackingStore?.Get<ItemActionStat>("create"); }
            set { BackingStore?.Set("create", value); }
        }
#endif
        /// <summary>Statistics about the delete actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActionStat? Delete {
            get { return BackingStore?.Get<ItemActionStat?>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
#nullable restore
#else
        public ItemActionStat Delete {
            get { return BackingStore?.Get<ItemActionStat>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
#endif
        /// <summary>Statistics about the edit actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActionStat? Edit {
            get { return BackingStore?.Get<ItemActionStat?>("edit"); }
            set { BackingStore?.Set("edit", value); }
        }
#nullable restore
#else
        public ItemActionStat Edit {
            get { return BackingStore?.Get<ItemActionStat>("edit"); }
            set { BackingStore?.Set("edit", value); }
        }
#endif
        /// <summary>When the interval ends. Read-only.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Indicates that the statistics in this interval are based on incomplete data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IncompleteData? IncompleteData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IncompleteData?>("incompleteData"); }
            set { BackingStore?.Set("incompleteData", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IncompleteData IncompleteData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IncompleteData>("incompleteData"); }
            set { BackingStore?.Set("incompleteData", value); }
        }
#endif
        /// <summary>Indicates whether the item is &apos;trending.&apos; Read-only.</summary>
        public bool? IsTrending {
            get { return BackingStore?.Get<bool?>("isTrending"); }
            set { BackingStore?.Set("isTrending", value); }
        }
        /// <summary>Statistics about the move actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActionStat? Move {
            get { return BackingStore?.Get<ItemActionStat?>("move"); }
            set { BackingStore?.Set("move", value); }
        }
#nullable restore
#else
        public ItemActionStat Move {
            get { return BackingStore?.Get<ItemActionStat>("move"); }
            set { BackingStore?.Set("move", value); }
        }
#endif
        /// <summary>When the interval starts. Read-only.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemActivityStat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityStat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"access", n => { Access = n.GetObjectValue<ItemActionStat>(ItemActionStat.CreateFromDiscriminatorValue); } },
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ItemActivity>(ItemActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"create", n => { Create = n.GetObjectValue<ItemActionStat>(ItemActionStat.CreateFromDiscriminatorValue); } },
                {"delete", n => { Delete = n.GetObjectValue<ItemActionStat>(ItemActionStat.CreateFromDiscriminatorValue); } },
                {"edit", n => { Edit = n.GetObjectValue<ItemActionStat>(ItemActionStat.CreateFromDiscriminatorValue); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"incompleteData", n => { IncompleteData = n.GetObjectValue<Microsoft.Graph.Beta.Models.IncompleteData>(Microsoft.Graph.Beta.Models.IncompleteData.CreateFromDiscriminatorValue); } },
                {"isTrending", n => { IsTrending = n.GetBoolValue(); } },
                {"move", n => { Move = n.GetObjectValue<ItemActionStat>(ItemActionStat.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemActionStat>("access", Access);
            writer.WriteCollectionOfObjectValues<ItemActivity>("activities", Activities);
            writer.WriteObjectValue<ItemActionStat>("create", Create);
            writer.WriteObjectValue<ItemActionStat>("delete", Delete);
            writer.WriteObjectValue<ItemActionStat>("edit", Edit);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IncompleteData>("incompleteData", IncompleteData);
            writer.WriteBoolValue("isTrending", IsTrending);
            writer.WriteObjectValue<ItemActionStat>("move", Move);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
