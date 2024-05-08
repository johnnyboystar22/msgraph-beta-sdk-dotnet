// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class MicrosoftAuthenticatorFeatureSettings : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Determines whether users are able to approve push notifications on other Microsoft applications such as Outlook Mobile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationMethodFeatureConfiguration? CompanionAppAllowedState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration?>("companionAppAllowedState"); }
            set { BackingStore?.Set("companionAppAllowedState", value); }
        }
#nullable restore
#else
        public AuthenticationMethodFeatureConfiguration CompanionAppAllowedState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("companionAppAllowedState"); }
            set { BackingStore?.Set("companionAppAllowedState", value); }
        }
#endif
        /// <summary>Determines whether the user&apos;s Authenticator app shows them the client app they&apos;re signing into.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationMethodFeatureConfiguration? DisplayAppInformationRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration?>("displayAppInformationRequiredState"); }
            set { BackingStore?.Set("displayAppInformationRequiredState", value); }
        }
#nullable restore
#else
        public AuthenticationMethodFeatureConfiguration DisplayAppInformationRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("displayAppInformationRequiredState"); }
            set { BackingStore?.Set("displayAppInformationRequiredState", value); }
        }
#endif
        /// <summary>Determines whether the user&apos;s Authenticator app shows them the geographic location of where the authentication request originated from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationMethodFeatureConfiguration? DisplayLocationInformationRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration?>("displayLocationInformationRequiredState"); }
            set { BackingStore?.Set("displayLocationInformationRequiredState", value); }
        }
#nullable restore
#else
        public AuthenticationMethodFeatureConfiguration DisplayLocationInformationRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("displayLocationInformationRequiredState"); }
            set { BackingStore?.Set("displayLocationInformationRequiredState", value); }
        }
#endif
        /// <summary>Specifies whether the user needs to enter a number in the Authenticator app from the login screen to complete their login. Value is ignored for phone sign-in notifications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationMethodFeatureConfiguration? NumberMatchingRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration?>("numberMatchingRequiredState"); }
            set { BackingStore?.Set("numberMatchingRequiredState", value); }
        }
#nullable restore
#else
        public AuthenticationMethodFeatureConfiguration NumberMatchingRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("numberMatchingRequiredState"); }
            set { BackingStore?.Set("numberMatchingRequiredState", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftAuthenticatorFeatureSettings"/> and sets the default values.
        /// </summary>
        public MicrosoftAuthenticatorFeatureSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MicrosoftAuthenticatorFeatureSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MicrosoftAuthenticatorFeatureSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorFeatureSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"companionAppAllowedState", n => { CompanionAppAllowedState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"displayAppInformationRequiredState", n => { DisplayAppInformationRequiredState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"displayLocationInformationRequiredState", n => { DisplayLocationInformationRequiredState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"numberMatchingRequiredState", n => { NumberMatchingRequiredState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("companionAppAllowedState", CompanionAppAllowedState);
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("displayAppInformationRequiredState", DisplayAppInformationRequiredState);
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("displayLocationInformationRequiredState", DisplayLocationInformationRequiredState);
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("numberMatchingRequiredState", NumberMatchingRequiredState);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
