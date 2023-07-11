using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EmailPayloadDetail : PayloadDetail, IParsable {
        /// <summary>Email address of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmail {
            get { return BackingStore?.Get<string?>("fromEmail"); }
            set { BackingStore?.Set("fromEmail", value); }
        }
#nullable restore
#else
        public string FromEmail {
            get { return BackingStore?.Get<string>("fromEmail"); }
            set { BackingStore?.Set("fromEmail", value); }
        }
#endif
        /// <summary>Display name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromName {
            get { return BackingStore?.Get<string?>("fromName"); }
            set { BackingStore?.Set("fromName", value); }
        }
#nullable restore
#else
        public string FromName {
            get { return BackingStore?.Get<string>("fromName"); }
            set { BackingStore?.Set("fromName", value); }
        }
#endif
        /// <summary>Indicates whether the sender is not from the user&apos;s organization.</summary>
        public bool? IsExternalSender {
            get { return BackingStore?.Get<bool?>("isExternalSender"); }
            set { BackingStore?.Set("isExternalSender", value); }
        }
        /// <summary>The subject of the email address sent to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new emailPayloadDetail and sets the default values.
        /// </summary>
        public EmailPayloadDetail() : base() {
            OdataType = "#microsoft.graph.emailPayloadDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailPayloadDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailPayloadDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fromEmail", n => { FromEmail = n.GetStringValue(); } },
                {"fromName", n => { FromName = n.GetStringValue(); } },
                {"isExternalSender", n => { IsExternalSender = n.GetBoolValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fromEmail", FromEmail);
            writer.WriteStringValue("fromName", FromName);
            writer.WriteBoolValue("isExternalSender", IsExternalSender);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
