// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants
{
    #pragma warning disable CS1591
    public class TenantTag : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier for the account that created the tenant tag. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId
        {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
#else
        public string CreatedByUserId
        {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The date and time when the tenant tag was created. Required. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time when the tenant tag was deleted. Required. Read-only.</summary>
        public DateTimeOffset? DeletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The description for the tenant tag. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name for the tenant tag. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The identifier for the account that lasted on the tenant tag. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId
        {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
#else
        public string LastActionByUserId
        {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The date and time the last action was performed against the tenant tag. Optional. Read-only.</summary>
        public DateTimeOffset? LastActionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The collection of managed tenants associated with the tenant tag. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo>? Tenants
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo>?>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo> Tenants
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo>>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ManagedTenants.TenantTag"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ManagedTenants.TenantTag CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ManagedTenants.TenantTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                { "lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "tenants", n => { Tenants = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo>(Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedTenants.TenantInfo>("tenants", Tenants);
        }
    }
}
