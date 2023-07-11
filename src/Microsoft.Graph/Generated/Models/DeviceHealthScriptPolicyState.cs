using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties for policy run state of the device health script.
    /// </summary>
    public class DeviceHealthScriptPolicyState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>A list of the assignment filter ids used for health script applicability evaluation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssignmentFilterIds {
            get { return BackingStore?.Get<List<string>?>("assignmentFilterIds"); }
            set { BackingStore?.Set("assignmentFilterIds", value); }
        }
#nullable restore
#else
        public List<string> AssignmentFilterIds {
            get { return BackingStore?.Get<List<string>>("assignmentFilterIds"); }
            set { BackingStore?.Set("assignmentFilterIds", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public RunState? DetectionState {
            get { return BackingStore?.Get<RunState?>("detectionState"); }
            set { BackingStore?.Set("detectionState", value); }
        }
        /// <summary>The Intune device Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>Display name of the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The next timestamp of when the device health script is expected to execute</summary>
        public DateTimeOffset? ExpectedStateUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expectedStateUpdateDateTime"); }
            set { BackingStore?.Set("expectedStateUpdateDateTime", value); }
        }
        /// <summary>Key of the device health script policy state is a concatenation of the MT sideCar policy Id and Intune device Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>The last timestamp of when the device health script executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStateUpdateDateTime"); }
            set { BackingStore?.Set("lastStateUpdateDateTime", value); }
        }
        /// <summary>The last time that Intune Managment Extension synced with Intune</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Value of the OS Version in string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>The MT sideCar policy Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId {
            get { return BackingStore?.Get<string?>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#nullable restore
#else
        public string PolicyId {
            get { return BackingStore?.Get<string>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#endif
        /// <summary>Display name of the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName {
            get { return BackingStore?.Get<string?>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#nullable restore
#else
        public string PolicyName {
            get { return BackingStore?.Get<string>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#endif
        /// <summary>Error from the detection script after remediation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostRemediationDetectionScriptError {
            get { return BackingStore?.Get<string?>("postRemediationDetectionScriptError"); }
            set { BackingStore?.Set("postRemediationDetectionScriptError", value); }
        }
#nullable restore
#else
        public string PostRemediationDetectionScriptError {
            get { return BackingStore?.Get<string>("postRemediationDetectionScriptError"); }
            set { BackingStore?.Set("postRemediationDetectionScriptError", value); }
        }
#endif
        /// <summary>Detection script output after remediation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostRemediationDetectionScriptOutput {
            get { return BackingStore?.Get<string?>("postRemediationDetectionScriptOutput"); }
            set { BackingStore?.Set("postRemediationDetectionScriptOutput", value); }
        }
#nullable restore
#else
        public string PostRemediationDetectionScriptOutput {
            get { return BackingStore?.Get<string>("postRemediationDetectionScriptOutput"); }
            set { BackingStore?.Set("postRemediationDetectionScriptOutput", value); }
        }
#endif
        /// <summary>Error from the detection script before remediation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreRemediationDetectionScriptError {
            get { return BackingStore?.Get<string?>("preRemediationDetectionScriptError"); }
            set { BackingStore?.Set("preRemediationDetectionScriptError", value); }
        }
#nullable restore
#else
        public string PreRemediationDetectionScriptError {
            get { return BackingStore?.Get<string>("preRemediationDetectionScriptError"); }
            set { BackingStore?.Set("preRemediationDetectionScriptError", value); }
        }
#endif
        /// <summary>Output of the detection script before remediation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreRemediationDetectionScriptOutput {
            get { return BackingStore?.Get<string?>("preRemediationDetectionScriptOutput"); }
            set { BackingStore?.Set("preRemediationDetectionScriptOutput", value); }
        }
#nullable restore
#else
        public string PreRemediationDetectionScriptOutput {
            get { return BackingStore?.Get<string>("preRemediationDetectionScriptOutput"); }
            set { BackingStore?.Set("preRemediationDetectionScriptOutput", value); }
        }
#endif
        /// <summary>Error output of the remediation script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationScriptError {
            get { return BackingStore?.Get<string?>("remediationScriptError"); }
            set { BackingStore?.Set("remediationScriptError", value); }
        }
#nullable restore
#else
        public string RemediationScriptError {
            get { return BackingStore?.Get<string>("remediationScriptError"); }
            set { BackingStore?.Set("remediationScriptError", value); }
        }
#endif
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public Microsoft.Graph.Beta.Models.RemediationState? RemediationState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RemediationState?>("remediationState"); }
            set { BackingStore?.Set("remediationState", value); }
        }
        /// <summary>Name of the user whom ran the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName {
            get { return BackingStore?.Get<string?>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#nullable restore
#else
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceHealthScriptPolicyState and sets the default values.
        /// </summary>
        public DeviceHealthScriptPolicyState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceHealthScriptPolicyState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptPolicyState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentFilterIds", n => { AssignmentFilterIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"detectionState", n => { DetectionState = n.GetEnumValue<RunState>(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"expectedStateUpdateDateTime", n => { ExpectedStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"postRemediationDetectionScriptError", n => { PostRemediationDetectionScriptError = n.GetStringValue(); } },
                {"postRemediationDetectionScriptOutput", n => { PostRemediationDetectionScriptOutput = n.GetStringValue(); } },
                {"preRemediationDetectionScriptError", n => { PreRemediationDetectionScriptError = n.GetStringValue(); } },
                {"preRemediationDetectionScriptOutput", n => { PreRemediationDetectionScriptOutput = n.GetStringValue(); } },
                {"remediationScriptError", n => { RemediationScriptError = n.GetStringValue(); } },
                {"remediationState", n => { RemediationState = n.GetEnumValue<RemediationState>(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("assignmentFilterIds", AssignmentFilterIds);
            writer.WriteEnumValue<RunState>("detectionState", DetectionState);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("expectedStateUpdateDateTime", ExpectedStateUpdateDateTime);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteStringValue("postRemediationDetectionScriptError", PostRemediationDetectionScriptError);
            writer.WriteStringValue("postRemediationDetectionScriptOutput", PostRemediationDetectionScriptOutput);
            writer.WriteStringValue("preRemediationDetectionScriptError", PreRemediationDetectionScriptError);
            writer.WriteStringValue("preRemediationDetectionScriptOutput", PreRemediationDetectionScriptOutput);
            writer.WriteStringValue("remediationScriptError", RemediationScriptError);
            writer.WriteEnumValue<RemediationState>("remediationState", RemediationState);
            writer.WriteStringValue("userName", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
