using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AdvancedThreatProtectionOnboardingStateSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AdvancedThreatProtectionOnboardingDeviceSettingState>? AdvancedThreatProtectionOnboardingDeviceSettingStates {
            get { return BackingStore?.Get<List<AdvancedThreatProtectionOnboardingDeviceSettingState>?>("advancedThreatProtectionOnboardingDeviceSettingStates"); }
            set { BackingStore?.Set("advancedThreatProtectionOnboardingDeviceSettingStates", value); }
        }
#nullable restore
#else
        public List<AdvancedThreatProtectionOnboardingDeviceSettingState> AdvancedThreatProtectionOnboardingDeviceSettingStates {
            get { return BackingStore?.Get<List<AdvancedThreatProtectionOnboardingDeviceSettingState>>("advancedThreatProtectionOnboardingDeviceSettingStates"); }
            set { BackingStore?.Set("advancedThreatProtectionOnboardingDeviceSettingStates", value); }
        }
#endif
        /// <summary>Number of compliant devices</summary>
        public int? CompliantDeviceCount {
            get { return BackingStore?.Get<int?>("compliantDeviceCount"); }
            set { BackingStore?.Set("compliantDeviceCount", value); }
        }
        /// <summary>Number of conflict devices</summary>
        public int? ConflictDeviceCount {
            get { return BackingStore?.Get<int?>("conflictDeviceCount"); }
            set { BackingStore?.Set("conflictDeviceCount", value); }
        }
        /// <summary>Number of error devices</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>("errorDeviceCount"); }
            set { BackingStore?.Set("errorDeviceCount", value); }
        }
        /// <summary>Number of NonCompliant devices</summary>
        public int? NonCompliantDeviceCount {
            get { return BackingStore?.Get<int?>("nonCompliantDeviceCount"); }
            set { BackingStore?.Set("nonCompliantDeviceCount", value); }
        }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableDeviceCount {
            get { return BackingStore?.Get<int?>("notApplicableDeviceCount"); }
            set { BackingStore?.Set("notApplicableDeviceCount", value); }
        }
        /// <summary>Number of not assigned devices</summary>
        public int? NotAssignedDeviceCount {
            get { return BackingStore?.Get<int?>("notAssignedDeviceCount"); }
            set { BackingStore?.Set("notAssignedDeviceCount", value); }
        }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedDeviceCount {
            get { return BackingStore?.Get<int?>("remediatedDeviceCount"); }
            set { BackingStore?.Set("remediatedDeviceCount", value); }
        }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AdvancedThreatProtectionOnboardingStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdvancedThreatProtectionOnboardingStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionOnboardingDeviceSettingStates", n => { AdvancedThreatProtectionOnboardingDeviceSettingStates = n.GetCollectionOfObjectValues<AdvancedThreatProtectionOnboardingDeviceSettingState>(AdvancedThreatProtectionOnboardingDeviceSettingState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"notAssignedDeviceCount", n => { NotAssignedDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AdvancedThreatProtectionOnboardingDeviceSettingState>("advancedThreatProtectionOnboardingDeviceSettingStates", AdvancedThreatProtectionOnboardingDeviceSettingStates);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notAssignedDeviceCount", NotAssignedDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
