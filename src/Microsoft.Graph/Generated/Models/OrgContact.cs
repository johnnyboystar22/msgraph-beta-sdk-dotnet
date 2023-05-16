using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OrgContact : DirectoryObject, IParsable {
        /// <summary>Postal addresses for this organizational contact. For now a contact can only have one physical address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PhysicalOfficeAddress>? Addresses {
            get { return BackingStore?.Get<List<PhysicalOfficeAddress>?>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
#nullable restore
#else
        public List<PhysicalOfficeAddress> Addresses {
            get { return BackingStore?.Get<List<PhysicalOfficeAddress>>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
#endif
        /// <summary>Name of the company that this organizational contact belong to. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
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
        /// <summary>The name for the department in which the contact works. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public string Department {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The contact&apos;s direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? DirectReports {
            get { return BackingStore?.Get<List<DirectoryObject>?>("directReports"); }
            set { BackingStore?.Set("directReports", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> DirectReports {
            get { return BackingStore?.Get<List<DirectoryObject>>("directReports"); }
            set { BackingStore?.Set("directReports", value); }
        }
#endif
        /// <summary>Display name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values), $search, and $orderBy.</summary>
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
        /// <summary>First name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName {
            get { return BackingStore?.Get<string?>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#nullable restore
#else
        public string GivenName {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#endif
        /// <summary>Job title for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The SMTP address for the contact, for example, &apos;jeff@contoso.onmicrosoft.com&apos;. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mail {
            get { return BackingStore?.Get<string?>("mail"); }
            set { BackingStore?.Set("mail", value); }
        }
#nullable restore
#else
        public string Mail {
            get { return BackingStore?.Get<string>("mail"); }
            set { BackingStore?.Set("mail", value); }
        }
#endif
        /// <summary>Email alias (portion of email address pre-pending the @ symbol) for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailNickname {
            get { return BackingStore?.Get<string?>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#nullable restore
#else
        public string MailNickname {
            get { return BackingStore?.Get<string>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#endif
        /// <summary>The user or contact that is this contact&apos;s manager. Read-only. Supports $expand and $filter (eq) by id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Manager {
            get { return BackingStore?.Get<DirectoryObject?>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#nullable restore
#else
        public DirectoryObject Manager {
            get { return BackingStore?.Get<DirectoryObject>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#endif
        /// <summary>Groups that this contact is a member of. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#endif
        /// <summary>Date and time when this organizational contact was last synchronized from on-premises AD. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onPremisesLastSyncDateTime"); }
            set { BackingStore?.Set("onPremisesLastSyncDateTime", value); }
        }
        /// <summary>List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not for category and propertyCausingError), /$count eq 0, /$count ne 0.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesProvisioningError>? OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>?>("onPremisesProvisioningErrors"); }
            set { BackingStore?.Set("onPremisesProvisioningErrors", value); }
        }
#nullable restore
#else
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>>("onPremisesProvisioningErrors"); }
            set { BackingStore?.Set("onPremisesProvisioningErrors", value); }
        }
#endif
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).  Supports $filter (eq, ne, not, in, and eq for null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>("onPremisesSyncEnabled"); }
            set { BackingStore?.Set("onPremisesSyncEnabled", value); }
        }
        /// <summary>List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection. Supports $filter (eq, ne, not, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Phone>? Phones {
            get { return BackingStore?.Get<List<Phone>?>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#nullable restore
#else
        public List<Phone> Phones {
            get { return BackingStore?.Get<List<Phone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#endif
        /// <summary>For example: &apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;. The any operator is required for filter expressions on multi-valued properties. Supports $filter (eq, not, ge, le, startsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProxyAddresses {
            get { return BackingStore?.Get<List<string>?>("proxyAddresses"); }
            set { BackingStore?.Set("proxyAddresses", value); }
        }
#nullable restore
#else
        public List<string> ProxyAddresses {
            get { return BackingStore?.Get<List<string>>("proxyAddresses"); }
            set { BackingStore?.Set("proxyAddresses", value); }
        }
#endif
        /// <summary>Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from an orgContact object .  Supports $filter (eq, not, for isResolved and serviceInstance).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServiceProvisioningError>? ServiceProvisioningErrors {
            get { return BackingStore?.Get<List<ServiceProvisioningError>?>("serviceProvisioningErrors"); }
            set { BackingStore?.Set("serviceProvisioningErrors", value); }
        }
#nullable restore
#else
        public List<ServiceProvisioningError> ServiceProvisioningErrors {
            get { return BackingStore?.Get<List<ServiceProvisioningError>>("serviceProvisioningErrors"); }
            set { BackingStore?.Set("serviceProvisioningErrors", value); }
        }
#endif
        /// <summary>Last name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname {
            get { return BackingStore?.Get<string?>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#nullable restore
#else
        public string Surname {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#endif
        /// <summary>The transitiveMemberOf property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#endif
        /// <summary>The transitive reports for a contact. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveReports {
            get { return BackingStore?.Get<List<DirectoryObject>?>("transitiveReports"); }
            set { BackingStore?.Set("transitiveReports", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> TransitiveReports {
            get { return BackingStore?.Get<List<DirectoryObject>>("transitiveReports"); }
            set { BackingStore?.Set("transitiveReports", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new OrgContact and sets the default values.
        /// </summary>
        public OrgContact() : base() {
            OdataType = "#microsoft.graph.orgContact";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OrgContact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrgContact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addresses", n => { Addresses = n.GetCollectionOfObjectValues<PhysicalOfficeAddress>(PhysicalOfficeAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"directReports", n => { DirectReports = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"manager", n => { Manager = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>(OnPremisesProvisioningError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue)?.ToList(); } },
                {"proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"serviceProvisioningErrors", n => { ServiceProvisioningErrors = n.GetCollectionOfObjectValues<ServiceProvisioningError>(ServiceProvisioningError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitiveReports", n => { TransitiveReports = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PhysicalOfficeAddress>("addresses", Addresses);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("mail", Mail);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteObjectValue<DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<ServiceProvisioningError>("serviceProvisioningErrors", ServiceProvisioningErrors);
            writer.WriteStringValue("surname", Surname);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveReports", TransitiveReports);
        }
    }
}
