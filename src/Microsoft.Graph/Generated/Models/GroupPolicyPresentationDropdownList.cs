using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationDropdownList : GroupPolicyUploadedPresentation, IParsable {
        /// <summary>Localized string value identifying the default choice of the list of items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupPolicyPresentationDropdownListItem? DefaultItem {
            get { return BackingStore?.Get<GroupPolicyPresentationDropdownListItem?>("defaultItem"); }
            set { BackingStore?.Set("defaultItem", value); }
        }
#nullable restore
#else
        public GroupPolicyPresentationDropdownListItem DefaultItem {
            get { return BackingStore?.Get<GroupPolicyPresentationDropdownListItem>("defaultItem"); }
            set { BackingStore?.Set("defaultItem", value); }
        }
#endif
        /// <summary>Represents a set of localized display names and their associated values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupPolicyPresentationDropdownListItem>? Items {
            get { return BackingStore?.Get<List<GroupPolicyPresentationDropdownListItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<GroupPolicyPresentationDropdownListItem> Items {
            get { return BackingStore?.Get<List<GroupPolicyPresentationDropdownListItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>Requirement to enter a value in the parameter box. The default value is false.</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>
        /// Instantiates a new GroupPolicyPresentationDropdownList and sets the default values.
        /// </summary>
        public GroupPolicyPresentationDropdownList() : base() {
            OdataType = "#microsoft.graph.groupPolicyPresentationDropdownList";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyPresentationDropdownList CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationDropdownList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultItem", n => { DefaultItem = n.GetObjectValue<GroupPolicyPresentationDropdownListItem>(GroupPolicyPresentationDropdownListItem.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<GroupPolicyPresentationDropdownListItem>(GroupPolicyPresentationDropdownListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GroupPolicyPresentationDropdownListItem>("defaultItem", DefaultItem);
            writer.WriteCollectionOfObjectValues<GroupPolicyPresentationDropdownListItem>("items", Items);
            writer.WriteBoolValue("required", Required);
        }
    }
}
