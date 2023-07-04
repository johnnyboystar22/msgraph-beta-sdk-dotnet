using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EndUserNotificationDetail : Entity, IParsable {
        /// <summary>The emailContent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailContent {
            get { return BackingStore?.Get<string?>("emailContent"); }
            set { BackingStore?.Set("emailContent", value); }
        }
#nullable restore
#else
        public string EmailContent {
            get { return BackingStore?.Get<string>("emailContent"); }
            set { BackingStore?.Set("emailContent", value); }
        }
#endif
        /// <summary>The isDefaultLangauge property</summary>
        public bool? IsDefaultLangauge {
            get { return BackingStore?.Get<bool?>("isDefaultLangauge"); }
            set { BackingStore?.Set("isDefaultLangauge", value); }
        }
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>The locale property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale {
            get { return BackingStore?.Get<string?>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#nullable restore
#else
        public string Locale {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#endif
        /// <summary>The sentFrom property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? SentFrom {
            get { return BackingStore?.Get<EmailIdentity?>("sentFrom"); }
            set { BackingStore?.Set("sentFrom", value); }
        }
#nullable restore
#else
        public EmailIdentity SentFrom {
            get { return BackingStore?.Get<EmailIdentity>("sentFrom"); }
            set { BackingStore?.Set("sentFrom", value); }
        }
#endif
        /// <summary>The subject property</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EndUserNotificationDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EndUserNotificationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"emailContent", n => { EmailContent = n.GetStringValue(); } },
                {"isDefaultLangauge", n => { IsDefaultLangauge = n.GetBoolValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"sentFrom", n => { SentFrom = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("emailContent", EmailContent);
            writer.WriteBoolValue("isDefaultLangauge", IsDefaultLangauge);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("locale", Locale);
            writer.WriteObjectValue<EmailIdentity>("sentFrom", SentFrom);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
