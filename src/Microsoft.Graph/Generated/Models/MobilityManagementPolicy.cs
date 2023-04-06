using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MobilityManagementPolicy : Entity, IParsable {
        /// <summary>Indicates the user scope of the mobility management policy. Possible values are: none, all, selected.</summary>
        public PolicyScope? AppliesTo {
            get { return BackingStore?.Get<PolicyScope?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
        /// <summary>Compliance URL of the mobility management application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComplianceUrl {
            get { return BackingStore?.Get<string?>("complianceUrl"); }
            set { BackingStore?.Set("complianceUrl", value); }
        }
#nullable restore
#else
        public string ComplianceUrl {
            get { return BackingStore?.Get<string>("complianceUrl"); }
            set { BackingStore?.Set("complianceUrl", value); }
        }
#endif
        /// <summary>Description of the mobility management application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Discovery URL of the mobility management application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiscoveryUrl {
            get { return BackingStore?.Get<string?>("discoveryUrl"); }
            set { BackingStore?.Set("discoveryUrl", value); }
        }
#nullable restore
#else
        public string DiscoveryUrl {
            get { return BackingStore?.Get<string>("discoveryUrl"); }
            set { BackingStore?.Set("discoveryUrl", value); }
        }
#endif
        /// <summary>Display name of the mobility management application.</summary>
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
        /// <summary>Azure AD groups under the scope of the mobility management application if appliesTo is selected</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Group>? IncludedGroups {
            get { return BackingStore?.Get<List<Group>?>("includedGroups"); }
            set { BackingStore?.Set("includedGroups", value); }
        }
#nullable restore
#else
        public List<Group> IncludedGroups {
            get { return BackingStore?.Get<List<Group>>("includedGroups"); }
            set { BackingStore?.Set("includedGroups", value); }
        }
#endif
        /// <summary>Whether policy is valid. Invalid policies may not be updated and should be deleted.</summary>
        public bool? IsValid {
            get { return BackingStore?.Get<bool?>("isValid"); }
            set { BackingStore?.Set("isValid", value); }
        }
        /// <summary>Terms of Use URL of the mobility management application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TermsOfUseUrl {
            get { return BackingStore?.Get<string?>("termsOfUseUrl"); }
            set { BackingStore?.Set("termsOfUseUrl", value); }
        }
#nullable restore
#else
        public string TermsOfUseUrl {
            get { return BackingStore?.Get<string>("termsOfUseUrl"); }
            set { BackingStore?.Set("termsOfUseUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobilityManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobilityManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliesTo", n => { AppliesTo = n.GetEnumValue<PolicyScope>(); } },
                {"complianceUrl", n => { ComplianceUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoveryUrl", n => { DiscoveryUrl = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"includedGroups", n => { IncludedGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isValid", n => { IsValid = n.GetBoolValue(); } },
                {"termsOfUseUrl", n => { TermsOfUseUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PolicyScope>("appliesTo", AppliesTo);
            writer.WriteStringValue("complianceUrl", ComplianceUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("discoveryUrl", DiscoveryUrl);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Group>("includedGroups", IncludedGroups);
            writer.WriteBoolValue("isValid", IsValid);
            writer.WriteStringValue("termsOfUseUrl", TermsOfUseUrl);
        }
    }
}
