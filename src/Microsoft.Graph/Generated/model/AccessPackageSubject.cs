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
    /// The type Access Package Subject.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessPackageSubject>))]
    public partial class AccessPackageSubject : Entity
    {
    
        /// <summary>
        /// Gets or sets alt sec id.
        /// Not Supported.
        /// </summary>
        [JsonPropertyName("altSecId")]
        public string AltSecId { get; set; }
    
        /// <summary>
        /// Gets or sets cleanup scheduled date time.
        /// </summary>
        [JsonPropertyName("cleanupScheduledDateTime")]
        public DateTimeOffset? CleanupScheduledDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets connected organization id.
        /// The identifier of the connected organization of the subject.
        /// </summary>
        [JsonPropertyName("connectedOrganizationId")]
        public string ConnectedOrganizationId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the subject.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// The email address of the subject.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets object id.
        /// The object identifier of the subject. null if the subject is not yet a user in the tenant. Alternate key.
        /// </summary>
        [JsonPropertyName("objectId")]
        public string ObjectId { get; set; }
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// </summary>
        [JsonPropertyName("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets principal name.
        /// The principal name, if known, of the subject.
        /// </summary>
        [JsonPropertyName("principalName")]
        public string PrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets subject lifecycle.
        /// The lifecycle of the subject user, if a guest. The possible values are: notDefined, notGoverned, governed, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("subjectLifecycle")]
        public AccessPackageSubjectLifecycle? SubjectLifecycle { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The resource type of the subject.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets connected organization.
        /// The connected organization of the subject. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("connectedOrganization")]
        public ConnectedOrganization ConnectedOrganization { get; set; }
    
    }
}

