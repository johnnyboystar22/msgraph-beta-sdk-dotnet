using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SensitivityLabel : Entity, IParsable {
        /// <summary>The applicableTo property</summary>
        public SensitivityLabelTarget? ApplicableTo {
            get { return BackingStore?.Get<SensitivityLabelTarget?>("applicableTo"); }
            set { BackingStore?.Set("applicableTo", value); }
        }
        /// <summary>The applicationMode property</summary>
        public Microsoft.Graph.Beta.Models.ApplicationMode? ApplicationMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApplicationMode?>("applicationMode"); }
            set { BackingStore?.Set("applicationMode", value); }
        }
        /// <summary>The assignedPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LabelPolicy>? AssignedPolicies {
            get { return BackingStore?.Get<List<LabelPolicy>?>("assignedPolicies"); }
            set { BackingStore?.Set("assignedPolicies", value); }
        }
#nullable restore
#else
        public List<LabelPolicy> AssignedPolicies {
            get { return BackingStore?.Get<List<LabelPolicy>>("assignedPolicies"); }
            set { BackingStore?.Set("assignedPolicies", value); }
        }
#endif
        /// <summary>The autoLabeling property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AutoLabeling? AutoLabeling {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutoLabeling?>("autoLabeling"); }
            set { BackingStore?.Set("autoLabeling", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AutoLabeling AutoLabeling {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutoLabeling>("autoLabeling"); }
            set { BackingStore?.Set("autoLabeling", value); }
        }
#endif
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
        /// <summary>The displayName property</summary>
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
        /// <summary>The isDefault property</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>The isEndpointProtectionEnabled property</summary>
        public bool? IsEndpointProtectionEnabled {
            get { return BackingStore?.Get<bool?>("isEndpointProtectionEnabled"); }
            set { BackingStore?.Set("isEndpointProtectionEnabled", value); }
        }
        /// <summary>The labelActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LabelActionBase>? LabelActions {
            get { return BackingStore?.Get<List<LabelActionBase>?>("labelActions"); }
            set { BackingStore?.Set("labelActions", value); }
        }
#nullable restore
#else
        public List<LabelActionBase> LabelActions {
            get { return BackingStore?.Get<List<LabelActionBase>>("labelActions"); }
            set { BackingStore?.Set("labelActions", value); }
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
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The sublabels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SensitivityLabel>? Sublabels {
            get { return BackingStore?.Get<List<SensitivityLabel>?>("sublabels"); }
            set { BackingStore?.Set("sublabels", value); }
        }
#nullable restore
#else
        public List<SensitivityLabel> Sublabels {
            get { return BackingStore?.Get<List<SensitivityLabel>>("sublabels"); }
            set { BackingStore?.Set("sublabels", value); }
        }
#endif
        /// <summary>The toolTip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToolTip {
            get { return BackingStore?.Get<string?>("toolTip"); }
            set { BackingStore?.Set("toolTip", value); }
        }
#nullable restore
#else
        public string ToolTip {
            get { return BackingStore?.Get<string>("toolTip"); }
            set { BackingStore?.Set("toolTip", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SensitivityLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitivityLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableTo", n => { ApplicableTo = n.GetEnumValue<SensitivityLabelTarget>(); } },
                {"applicationMode", n => { ApplicationMode = n.GetEnumValue<ApplicationMode>(); } },
                {"assignedPolicies", n => { AssignedPolicies = n.GetCollectionOfObjectValues<LabelPolicy>(LabelPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"autoLabeling", n => { AutoLabeling = n.GetObjectValue<Microsoft.Graph.Beta.Models.AutoLabeling>(Microsoft.Graph.Beta.Models.AutoLabeling.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isEndpointProtectionEnabled", n => { IsEndpointProtectionEnabled = n.GetBoolValue(); } },
                {"labelActions", n => { LabelActions = n.GetCollectionOfObjectValues<LabelActionBase>(LabelActionBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"sublabels", n => { Sublabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"toolTip", n => { ToolTip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SensitivityLabelTarget>("applicableTo", ApplicableTo);
            writer.WriteEnumValue<ApplicationMode>("applicationMode", ApplicationMode);
            writer.WriteCollectionOfObjectValues<LabelPolicy>("assignedPolicies", AssignedPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AutoLabeling>("autoLabeling", AutoLabeling);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isEndpointProtectionEnabled", IsEndpointProtectionEnabled);
            writer.WriteCollectionOfObjectValues<LabelActionBase>("labelActions", LabelActions);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sublabels", Sublabels);
            writer.WriteStringValue("toolTip", ToolTip);
        }
    }
}
