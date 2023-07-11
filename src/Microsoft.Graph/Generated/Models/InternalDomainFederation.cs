using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class InternalDomainFederation : SamlOrWsFedProvider, IParsable {
        /// <summary>URL of the endpoint used by active clients when authenticating with federated domains set up for single sign-on in Azure Active Directory (Azure AD). Corresponds to the ActiveLogOnUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveSignInUri {
            get { return BackingStore?.Get<string?>("activeSignInUri"); }
            set { BackingStore?.Set("activeSignInUri", value); }
        }
#nullable restore
#else
        public string ActiveSignInUri {
            get { return BackingStore?.Get<string>("activeSignInUri"); }
            set { BackingStore?.Set("activeSignInUri", value); }
        }
#endif
        /// <summary>Determines whether Azure AD accepts the MFA performed by the federated IdP when a federated user accesses an application that is governed by a conditional access policy that requires MFA. The possible values are: acceptIfMfaDoneByFederatedIdp, enforceMfaByFederatedIdp, rejectMfaByFederatedIdp, unknownFutureValue. For more information, see federatedIdpMfaBehavior values.</summary>
        public Microsoft.Graph.Beta.Models.FederatedIdpMfaBehavior? FederatedIdpMfaBehavior {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FederatedIdpMfaBehavior?>("federatedIdpMfaBehavior"); }
            set { BackingStore?.Set("federatedIdpMfaBehavior", value); }
        }
        /// <summary>If true, when SAML authentication requests are sent to the federated SAML IdP, Azure AD will sign those requests using the OrgID signing key. If false (default), the SAML authentication requests sent to the federated IdP are not signed.</summary>
        public bool? IsSignedAuthenticationRequestRequired {
            get { return BackingStore?.Get<bool?>("isSignedAuthenticationRequestRequired"); }
            set { BackingStore?.Set("isSignedAuthenticationRequestRequired", value); }
        }
        /// <summary>Fallback token signing certificate that is used to sign tokens when the primary signing certificate expires. Formatted as Base64 encoded strings of the public portion of the federated IdP&apos;s token signing certificate. Needs to be compatible with the X509Certificate2 class. Much like the signingCertificate, the nextSigningCertificate property is used if a rollover is required outside of the auto-rollover update, a new federation service is being set up, or if the new token signing certificate is not present in the federation properties after the federation service certificate has been updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextSigningCertificate {
            get { return BackingStore?.Get<string?>("nextSigningCertificate"); }
            set { BackingStore?.Set("nextSigningCertificate", value); }
        }
#nullable restore
#else
        public string NextSigningCertificate {
            get { return BackingStore?.Get<string>("nextSigningCertificate"); }
            set { BackingStore?.Set("nextSigningCertificate", value); }
        }
#endif
        /// <summary>Sets the preferred behavior for the sign-in prompt. The possible values are: translateToFreshPasswordAuthentication, nativeSupport, disabled, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.PromptLoginBehavior? PromptLoginBehavior {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PromptLoginBehavior?>("promptLoginBehavior"); }
            set { BackingStore?.Set("promptLoginBehavior", value); }
        }
        /// <summary>Provides status and timestamp of the last update of the signing certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus? SigningCertificateUpdateStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus?>("signingCertificateUpdateStatus"); }
            set { BackingStore?.Set("signingCertificateUpdateStatus", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus SigningCertificateUpdateStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus>("signingCertificateUpdateStatus"); }
            set { BackingStore?.Set("signingCertificateUpdateStatus", value); }
        }
#endif
        /// <summary>URI that clients are redirected to when they sign out of Azure AD services. Corresponds to the LogOffUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignOutUri {
            get { return BackingStore?.Get<string?>("signOutUri"); }
            set { BackingStore?.Set("signOutUri", value); }
        }
#nullable restore
#else
        public string SignOutUri {
            get { return BackingStore?.Get<string>("signOutUri"); }
            set { BackingStore?.Set("signOutUri", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new internalDomainFederation and sets the default values.
        /// </summary>
        public InternalDomainFederation() : base() {
            OdataType = "#microsoft.graph.internalDomainFederation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InternalDomainFederation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InternalDomainFederation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeSignInUri", n => { ActiveSignInUri = n.GetStringValue(); } },
                {"federatedIdpMfaBehavior", n => { FederatedIdpMfaBehavior = n.GetEnumValue<FederatedIdpMfaBehavior>(); } },
                {"isSignedAuthenticationRequestRequired", n => { IsSignedAuthenticationRequestRequired = n.GetBoolValue(); } },
                {"nextSigningCertificate", n => { NextSigningCertificate = n.GetStringValue(); } },
                {"promptLoginBehavior", n => { PromptLoginBehavior = n.GetEnumValue<PromptLoginBehavior>(); } },
                {"signingCertificateUpdateStatus", n => { SigningCertificateUpdateStatus = n.GetObjectValue<Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus>(Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus.CreateFromDiscriminatorValue); } },
                {"signOutUri", n => { SignOutUri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activeSignInUri", ActiveSignInUri);
            writer.WriteEnumValue<FederatedIdpMfaBehavior>("federatedIdpMfaBehavior", FederatedIdpMfaBehavior);
            writer.WriteBoolValue("isSignedAuthenticationRequestRequired", IsSignedAuthenticationRequestRequired);
            writer.WriteStringValue("nextSigningCertificate", NextSigningCertificate);
            writer.WriteEnumValue<PromptLoginBehavior>("promptLoginBehavior", PromptLoginBehavior);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SigningCertificateUpdateStatus>("signingCertificateUpdateStatus", SigningCertificateUpdateStatus);
            writer.WriteStringValue("signOutUri", SignOutUri);
        }
    }
}
