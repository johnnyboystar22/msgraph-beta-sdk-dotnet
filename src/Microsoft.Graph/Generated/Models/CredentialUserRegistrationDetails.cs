using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CredentialUserRegistrationDetails : Entity, IParsable {
        /// <summary>Represents the authentication method that the user has registered. Possible values are: email, mobilePhone, officePhone,  securityQuestion (only used for self-service password reset), appNotification,  appCode, alternateMobilePhone (supported only in registration),  fido,  appPassword,  unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RegistrationAuthMethod?>? AuthMethods {
            get { return BackingStore?.Get<List<RegistrationAuthMethod?>?>("authMethods"); }
            set { BackingStore?.Set("authMethods", value); }
        }
#nullable restore
#else
        public List<RegistrationAuthMethod?> AuthMethods {
            get { return BackingStore?.Get<List<RegistrationAuthMethod?>>("authMethods"); }
            set { BackingStore?.Set("authMethods", value); }
        }
#endif
        /// <summary>Indicates whether the user is ready to perform self-service password reset or MFA.</summary>
        public bool? IsCapable {
            get { return BackingStore?.Get<bool?>("isCapable"); }
            set { BackingStore?.Set("isCapable", value); }
        }
        /// <summary>Indicates whether the user enabled to perform self-service password reset.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Indicates whether the user is registered for MFA.</summary>
        public bool? IsMfaRegistered {
            get { return BackingStore?.Get<bool?>("isMfaRegistered"); }
            set { BackingStore?.Set("isMfaRegistered", value); }
        }
        /// <summary>Indicates whether the user has registered any authentication methods for self-service password reset.</summary>
        public bool? IsRegistered {
            get { return BackingStore?.Get<bool?>("isRegistered"); }
            set { BackingStore?.Set("isRegistered", value); }
        }
        /// <summary>Provides the user name of the corresponding user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>Provides the user principal name of the corresponding user.</summary>
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CredentialUserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authMethods", n => { AuthMethods = n.GetCollectionOfEnumValues<RegistrationAuthMethod>()?.ToList(); } },
                {"isCapable", n => { IsCapable = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isRegistered", n => { IsRegistered = n.GetBoolValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<RegistrationAuthMethod>("authMethods", AuthMethods);
            writer.WriteBoolValue("isCapable", IsCapable);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isRegistered", IsRegistered);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
