using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Device Co-Management eligibility state
    /// </summary>
    public class ComanagementEligibleDevice : Entity, IParsable {
        /// <summary>Device registration status.</summary>
        public DeviceRegistrationState? ClientRegistrationStatus {
            get { return BackingStore?.Get<DeviceRegistrationState?>("clientRegistrationStatus"); }
            set { BackingStore?.Set("clientRegistrationStatus", value); }
        }
        /// <summary>DeviceName</summary>
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
        /// <summary>Device type.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>EntitySource</summary>
        public int? EntitySource {
            get { return BackingStore?.Get<int?>("entitySource"); }
            set { BackingStore?.Set("entitySource", value); }
        }
        /// <summary>Management agent type.</summary>
        public ManagementAgentType? ManagementAgents {
            get { return BackingStore?.Get<ManagementAgentType?>("managementAgents"); }
            set { BackingStore?.Set("managementAgents", value); }
        }
        /// <summary>Management state of device in Microsoft Intune.</summary>
        public Microsoft.Graph.Beta.Models.ManagementState? ManagementState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagementState?>("managementState"); }
            set { BackingStore?.Set("managementState", value); }
        }
        /// <summary>Manufacturer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>MDMStatus</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdmStatus {
            get { return BackingStore?.Get<string?>("mdmStatus"); }
            set { BackingStore?.Set("mdmStatus", value); }
        }
#nullable restore
#else
        public string MdmStatus {
            get { return BackingStore?.Get<string>("mdmStatus"); }
            set { BackingStore?.Set("mdmStatus", value); }
        }
#endif
        /// <summary>Model</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>OSDescription</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDescription {
            get { return BackingStore?.Get<string?>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#nullable restore
#else
        public string OsDescription {
            get { return BackingStore?.Get<string>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#endif
        /// <summary>OSVersion</summary>
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
        /// <summary>Owner type of device.</summary>
        public Microsoft.Graph.Beta.Models.OwnerType? OwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OwnerType?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
        /// <summary>ReferenceId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceId {
            get { return BackingStore?.Get<string?>("referenceId"); }
            set { BackingStore?.Set("referenceId", value); }
        }
#nullable restore
#else
        public string ReferenceId {
            get { return BackingStore?.Get<string>("referenceId"); }
            set { BackingStore?.Set("referenceId", value); }
        }
#endif
        /// <summary>SerialNumber</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>The status property</summary>
        public ComanagementEligibleType? Status {
            get { return BackingStore?.Get<ComanagementEligibleType?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>UPN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upn {
            get { return BackingStore?.Get<string?>("upn"); }
            set { BackingStore?.Set("upn", value); }
        }
#nullable restore
#else
        public string Upn {
            get { return BackingStore?.Get<string>("upn"); }
            set { BackingStore?.Set("upn", value); }
        }
#endif
        /// <summary>UserEmail</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail {
            get { return BackingStore?.Get<string?>("userEmail"); }
            set { BackingStore?.Set("userEmail", value); }
        }
#nullable restore
#else
        public string UserEmail {
            get { return BackingStore?.Get<string>("userEmail"); }
            set { BackingStore?.Set("userEmail", value); }
        }
#endif
        /// <summary>UserId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>UserName</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ComanagementEligibleDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComanagementEligibleDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clientRegistrationStatus", n => { ClientRegistrationStatus = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"entitySource", n => { EntitySource = n.GetIntValue(); } },
                {"managementAgents", n => { ManagementAgents = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementState", n => { ManagementState = n.GetEnumValue<ManagementState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"mdmStatus", n => { MdmStatus = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetEnumValue<OwnerType>(); } },
                {"referenceId", n => { ReferenceId = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ComanagementEligibleType>(); } },
                {"upn", n => { Upn = n.GetStringValue(); } },
                {"userEmail", n => { UserEmail = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceRegistrationState>("clientRegistrationStatus", ClientRegistrationStatus);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceType>("deviceType", DeviceType);
            writer.WriteIntValue("entitySource", EntitySource);
            writer.WriteEnumValue<ManagementAgentType>("managementAgents", ManagementAgents);
            writer.WriteEnumValue<ManagementState>("managementState", ManagementState);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("mdmStatus", MdmStatus);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteEnumValue<OwnerType>("ownerType", OwnerType);
            writer.WriteStringValue("referenceId", ReferenceId);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteEnumValue<ComanagementEligibleType>("status", Status);
            writer.WriteStringValue("upn", Upn);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
