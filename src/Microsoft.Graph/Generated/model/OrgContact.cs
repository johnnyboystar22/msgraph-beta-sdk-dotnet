// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Org Contact.
    /// </summary>
    public partial class OrgContact : DirectoryObject
    {
    
        ///<summary>
        /// The OrgContact constructor
        ///</summary>
        public OrgContact()
        {
            this.ODataType = "microsoft.graph.orgContact";
        }

        /// <summary>
        /// Gets or sets addresses.
        /// Postal addresses for this organizational contact. For now a contact can only have one physical address.
        /// </summary>
        [JsonPropertyName("addresses")]
        public IEnumerable<PhysicalOfficeAddress> Addresses { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// Name of the company that this organizational contact belong to. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
        /// </summary>
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The name for the department in which the contact works. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// First name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// Job title for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
        /// </summary>
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the contact, for example, 'jeff@contoso.onmicrosoft.com'. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
        /// </summary>
        [JsonPropertyName("mail")]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// Email alias (portion of email address pre-pending the @ symbol) for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
        /// </summary>
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Date and time when this organizational contact was last synchronized from on-premises AD. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, not, ge, le, in).
        /// </summary>
        [JsonPropertyName("onPremisesLastSyncDateTime")]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises provisioning errors.
        /// List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not).
        /// </summary>
        [JsonPropertyName("onPremisesProvisioningErrors")]
        public IEnumerable<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).  Supports $filter (eq, ne, not, in, and eq on null values).
        /// </summary>
        [JsonPropertyName("onPremisesSyncEnabled")]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection. Supports $filter (eq, ne, not, in).
        /// </summary>
        [JsonPropertyName("phones")]
        public IEnumerable<Phone> Phones { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// For example: 'SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'. The any operator is required for filter expressions on multi-valued properties. Supports $filter (eq, not, ge, le, startsWith, and counting empty collections).
        /// </summary>
        [JsonPropertyName("proxyAddresses")]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// Last name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets direct reports.
        /// The contact's direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("directReports")]
        public IOrgContactDirectReportsCollectionWithReferencesPage DirectReports { get; set; }

        /// <summary>
        /// Gets or sets directReportsNextLink.
        /// </summary>
        [JsonPropertyName("directReports@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DirectReportsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// The user or contact that is this contact's manager. Read-only. Supports $expand.
        /// </summary>
        [JsonPropertyName("manager")]
        public DirectoryObject Manager { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// Groups that this contact is a member of. Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("memberOf")]
        public IOrgContactMemberOfCollectionWithReferencesPage MemberOf { get; set; }

        /// <summary>
        /// Gets or sets memberOfNextLink.
        /// </summary>
        [JsonPropertyName("memberOf@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf")]
        public IOrgContactTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }

        /// <summary>
        /// Gets or sets transitiveMemberOfNextLink.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TransitiveMemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive reports.
        /// The transitive reports for a contact. Read-only.
        /// </summary>
        [JsonPropertyName("transitiveReports")]
        public IOrgContactTransitiveReportsCollectionWithReferencesPage TransitiveReports { get; set; }

        /// <summary>
        /// Gets or sets transitiveReportsNextLink.
        /// </summary>
        [JsonPropertyName("transitiveReports@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TransitiveReportsNextLink { get; set; }
    
    }
}

