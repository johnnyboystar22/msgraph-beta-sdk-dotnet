// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageSubject : Entity, IParsable {
        /// <summary>Not Supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AltSecId {
            get { return BackingStore?.Get<string?>("altSecId"); }
            set { BackingStore?.Set("altSecId", value); }
        }
#nullable restore
#else
        public string AltSecId {
            get { return BackingStore?.Get<string>("altSecId"); }
            set { BackingStore?.Set("altSecId", value); }
        }
#endif
        /// <summary>The cleanupScheduledDateTime property</summary>
        public DateTimeOffset? CleanupScheduledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("cleanupScheduledDateTime"); }
            set { BackingStore?.Set("cleanupScheduledDateTime", value); }
        }
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ConnectedOrganization? ConnectedOrganization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectedOrganization?>("connectedOrganization"); }
            set { BackingStore?.Set("connectedOrganization", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ConnectedOrganization ConnectedOrganization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectedOrganization>("connectedOrganization"); }
            set { BackingStore?.Set("connectedOrganization", value); }
        }
#endif
        /// <summary>The identifier of the connected organization of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectedOrganizationId {
            get { return BackingStore?.Get<string?>("connectedOrganizationId"); }
            set { BackingStore?.Set("connectedOrganizationId", value); }
        }
#nullable restore
#else
        public string ConnectedOrganizationId {
            get { return BackingStore?.Get<string>("connectedOrganizationId"); }
            set { BackingStore?.Set("connectedOrganizationId", value); }
        }
#endif
        /// <summary>The display name of the subject.</summary>
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
        /// <summary>The email address of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant. Alternate key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId {
            get { return BackingStore?.Get<string?>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#nullable restore
#else
        public string ObjectId {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#endif
        /// <summary>The onPremisesSecurityIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string?>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#endif
        /// <summary>The principal name, if known, of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalName {
            get { return BackingStore?.Get<string?>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#nullable restore
#else
        public string PrincipalName {
            get { return BackingStore?.Get<string>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#endif
        /// <summary>The lifecycle of the subject user, if a guest. The possible values are: notDefined, notGoverned, governed, unknownFutureValue.</summary>
        public AccessPackageSubjectLifecycle? SubjectLifecycle {
            get { return BackingStore?.Get<AccessPackageSubjectLifecycle?>("subjectLifecycle"); }
            set { BackingStore?.Set("subjectLifecycle", value); }
        }
        /// <summary>The resource type of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"altSecId", n => { AltSecId = n.GetStringValue(); } },
                {"cleanupScheduledDateTime", n => { CleanupScheduledDateTime = n.GetDateTimeOffsetValue(); } },
                {"connectedOrganization", n => { ConnectedOrganization = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConnectedOrganization>(Microsoft.Graph.Beta.Models.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                {"connectedOrganizationId", n => { ConnectedOrganizationId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"subjectLifecycle", n => { SubjectLifecycle = n.GetEnumValue<AccessPackageSubjectLifecycle>(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("altSecId", AltSecId);
            writer.WriteDateTimeOffsetValue("cleanupScheduledDateTime", CleanupScheduledDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("connectedOrganizationId", ConnectedOrganizationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteEnumValue<AccessPackageSubjectLifecycle>("subjectLifecycle", SubjectLifecycle);
            writer.WriteStringValue("type", Type);
        }
    }
}
