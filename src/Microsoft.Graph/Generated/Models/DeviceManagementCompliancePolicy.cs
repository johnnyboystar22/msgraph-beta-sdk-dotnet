using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Device Management Compliance Policy
    /// </summary>
    public class DeviceManagementCompliancePolicy : Entity, IParsable {
        /// <summary>Policy assignments</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationPolicyAssignment>? Assignments {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Policy creation date and time. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Policy creation source</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreationSource {
            get { return BackingStore?.Get<string?>("creationSource"); }
            set { BackingStore?.Set("creationSource", value); }
        }
#nullable restore
#else
        public string CreationSource {
            get { return BackingStore?.Get<string>("creationSource"); }
            set { BackingStore?.Set("creationSource", value); }
        }
#endif
        /// <summary>Policy description</summary>
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
        /// <summary>Policy assignment status. This property is read-only.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>Policy last modification date and time. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Policy name</summary>
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
        /// <summary>Supported platform types.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms {
            get { return BackingStore?.Get<DeviceManagementConfigurationPlatforms?>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>The list of scheduled action for this rule</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementComplianceScheduledActionForRule>? ScheduledActionsForRule {
            get { return BackingStore?.Get<List<DeviceManagementComplianceScheduledActionForRule>?>("scheduledActionsForRule"); }
            set { BackingStore?.Set("scheduledActionsForRule", value); }
        }
#nullable restore
#else
        public List<DeviceManagementComplianceScheduledActionForRule> ScheduledActionsForRule {
            get { return BackingStore?.Get<List<DeviceManagementComplianceScheduledActionForRule>>("scheduledActionsForRule"); }
            set { BackingStore?.Set("scheduledActionsForRule", value); }
        }
#endif
        /// <summary>Number of settings. This property is read-only.</summary>
        public int? SettingCount {
            get { return BackingStore?.Get<int?>("settingCount"); }
            set { BackingStore?.Set("settingCount", value); }
        }
        /// <summary>Policy settings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationSetting>? Settings {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSetting>?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationSetting> Settings {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSetting>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Describes which technology this setting can be deployed with</summary>
        public DeviceManagementConfigurationTechnologies? Technologies {
            get { return BackingStore?.Get<DeviceManagementConfigurationTechnologies?>("technologies"); }
            set { BackingStore?.Set("technologies", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>(DeviceManagementConfigurationPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationSource", n => { CreationSource = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"platforms", n => { Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"scheduledActionsForRule", n => { ScheduledActionsForRule = n.GetCollectionOfObjectValues<DeviceManagementComplianceScheduledActionForRule>(DeviceManagementComplianceScheduledActionForRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settingCount", n => { SettingCount = n.GetIntValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSetting>(DeviceManagementConfigurationSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>("assignments", Assignments);
            writer.WriteStringValue("creationSource", CreationSource);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<DeviceManagementComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSetting>("settings", Settings);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
        }
    }
}
