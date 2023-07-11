using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics hardware readiness entity contains account level information about hardware blockers for windows upgrade.
    /// </summary>
    public class UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric : Entity, IParsable {
        /// <summary>The percentage of devices for which OS check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? OsCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("osCheckFailedPercentage"); }
            set { BackingStore?.Set("osCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which processor hardware 64-bit architecture check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Processor64BitCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("processor64BitCheckFailedPercentage"); }
            set { BackingStore?.Set("processor64BitCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which processor hardware core count check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorCoreCountCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("processorCoreCountCheckFailedPercentage"); }
            set { BackingStore?.Set("processorCoreCountCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which processor hardware family check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorFamilyCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("processorFamilyCheckFailedPercentage"); }
            set { BackingStore?.Set("processorFamilyCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which processor hardware speed check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorSpeedCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("processorSpeedCheckFailedPercentage"); }
            set { BackingStore?.Set("processorSpeedCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which RAM hardware check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? RamCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("ramCheckFailedPercentage"); }
            set { BackingStore?.Set("ramCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which secure boot hardware check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? SecureBootCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("secureBootCheckFailedPercentage"); }
            set { BackingStore?.Set("secureBootCheckFailedPercentage", value); }
        }
        /// <summary>The percentage of devices for which storage hardware check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StorageCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("storageCheckFailedPercentage"); }
            set { BackingStore?.Set("storageCheckFailedPercentage", value); }
        }
        /// <summary>The count of total devices in an organization. Valid values 0 to 2147483647. Supports: $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceCount {
            get { return BackingStore?.Get<int?>("totalDeviceCount"); }
            set { BackingStore?.Set("totalDeviceCount", value); }
        }
        /// <summary>The percentage of devices for which Trusted Platform Module (TPM) hardware check has failed. Valid values 0 to 100. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? TpmCheckFailedPercentage {
            get { return BackingStore?.Get<double?>("tpmCheckFailedPercentage"); }
            set { BackingStore?.Set("tpmCheckFailedPercentage", value); }
        }
        /// <summary>The count of devices in an organization eligible for windows upgrade. Valid values 0 to 2147483647. Supports: $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? UpgradeEligibleDeviceCount {
            get { return BackingStore?.Get<int?>("upgradeEligibleDeviceCount"); }
            set { BackingStore?.Set("upgradeEligibleDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"osCheckFailedPercentage", n => { OsCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processor64BitCheckFailedPercentage", n => { Processor64BitCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorCoreCountCheckFailedPercentage", n => { ProcessorCoreCountCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorFamilyCheckFailedPercentage", n => { ProcessorFamilyCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorSpeedCheckFailedPercentage", n => { ProcessorSpeedCheckFailedPercentage = n.GetDoubleValue(); } },
                {"ramCheckFailedPercentage", n => { RamCheckFailedPercentage = n.GetDoubleValue(); } },
                {"secureBootCheckFailedPercentage", n => { SecureBootCheckFailedPercentage = n.GetDoubleValue(); } },
                {"storageCheckFailedPercentage", n => { StorageCheckFailedPercentage = n.GetDoubleValue(); } },
                {"totalDeviceCount", n => { TotalDeviceCount = n.GetIntValue(); } },
                {"tpmCheckFailedPercentage", n => { TpmCheckFailedPercentage = n.GetDoubleValue(); } },
                {"upgradeEligibleDeviceCount", n => { UpgradeEligibleDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("osCheckFailedPercentage", OsCheckFailedPercentage);
            writer.WriteDoubleValue("processor64BitCheckFailedPercentage", Processor64BitCheckFailedPercentage);
            writer.WriteDoubleValue("processorCoreCountCheckFailedPercentage", ProcessorCoreCountCheckFailedPercentage);
            writer.WriteDoubleValue("processorFamilyCheckFailedPercentage", ProcessorFamilyCheckFailedPercentage);
            writer.WriteDoubleValue("processorSpeedCheckFailedPercentage", ProcessorSpeedCheckFailedPercentage);
            writer.WriteDoubleValue("ramCheckFailedPercentage", RamCheckFailedPercentage);
            writer.WriteDoubleValue("secureBootCheckFailedPercentage", SecureBootCheckFailedPercentage);
            writer.WriteDoubleValue("storageCheckFailedPercentage", StorageCheckFailedPercentage);
            writer.WriteIntValue("totalDeviceCount", TotalDeviceCount);
            writer.WriteDoubleValue("tpmCheckFailedPercentage", TpmCheckFailedPercentage);
            writer.WriteIntValue("upgradeEligibleDeviceCount", UpgradeEligibleDeviceCount);
        }
    }
}
