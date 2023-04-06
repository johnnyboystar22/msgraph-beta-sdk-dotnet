using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SecurityAction : Entity, IParsable {
        /// <summary>Reason for invoking this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionReason {
            get { return BackingStore?.Get<string?>("actionReason"); }
            set { BackingStore?.Set("actionReason", value); }
        }
#nullable restore
#else
        public string ActionReason {
            get { return BackingStore?.Get<string>("actionReason"); }
            set { BackingStore?.Set("actionReason", value); }
        }
#endif
        /// <summary>The Application ID of the calling application that submitted (POST) the action. The appId should be extracted from the auth token and not entered manually by the calling application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Azure tenant ID of the entity to determine which tenant the entity belongs to (multi-tenancy support). The azureTenantId should be extracted from the auth token and not entered manually by the calling application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>The clientContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext {
            get { return BackingStore?.Get<string?>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#nullable restore
#else
        public string ClientContext {
            get { return BackingStore?.Get<string>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#endif
        /// <summary>Timestamp when the action was completed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>Timestamp when the action is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Error info when the action fails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ResultInfo? ErrorInfo {
            get { return BackingStore?.Get<ResultInfo?>("errorInfo"); }
            set { BackingStore?.Set("errorInfo", value); }
        }
#nullable restore
#else
        public ResultInfo ErrorInfo {
            get { return BackingStore?.Get<ResultInfo>("errorInfo"); }
            set { BackingStore?.Set("errorInfo", value); }
        }
#endif
        /// <summary>Timestamp when this action was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>Action name.</summary>
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
        /// <summary>Collection of parameters (key-value pairs) necessary to invoke the action, for example, URL or fileHash to block.). Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? Parameters {
            get { return BackingStore?.Get<List<KeyValuePair>?>("parameters"); }
            set { BackingStore?.Set("parameters", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> Parameters {
            get { return BackingStore?.Get<List<KeyValuePair>>("parameters"); }
            set { BackingStore?.Set("parameters", value); }
        }
#endif
        /// <summary>Collection of securityActionState to keep the history of an action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SecurityActionState>? States {
            get { return BackingStore?.Get<List<SecurityActionState>?>("states"); }
            set { BackingStore?.Set("states", value); }
        }
#nullable restore
#else
        public List<SecurityActionState> States {
            get { return BackingStore?.Get<List<SecurityActionState>>("states"); }
            set { BackingStore?.Set("states", value); }
        }
#endif
        /// <summary>Status of the action. Possible values are: NotStarted, Running, Completed, Failed.</summary>
        public OperationStatus? Status {
            get { return BackingStore?.Get<OperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The user principal name of the signed-in user that submitted  (POST) the action. The user should be extracted from the auth token and not entered manually by the calling application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User {
            get { return BackingStore?.Get<string?>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#nullable restore
#else
        public string User {
            get { return BackingStore?.Get<string>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#endif
        /// <summary>Complex Type containing details about the Security product/service vendor, provider, and sub-provider (for example, vendor=Microsoft; provider=Windows Defender ATP; sub-provider=AppLocker).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityVendorInformation? VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionReason", n => { ActionReason = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"clientContext", n => { ClientContext = n.GetStringValue(); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorInfo", n => { ErrorInfo = n.GetObjectValue<ResultInfo>(ResultInfo.CreateFromDiscriminatorValue); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parameters", n => { Parameters = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"states", n => { States = n.GetCollectionOfObjectValues<SecurityActionState>(SecurityActionState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<OperationStatus>(); } },
                {"user", n => { User = n.GetStringValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionReason", ActionReason);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ResultInfo>("errorInfo", ErrorInfo);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("parameters", Parameters);
            writer.WriteCollectionOfObjectValues<SecurityActionState>("states", States);
            writer.WriteEnumValue<OperationStatus>("status", Status);
            writer.WriteStringValue("user", User);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
