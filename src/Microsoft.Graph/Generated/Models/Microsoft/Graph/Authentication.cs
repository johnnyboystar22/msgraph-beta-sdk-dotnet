using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Authentication : Entity, IParsable {
        public List<EmailAuthenticationMethod> EmailMethods { get; set; }
        public List<Fido2AuthenticationMethod> Fido2Methods { get; set; }
        public List<AuthenticationMethod> Methods { get; set; }
        public List<MicrosoftAuthenticatorAuthenticationMethod> MicrosoftAuthenticatorMethods { get; set; }
        public List<LongRunningOperation> Operations { get; set; }
        public List<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> PasswordlessMicrosoftAuthenticatorMethods { get; set; }
        public List<PasswordAuthenticationMethod> PasswordMethods { get; set; }
        public List<PhoneAuthenticationMethod> PhoneMethods { get; set; }
        public List<SoftwareOathAuthenticationMethod> SoftwareOathMethods { get; set; }
        public List<TemporaryAccessPassAuthenticationMethod> TemporaryAccessPassMethods { get; set; }
        public List<WindowsHelloForBusinessAuthenticationMethod> WindowsHelloForBusinessMethods { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Authentication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Authentication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"emailMethods", (o,n) => { (o as Authentication).EmailMethods = n.GetCollectionOfObjectValues<EmailAuthenticationMethod>(EmailAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"fido2Methods", (o,n) => { (o as Authentication).Fido2Methods = n.GetCollectionOfObjectValues<Fido2AuthenticationMethod>(Fido2AuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"methods", (o,n) => { (o as Authentication).Methods = n.GetCollectionOfObjectValues<AuthenticationMethod>(AuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftAuthenticatorMethods", (o,n) => { (o as Authentication).MicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>(MicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", (o,n) => { (o as Authentication).Operations = n.GetCollectionOfObjectValues<LongRunningOperation>(LongRunningOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordlessMicrosoftAuthenticatorMethods", (o,n) => { (o as Authentication).PasswordlessMicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>(PasswordlessMicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordMethods", (o,n) => { (o as Authentication).PasswordMethods = n.GetCollectionOfObjectValues<PasswordAuthenticationMethod>(PasswordAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"phoneMethods", (o,n) => { (o as Authentication).PhoneMethods = n.GetCollectionOfObjectValues<PhoneAuthenticationMethod>(PhoneAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"softwareOathMethods", (o,n) => { (o as Authentication).SoftwareOathMethods = n.GetCollectionOfObjectValues<SoftwareOathAuthenticationMethod>(SoftwareOathAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"temporaryAccessPassMethods", (o,n) => { (o as Authentication).TemporaryAccessPassMethods = n.GetCollectionOfObjectValues<TemporaryAccessPassAuthenticationMethod>(TemporaryAccessPassAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsHelloForBusinessMethods", (o,n) => { (o as Authentication).WindowsHelloForBusinessMethods = n.GetCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>(WindowsHelloForBusinessAuthenticationMethod.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EmailAuthenticationMethod>("emailMethods", EmailMethods);
            writer.WriteCollectionOfObjectValues<Fido2AuthenticationMethod>("fido2Methods", Fido2Methods);
            writer.WriteCollectionOfObjectValues<AuthenticationMethod>("methods", Methods);
            writer.WriteCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethod>("microsoftAuthenticatorMethods", MicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<LongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>("passwordlessMicrosoftAuthenticatorMethods", PasswordlessMicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<PasswordAuthenticationMethod>("passwordMethods", PasswordMethods);
            writer.WriteCollectionOfObjectValues<PhoneAuthenticationMethod>("phoneMethods", PhoneMethods);
            writer.WriteCollectionOfObjectValues<SoftwareOathAuthenticationMethod>("softwareOathMethods", SoftwareOathMethods);
            writer.WriteCollectionOfObjectValues<TemporaryAccessPassAuthenticationMethod>("temporaryAccessPassMethods", TemporaryAccessPassMethods);
            writer.WriteCollectionOfObjectValues<WindowsHelloForBusinessAuthenticationMethod>("windowsHelloForBusinessMethods", WindowsHelloForBusinessMethods);
        }
    }
}
