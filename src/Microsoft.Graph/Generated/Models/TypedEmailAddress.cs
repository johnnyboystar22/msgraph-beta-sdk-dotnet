using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TypedEmailAddress : EmailAddress, IParsable {
        /// <summary>To specify a custom type of email address, set type to other, and assign otherLabel to a custom string. For example, you may use a specific email address for your volunteer activities. Set type to other, and set otherLabel to a custom string such as Volunteer work.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OtherLabel {
            get { return BackingStore?.Get<string?>("otherLabel"); }
            set { BackingStore?.Set("otherLabel", value); }
        }
#nullable restore
#else
        public string OtherLabel {
            get { return BackingStore?.Get<string>("otherLabel"); }
            set { BackingStore?.Set("otherLabel", value); }
        }
#endif
        /// <summary>The type of email address. Possible values are: unknown, work, personal, main, other. The default value is unknown, which means address has not been set as a specific type.</summary>
        public EmailType? Type {
            get { return BackingStore?.Get<EmailType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new TypedEmailAddress and sets the default values.
        /// </summary>
        public TypedEmailAddress() : base() {
            OdataType = "#microsoft.graph.typedEmailAddress";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TypedEmailAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TypedEmailAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"otherLabel", n => { OtherLabel = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<EmailType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("otherLabel", OtherLabel);
            writer.WriteEnumValue<EmailType>("type", Type);
        }
    }
}
