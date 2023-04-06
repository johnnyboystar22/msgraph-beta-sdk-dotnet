using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The endpoint privilege management elevation result entity representing a single elevation action on a client device.
    /// </summary>
    public class PrivilegeManagementElevation : Entity, IParsable {
        /// <summary>The certificate payload of the application. This is computed by hashing the certificate information on the client. Example: `32c220482c68413fbf8290e3b1e49b0a85901cfcd62ab0738760568a2a6e8a50`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificatePayload {
            get { return BackingStore?.Get<string?>("certificatePayload"); }
            set { BackingStore?.Set("certificatePayload", value); }
        }
#nullable restore
#else
        public string CertificatePayload {
            get { return BackingStore?.Get<string>("certificatePayload"); }
            set { BackingStore?.Set("certificatePayload", value); }
        }
#endif
        /// <summary>The company name of the application. This value is set by the creator of the application. Example: `Microsoft Corporation`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>The Intune deviceId. Unique identifier for the managed device. Example: `92ce5047-9553-4731-817f-9b401a999a1b`</summary>
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
        /// <summary>The name associated with the device in the intune database. Example: `JOHNDOE-LAPTOP`.</summary>
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
        /// <summary>Indicates the type of elevation occured</summary>
        public PrivilegeManagementElevationType? ElevationType {
            get { return BackingStore?.Get<PrivilegeManagementElevationType?>("elevationType"); }
            set { BackingStore?.Set("elevationType", value); }
        }
        /// <summary>The date and time when the application was elevated. Example:`2014-01-01T00:00:00Z`</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>The file description of the application. This value is set by the creator of the application. Example: `Editor of multiple coding languages.`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileDescription {
            get { return BackingStore?.Get<string?>("fileDescription"); }
            set { BackingStore?.Set("fileDescription", value); }
        }
#nullable restore
#else
        public string FileDescription {
            get { return BackingStore?.Get<string>("fileDescription"); }
            set { BackingStore?.Set("fileDescription", value); }
        }
#endif
        /// <summary>The full file path of the application including the filename and file extension. Example: `C:\Program Files\vscode.exe`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath {
            get { return BackingStore?.Get<string?>("filePath"); }
            set { BackingStore?.Set("filePath", value); }
        }
#nullable restore
#else
        public string FilePath {
            get { return BackingStore?.Get<string>("filePath"); }
            set { BackingStore?.Set("filePath", value); }
        }
#endif
        /// <summary>The version of the application. This value is set by the creator of the application. Example: `6.2211.1035.1000`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileVersion {
            get { return BackingStore?.Get<string?>("fileVersion"); }
            set { BackingStore?.Set("fileVersion", value); }
        }
#nullable restore
#else
        public string FileVersion {
            get { return BackingStore?.Get<string>("fileVersion"); }
            set { BackingStore?.Set("fileVersion", value); }
        }
#endif
        /// <summary>The sha256 hash of the application. Example: `32c220482c68413fbf8290e3b1e49b0a85901cfcd62ab0738760568a2a6e8a57`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hash {
            get { return BackingStore?.Get<string?>("hash"); }
            set { BackingStore?.Set("hash", value); }
        }
#nullable restore
#else
        public string Hash {
            get { return BackingStore?.Get<string>("hash"); }
            set { BackingStore?.Set("hash", value); }
        }
#endif
        /// <summary>The internal name of the application. This value is set by the creator of the application. Example: `VS code`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalName {
            get { return BackingStore?.Get<string?>("internalName"); }
            set { BackingStore?.Set("internalName", value); }
        }
#nullable restore
#else
        public string InternalName {
            get { return BackingStore?.Get<string>("internalName"); }
            set { BackingStore?.Set("internalName", value); }
        }
#endif
        /// <summary>The justification to elevate the application. This is an input by the user when the privilegeManagementElevationType is of type userConfirmedElevation or support approved elevation. This will be null in all other scenarios. The length is capped at 256 char, enforced on the client side. Example: `To install debug tool.`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>The product name of the application. This value is set by the creator of the application. Example: `Visual Studio`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName {
            get { return BackingStore?.Get<string?>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
#nullable restore
#else
        public string ProductName {
            get { return BackingStore?.Get<string>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
#endif
        /// <summary>The result of the elevation action with 0 being success, and everything else being exit code if the elevation was unsuccessful. The value will always be 0 on all unmanaged elevation. Example: `0`. Valid values 0 to 2147483647</summary>
        public int? Result {
            get { return BackingStore?.Get<int?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>The User Principal Name of the user who performed the elevation. Example: `john@domain.com`</summary>
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
        /// <summary>The type of user account on Windows that was used to performed the elevation.</summary>
        public PrivilegeManagementEndUserType? UserType {
            get { return BackingStore?.Get<PrivilegeManagementEndUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegeManagementElevation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegeManagementElevation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificatePayload", n => { CertificatePayload = n.GetStringValue(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"elevationType", n => { ElevationType = n.GetEnumValue<PrivilegeManagementElevationType>(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileDescription", n => { FileDescription = n.GetStringValue(); } },
                {"filePath", n => { FilePath = n.GetStringValue(); } },
                {"fileVersion", n => { FileVersion = n.GetStringValue(); } },
                {"hash", n => { Hash = n.GetStringValue(); } },
                {"internalName", n => { InternalName = n.GetStringValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"result", n => { Result = n.GetIntValue(); } },
                {"upn", n => { Upn = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<PrivilegeManagementEndUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificatePayload", CertificatePayload);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<PrivilegeManagementElevationType>("elevationType", ElevationType);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("fileDescription", FileDescription);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteStringValue("fileVersion", FileVersion);
            writer.WriteStringValue("hash", Hash);
            writer.WriteStringValue("internalName", InternalName);
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteIntValue("result", Result);
            writer.WriteStringValue("upn", Upn);
            writer.WriteEnumValue<PrivilegeManagementEndUserType>("userType", UserType);
        }
    }
}
