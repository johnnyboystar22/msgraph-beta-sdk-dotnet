using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkUserIdentity : Identity, IParsable {
        /// <summary>Type of user. Possible values are: aadUser, onPremiseAadUser, anonymousGuest, federatedUser, personalMicrosoftAccountUser, skypeUser, phoneUser, and unknownFutureValue.</summary>
        public TeamworkUserIdentityType? UserIdentityType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkUserIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkUserIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"userIdentityType", (o,n) => { (o as TeamworkUserIdentity).UserIdentityType = n.GetEnumValue<TeamworkUserIdentityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamworkUserIdentityType>("userIdentityType", UserIdentityType);
        }
    }
}
