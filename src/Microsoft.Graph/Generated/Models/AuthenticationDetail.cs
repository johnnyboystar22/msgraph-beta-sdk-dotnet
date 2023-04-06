using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The type of authentication method used to perform this step of authentication. Possible values: Password, SMS, Voice, Authenticator App, Software OATH token, Satisfied by token, Previously satisfied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationMethod {
            get { return BackingStore?.Get<string?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
#nullable restore
#else
        public string AuthenticationMethod {
            get { return BackingStore?.Get<string>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
#endif
        /// <summary>Details about the authentication method used to perform this authentication step. For example, phone number (for SMS and voice), device name (for Authenticator app), and password source (e.g. cloud, AD FS, PTA, PHS).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationMethodDetail {
            get { return BackingStore?.Get<string?>("authenticationMethodDetail"); }
            set { BackingStore?.Set("authenticationMethodDetail", value); }
        }
#nullable restore
#else
        public string AuthenticationMethodDetail {
            get { return BackingStore?.Get<string>("authenticationMethodDetail"); }
            set { BackingStore?.Set("authenticationMethodDetail", value); }
        }
#endif
        /// <summary>Represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AuthenticationStepDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("authenticationStepDateTime"); }
            set { BackingStore?.Set("authenticationStepDateTime", value); }
        }
        /// <summary>The step of authentication that this satisfied. For example, primary authentication, or multi-factor authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationStepRequirement {
            get { return BackingStore?.Get<string?>("authenticationStepRequirement"); }
            set { BackingStore?.Set("authenticationStepRequirement", value); }
        }
#nullable restore
#else
        public string AuthenticationStepRequirement {
            get { return BackingStore?.Get<string>("authenticationStepRequirement"); }
            set { BackingStore?.Set("authenticationStepRequirement", value); }
        }
#endif
        /// <summary>Details about why the step succeeded or failed. For examples, user is blocked, fraud code entered, no phone input - timed out, phone unreachable, or claim in token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationStepResultDetail {
            get { return BackingStore?.Get<string?>("authenticationStepResultDetail"); }
            set { BackingStore?.Set("authenticationStepResultDetail", value); }
        }
#nullable restore
#else
        public string AuthenticationStepResultDetail {
            get { return BackingStore?.Get<string>("authenticationStepResultDetail"); }
            set { BackingStore?.Set("authenticationStepResultDetail", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Indicates the status of the authentication step. Possible values: succeeded, failed.</summary>
        public bool? Succeeded {
            get { return BackingStore?.Get<bool?>("succeeded"); }
            set { BackingStore?.Set("succeeded", value); }
        }
        /// <summary>
        /// Instantiates a new authenticationDetail and sets the default values.
        /// </summary>
        public AuthenticationDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetStringValue(); } },
                {"authenticationMethodDetail", n => { AuthenticationMethodDetail = n.GetStringValue(); } },
                {"authenticationStepDateTime", n => { AuthenticationStepDateTime = n.GetDateTimeOffsetValue(); } },
                {"authenticationStepRequirement", n => { AuthenticationStepRequirement = n.GetStringValue(); } },
                {"authenticationStepResultDetail", n => { AuthenticationStepResultDetail = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"succeeded", n => { Succeeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("authenticationMethodDetail", AuthenticationMethodDetail);
            writer.WriteDateTimeOffsetValue("authenticationStepDateTime", AuthenticationStepDateTime);
            writer.WriteStringValue("authenticationStepRequirement", AuthenticationStepRequirement);
            writer.WriteStringValue("authenticationStepResultDetail", AuthenticationStepResultDetail);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("succeeded", Succeeded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
