using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UserSecurityProfile : Entity, IParsable {
        /// <summary>The accounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserAccount>? Accounts {
            get { return BackingStore?.Get<List<UserAccount>?>("accounts"); }
            set { BackingStore?.Set("accounts", value); }
        }
#nullable restore
#else
        public List<UserAccount> Accounts {
            get { return BackingStore?.Get<List<UserAccount>>("accounts"); }
            set { BackingStore?.Set("accounts", value); }
        }
#endif
        /// <summary>The azureSubscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureSubscriptionId {
            get { return BackingStore?.Get<string?>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#nullable restore
#else
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#endif
        /// <summary>The azureTenantId property</summary>
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
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The riskScore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore {
            get { return BackingStore?.Get<string?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#nullable restore
#else
        public string RiskScore {
            get { return BackingStore?.Get<string>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The userPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The vendorInformation property</summary>
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
        public static new UserSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accounts", n => { Accounts = n.GetCollectionOfObjectValues<UserAccount>(UserAccount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<UserAccount>("accounts", Accounts);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
