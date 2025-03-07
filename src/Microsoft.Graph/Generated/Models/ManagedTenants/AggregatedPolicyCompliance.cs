// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants
{
    #pragma warning disable CS1591
    public class AggregatedPolicyCompliance : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identifier for the device compliance policy. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompliancePolicyId
        {
            get { return BackingStore?.Get<string?>("compliancePolicyId"); }
            set { BackingStore?.Set("compliancePolicyId", value); }
        }
#nullable restore
#else
        public string CompliancePolicyId
        {
            get { return BackingStore?.Get<string>("compliancePolicyId"); }
            set { BackingStore?.Set("compliancePolicyId", value); }
        }
#endif
        /// <summary>Name of the device compliance policy. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompliancePolicyName
        {
            get { return BackingStore?.Get<string?>("compliancePolicyName"); }
            set { BackingStore?.Set("compliancePolicyName", value); }
        }
#nullable restore
#else
        public string CompliancePolicyName
        {
            get { return BackingStore?.Get<string>("compliancePolicyName"); }
            set { BackingStore?.Set("compliancePolicyName", value); }
        }
#endif
        /// <summary>Platform for the device compliance policy. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, androidAOSP, all. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompliancePolicyPlatform
        {
            get { return BackingStore?.Get<string?>("compliancePolicyPlatform"); }
            set { BackingStore?.Set("compliancePolicyPlatform", value); }
        }
#nullable restore
#else
        public string CompliancePolicyPlatform
        {
            get { return BackingStore?.Get<string>("compliancePolicyPlatform"); }
            set { BackingStore?.Set("compliancePolicyPlatform", value); }
        }
#endif
        /// <summary>The type of compliance policy. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompliancePolicyType
        {
            get { return BackingStore?.Get<string?>("compliancePolicyType"); }
            set { BackingStore?.Set("compliancePolicyType", value); }
        }
#nullable restore
#else
        public string CompliancePolicyType
        {
            get { return BackingStore?.Get<string>("compliancePolicyType"); }
            set { BackingStore?.Set("compliancePolicyType", value); }
        }
#endif
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The number of devices that are in a compliant status. Optional. Read-only.</summary>
        public long? NumberOfCompliantDevices
        {
            get { return BackingStore?.Get<long?>("numberOfCompliantDevices"); }
            set { BackingStore?.Set("numberOfCompliantDevices", value); }
        }
        /// <summary>The number of devices that are in an error status. Optional. Read-only.</summary>
        public long? NumberOfErrorDevices
        {
            get { return BackingStore?.Get<long?>("numberOfErrorDevices"); }
            set { BackingStore?.Set("numberOfErrorDevices", value); }
        }
        /// <summary>The number of device that are in a non-compliant status. Optional. Read-only.</summary>
        public long? NumberOfNonCompliantDevices
        {
            get { return BackingStore?.Get<long?>("numberOfNonCompliantDevices"); }
            set { BackingStore?.Set("numberOfNonCompliantDevices", value); }
        }
        /// <summary>The date and time the device policy was last modified. Optional. Read-only.</summary>
        public DateTimeOffset? PolicyModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("policyModifiedDateTime"); }
            set { BackingStore?.Set("policyModifiedDateTime", value); }
        }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName
        {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName
        {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ManagedTenants.AggregatedPolicyCompliance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ManagedTenants.AggregatedPolicyCompliance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ManagedTenants.AggregatedPolicyCompliance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "compliancePolicyId", n => { CompliancePolicyId = n.GetStringValue(); } },
                { "compliancePolicyName", n => { CompliancePolicyName = n.GetStringValue(); } },
                { "compliancePolicyPlatform", n => { CompliancePolicyPlatform = n.GetStringValue(); } },
                { "compliancePolicyType", n => { CompliancePolicyType = n.GetStringValue(); } },
                { "lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                { "numberOfCompliantDevices", n => { NumberOfCompliantDevices = n.GetLongValue(); } },
                { "numberOfErrorDevices", n => { NumberOfErrorDevices = n.GetLongValue(); } },
                { "numberOfNonCompliantDevices", n => { NumberOfNonCompliantDevices = n.GetLongValue(); } },
                { "policyModifiedDateTime", n => { PolicyModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteStringValue("compliancePolicyId", CompliancePolicyId);
            writer.WriteStringValue("compliancePolicyName", CompliancePolicyName);
            writer.WriteStringValue("compliancePolicyPlatform", CompliancePolicyPlatform);
            writer.WriteStringValue("compliancePolicyType", CompliancePolicyType);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteLongValue("numberOfCompliantDevices", NumberOfCompliantDevices);
            writer.WriteLongValue("numberOfErrorDevices", NumberOfErrorDevices);
            writer.WriteLongValue("numberOfNonCompliantDevices", NumberOfNonCompliantDevices);
            writer.WriteDateTimeOffsetValue("policyModifiedDateTime", PolicyModifiedDateTime);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
