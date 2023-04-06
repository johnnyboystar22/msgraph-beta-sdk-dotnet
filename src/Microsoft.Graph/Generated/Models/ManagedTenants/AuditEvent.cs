using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class AuditEvent : Entity, IParsable {
        /// <summary>A string which uniquely represents the operation that occurred. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Activity {
            get { return BackingStore?.Get<string?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public string Activity {
            get { return BackingStore?.Get<string>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The time when the activity ocurred. Required. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>The identifier of the activity request that made the audit event. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityId {
            get { return BackingStore?.Get<string?>("activityId"); }
            set { BackingStore?.Set("activityId", value); }
        }
#nullable restore
#else
        public string ActivityId {
            get { return BackingStore?.Get<string>("activityId"); }
            set { BackingStore?.Set("activityId", value); }
        }
#endif
        /// <summary>A category which represents a logical grouping of activities. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>The HTTP verb that was used when making the API request. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HttpVerb {
            get { return BackingStore?.Get<string?>("httpVerb"); }
            set { BackingStore?.Set("httpVerb", value); }
        }
#nullable restore
#else
        public string HttpVerb {
            get { return BackingStore?.Get<string>("httpVerb"); }
            set { BackingStore?.Set("httpVerb", value); }
        }
#endif
        /// <summary>The identifier of the app that was used to make the request. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByAppId {
            get { return BackingStore?.Get<string?>("initiatedByAppId"); }
            set { BackingStore?.Set("initiatedByAppId", value); }
        }
#nullable restore
#else
        public string InitiatedByAppId {
            get { return BackingStore?.Get<string>("initiatedByAppId"); }
            set { BackingStore?.Set("initiatedByAppId", value); }
        }
#endif
        /// <summary>The UPN of the user who initiated the activity. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByUpn {
            get { return BackingStore?.Get<string?>("initiatedByUpn"); }
            set { BackingStore?.Set("initiatedByUpn", value); }
        }
#nullable restore
#else
        public string InitiatedByUpn {
            get { return BackingStore?.Get<string>("initiatedByUpn"); }
            set { BackingStore?.Set("initiatedByUpn", value); }
        }
#endif
        /// <summary>The identifier of the user who initiated the activity. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByUserId {
            get { return BackingStore?.Get<string?>("initiatedByUserId"); }
            set { BackingStore?.Set("initiatedByUserId", value); }
        }
#nullable restore
#else
        public string InitiatedByUserId {
            get { return BackingStore?.Get<string>("initiatedByUserId"); }
            set { BackingStore?.Set("initiatedByUserId", value); }
        }
#endif
        /// <summary>The IP address of where the activity was initiated. This may be an IPv4 or IPv6 address. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The raw HTTP request body. Some sensitive information may be removed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestBody {
            get { return BackingStore?.Get<string?>("requestBody"); }
            set { BackingStore?.Set("requestBody", value); }
        }
#nullable restore
#else
        public string RequestBody {
            get { return BackingStore?.Get<string>("requestBody"); }
            set { BackingStore?.Set("requestBody", value); }
        }
#endif
        /// <summary>The raw HTTP request URL. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestUrl {
            get { return BackingStore?.Get<string?>("requestUrl"); }
            set { BackingStore?.Set("requestUrl", value); }
        }
#nullable restore
#else
        public string RequestUrl {
            get { return BackingStore?.Get<string>("requestUrl"); }
            set { BackingStore?.Set("requestUrl", value); }
        }
#endif
        /// <summary>The collection of Azure Active Directory tenant identifiers for the managed tenants that were impacted by this change. This is formatted as a list of comma-separated values. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantIds {
            get { return BackingStore?.Get<string?>("tenantIds"); }
            set { BackingStore?.Set("tenantIds", value); }
        }
#nullable restore
#else
        public string TenantIds {
            get { return BackingStore?.Get<string>("tenantIds"); }
            set { BackingStore?.Set("tenantIds", value); }
        }
#endif
        /// <summary>The collection of tenant names that were impacted by this change. This is formatted as a list of comma-separated values. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantNames {
            get { return BackingStore?.Get<string?>("tenantNames"); }
            set { BackingStore?.Set("tenantNames", value); }
        }
#nullable restore
#else
        public string TenantNames {
            get { return BackingStore?.Get<string>("tenantNames"); }
            set { BackingStore?.Set("tenantNames", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuditEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityId", n => { ActivityId = n.GetStringValue(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"httpVerb", n => { HttpVerb = n.GetStringValue(); } },
                {"initiatedByAppId", n => { InitiatedByAppId = n.GetStringValue(); } },
                {"initiatedByUpn", n => { InitiatedByUpn = n.GetStringValue(); } },
                {"initiatedByUserId", n => { InitiatedByUserId = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"requestBody", n => { RequestBody = n.GetStringValue(); } },
                {"requestUrl", n => { RequestUrl = n.GetStringValue(); } },
                {"tenantIds", n => { TenantIds = n.GetStringValue(); } },
                {"tenantNames", n => { TenantNames = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityId", ActivityId);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("httpVerb", HttpVerb);
            writer.WriteStringValue("initiatedByAppId", InitiatedByAppId);
            writer.WriteStringValue("initiatedByUpn", InitiatedByUpn);
            writer.WriteStringValue("initiatedByUserId", InitiatedByUserId);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("requestBody", RequestBody);
            writer.WriteStringValue("requestUrl", RequestUrl);
            writer.WriteStringValue("tenantIds", TenantIds);
            writer.WriteStringValue("tenantNames", TenantNames);
        }
    }
}
