using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class B2cIdentityUserFlow : IdentityUserFlow, IParsable {
        /// <summary>Configuration for enabling an API connector for use as part of the user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserFlowApiConnectorConfiguration? ApiConnectorConfiguration {
            get { return BackingStore?.Get<UserFlowApiConnectorConfiguration?>("apiConnectorConfiguration"); }
            set { BackingStore?.Set("apiConnectorConfiguration", value); }
        }
#nullable restore
#else
        public UserFlowApiConnectorConfiguration ApiConnectorConfiguration {
            get { return BackingStore?.Get<UserFlowApiConnectorConfiguration>("apiConnectorConfiguration"); }
            set { BackingStore?.Set("apiConnectorConfiguration", value); }
        }
#endif
        /// <summary>Indicates the default language of the b2cIdentityUserFlow that is used when no ui_locale tag is specified in the request. This field is RFC 5646 compliant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLanguageTag {
            get { return BackingStore?.Get<string?>("defaultLanguageTag"); }
            set { BackingStore?.Set("defaultLanguageTag", value); }
        }
#nullable restore
#else
        public string DefaultLanguageTag {
            get { return BackingStore?.Get<string>("defaultLanguageTag"); }
            set { BackingStore?.Set("defaultLanguageTag", value); }
        }
#endif
        /// <summary>The identityProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProvider>? IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProvider>?>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#nullable restore
#else
        public List<IdentityProvider> IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProvider>>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#endif
        /// <summary>The property that determines whether language customization is enabled within the B2C user flow. Language customization is not enabled by default for B2C user flows.</summary>
        public bool? IsLanguageCustomizationEnabled {
            get { return BackingStore?.Get<bool?>("isLanguageCustomizationEnabled"); }
            set { BackingStore?.Set("isLanguageCustomizationEnabled", value); }
        }
        /// <summary>The languages supported for customization within the user flow. Language customization is not enabled by default in B2C user flows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserFlowLanguageConfiguration>? Languages {
            get { return BackingStore?.Get<List<UserFlowLanguageConfiguration>?>("languages"); }
            set { BackingStore?.Set("languages", value); }
        }
#nullable restore
#else
        public List<UserFlowLanguageConfiguration> Languages {
            get { return BackingStore?.Get<List<UserFlowLanguageConfiguration>>("languages"); }
            set { BackingStore?.Set("languages", value); }
        }
#endif
        /// <summary>The user attribute assignments included in the user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlowAttributeAssignment>? UserAttributeAssignments {
            get { return BackingStore?.Get<List<IdentityUserFlowAttributeAssignment>?>("userAttributeAssignments"); }
            set { BackingStore?.Set("userAttributeAssignments", value); }
        }
#nullable restore
#else
        public List<IdentityUserFlowAttributeAssignment> UserAttributeAssignments {
            get { return BackingStore?.Get<List<IdentityUserFlowAttributeAssignment>>("userAttributeAssignments"); }
            set { BackingStore?.Set("userAttributeAssignments", value); }
        }
#endif
        /// <summary>The userFlowIdentityProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? UserFlowIdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>?>("userFlowIdentityProviders"); }
            set { BackingStore?.Set("userFlowIdentityProviders", value); }
        }
#nullable restore
#else
        public List<IdentityProviderBase> UserFlowIdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>>("userFlowIdentityProviders"); }
            set { BackingStore?.Set("userFlowIdentityProviders", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new B2cIdentityUserFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new B2cIdentityUserFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apiConnectorConfiguration", n => { ApiConnectorConfiguration = n.GetObjectValue<UserFlowApiConnectorConfiguration>(UserFlowApiConnectorConfiguration.CreateFromDiscriminatorValue); } },
                {"defaultLanguageTag", n => { DefaultLanguageTag = n.GetStringValue(); } },
                {"identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProvider>(IdentityProvider.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isLanguageCustomizationEnabled", n => { IsLanguageCustomizationEnabled = n.GetBoolValue(); } },
                {"languages", n => { Languages = n.GetCollectionOfObjectValues<UserFlowLanguageConfiguration>(UserFlowLanguageConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userAttributeAssignments", n => { UserAttributeAssignments = n.GetCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>(IdentityUserFlowAttributeAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userFlowIdentityProviders", n => { UserFlowIdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserFlowApiConnectorConfiguration>("apiConnectorConfiguration", ApiConnectorConfiguration);
            writer.WriteStringValue("defaultLanguageTag", DefaultLanguageTag);
            writer.WriteCollectionOfObjectValues<IdentityProvider>("identityProviders", IdentityProviders);
            writer.WriteBoolValue("isLanguageCustomizationEnabled", IsLanguageCustomizationEnabled);
            writer.WriteCollectionOfObjectValues<UserFlowLanguageConfiguration>("languages", Languages);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>("userAttributeAssignments", UserAttributeAssignments);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("userFlowIdentityProviders", UserFlowIdentityProviders);
        }
    }
}
