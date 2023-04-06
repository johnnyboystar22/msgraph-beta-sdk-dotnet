using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AutomaticRepliesMailTips : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The automatic reply message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The language that the automatic reply message is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? MessageLanguage {
            get { return BackingStore?.Get<LocaleInfo?>("messageLanguage"); }
            set { BackingStore?.Set("messageLanguage", value); }
        }
#nullable restore
#else
        public LocaleInfo MessageLanguage {
            get { return BackingStore?.Get<LocaleInfo>("messageLanguage"); }
            set { BackingStore?.Set("messageLanguage", value); }
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
        /// <summary>The date and time that automatic replies are set to end.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? ScheduledEndTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("scheduledEndTime"); }
            set { BackingStore?.Set("scheduledEndTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone ScheduledEndTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("scheduledEndTime"); }
            set { BackingStore?.Set("scheduledEndTime", value); }
        }
#endif
        /// <summary>The date and time that automatic replies are set to begin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? ScheduledStartTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("scheduledStartTime"); }
            set { BackingStore?.Set("scheduledStartTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone ScheduledStartTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("scheduledStartTime"); }
            set { BackingStore?.Set("scheduledStartTime", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new automaticRepliesMailTips and sets the default values.
        /// </summary>
        public AutomaticRepliesMailTips() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AutomaticRepliesMailTips CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AutomaticRepliesMailTips();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"message", n => { Message = n.GetStringValue(); } },
                {"messageLanguage", n => { MessageLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scheduledEndTime", n => { ScheduledEndTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"scheduledStartTime", n => { ScheduledStartTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteObjectValue<LocaleInfo>("messageLanguage", MessageLanguage);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<DateTimeTimeZone>("scheduledEndTime", ScheduledEndTime);
            writer.WriteObjectValue<DateTimeTimeZone>("scheduledStartTime", ScheduledStartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
