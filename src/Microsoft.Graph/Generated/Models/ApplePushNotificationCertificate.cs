using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Apple push notification certificate.
    /// </summary>
    public class ApplePushNotificationCertificate : Entity, IParsable {
        /// <summary>Apple Id of the account used to create the MDM push certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleIdentifier {
            get { return BackingStore?.Get<string?>("appleIdentifier"); }
            set { BackingStore?.Set("appleIdentifier", value); }
        }
#nullable restore
#else
        public string AppleIdentifier {
            get { return BackingStore?.Get<string>("appleIdentifier"); }
            set { BackingStore?.Set("appleIdentifier", value); }
        }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate {
            get { return BackingStore?.Get<string?>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#nullable restore
#else
        public string Certificate {
            get { return BackingStore?.Get<string>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#endif
        /// <summary>Certificate serial number. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateSerialNumber {
            get { return BackingStore?.Get<string?>("certificateSerialNumber"); }
            set { BackingStore?.Set("certificateSerialNumber", value); }
        }
#nullable restore
#else
        public string CertificateSerialNumber {
            get { return BackingStore?.Get<string>("certificateSerialNumber"); }
            set { BackingStore?.Set("certificateSerialNumber", value); }
        }
#endif
        /// <summary>The reason the certificate upload failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateUploadFailureReason {
            get { return BackingStore?.Get<string?>("certificateUploadFailureReason"); }
            set { BackingStore?.Set("certificateUploadFailureReason", value); }
        }
#nullable restore
#else
        public string CertificateUploadFailureReason {
            get { return BackingStore?.Get<string>("certificateUploadFailureReason"); }
            set { BackingStore?.Set("certificateUploadFailureReason", value); }
        }
#endif
        /// <summary>The certificate upload status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateUploadStatus {
            get { return BackingStore?.Get<string?>("certificateUploadStatus"); }
            set { BackingStore?.Set("certificateUploadStatus", value); }
        }
#nullable restore
#else
        public string CertificateUploadStatus {
            get { return BackingStore?.Get<string>("certificateUploadStatus"); }
            set { BackingStore?.Set("certificateUploadStatus", value); }
        }
#endif
        /// <summary>The expiration date and time for Apple push notification certificate.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Last modified date and time for Apple push notification certificate.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Topic Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TopicIdentifier {
            get { return BackingStore?.Get<string?>("topicIdentifier"); }
            set { BackingStore?.Set("topicIdentifier", value); }
        }
#nullable restore
#else
        public string TopicIdentifier {
            get { return BackingStore?.Get<string>("topicIdentifier"); }
            set { BackingStore?.Set("topicIdentifier", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ApplePushNotificationCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplePushNotificationCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleIdentifier", n => { AppleIdentifier = n.GetStringValue(); } },
                {"certificate", n => { Certificate = n.GetStringValue(); } },
                {"certificateSerialNumber", n => { CertificateSerialNumber = n.GetStringValue(); } },
                {"certificateUploadFailureReason", n => { CertificateUploadFailureReason = n.GetStringValue(); } },
                {"certificateUploadStatus", n => { CertificateUploadStatus = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"topicIdentifier", n => { TopicIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleIdentifier", AppleIdentifier);
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteStringValue("certificateUploadFailureReason", CertificateUploadFailureReason);
            writer.WriteStringValue("certificateUploadStatus", CertificateUploadStatus);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("topicIdentifier", TopicIdentifier);
        }
    }
}
