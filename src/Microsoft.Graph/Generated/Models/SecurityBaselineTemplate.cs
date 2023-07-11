using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The security baseline template of the account
    /// </summary>
    public class SecurityBaselineTemplate : DeviceManagementTemplate, IParsable {
        /// <summary>The security baseline per category device state summary</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SecurityBaselineCategoryStateSummary>? CategoryDeviceStateSummaries {
            get { return BackingStore?.Get<List<SecurityBaselineCategoryStateSummary>?>("categoryDeviceStateSummaries"); }
            set { BackingStore?.Set("categoryDeviceStateSummaries", value); }
        }
#nullable restore
#else
        public List<SecurityBaselineCategoryStateSummary> CategoryDeviceStateSummaries {
            get { return BackingStore?.Get<List<SecurityBaselineCategoryStateSummary>>("categoryDeviceStateSummaries"); }
            set { BackingStore?.Set("categoryDeviceStateSummaries", value); }
        }
#endif
        /// <summary>The security baseline device states</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SecurityBaselineDeviceState>? DeviceStates {
            get { return BackingStore?.Get<List<SecurityBaselineDeviceState>?>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#nullable restore
#else
        public List<SecurityBaselineDeviceState> DeviceStates {
            get { return BackingStore?.Get<List<SecurityBaselineDeviceState>>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#endif
        /// <summary>The security baseline device state summary</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityBaselineStateSummary? DeviceStateSummary {
            get { return BackingStore?.Get<SecurityBaselineStateSummary?>("deviceStateSummary"); }
            set { BackingStore?.Set("deviceStateSummary", value); }
        }
#nullable restore
#else
        public SecurityBaselineStateSummary DeviceStateSummary {
            get { return BackingStore?.Get<SecurityBaselineStateSummary>("deviceStateSummary"); }
            set { BackingStore?.Set("deviceStateSummary", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new securityBaselineTemplate and sets the default values.
        /// </summary>
        public SecurityBaselineTemplate() : base() {
            OdataType = "#microsoft.graph.securityBaselineTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityBaselineTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categoryDeviceStateSummaries", n => { CategoryDeviceStateSummaries = n.GetCollectionOfObjectValues<SecurityBaselineCategoryStateSummary>(SecurityBaselineCategoryStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<SecurityBaselineDeviceState>(SecurityBaselineDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStateSummary", n => { DeviceStateSummary = n.GetObjectValue<SecurityBaselineStateSummary>(SecurityBaselineStateSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SecurityBaselineCategoryStateSummary>("categoryDeviceStateSummaries", CategoryDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<SecurityBaselineDeviceState>("deviceStates", DeviceStates);
            writer.WriteObjectValue<SecurityBaselineStateSummary>("deviceStateSummary", DeviceStateSummary);
        }
    }
}
