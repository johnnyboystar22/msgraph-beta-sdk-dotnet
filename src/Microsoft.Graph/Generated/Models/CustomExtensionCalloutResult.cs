using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CustomExtensionCalloutResult : AuthenticationEventHandlerResult, IParsable {
        /// <summary>When the API transaction was initiated, the date and time information uses ISO 8601 format and is always in UTC time. Example: midnight on Jan 1, 2014, is reported as 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CalloutDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("calloutDateTime"); }
            set { BackingStore?.Set("calloutDateTime", value); }
        }
        /// <summary>Identifier of the custom extension that was called.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomExtensionId {
            get { return BackingStore?.Get<string?>("customExtensionId"); }
            set { BackingStore?.Set("customExtensionId", value); }
        }
#nullable restore
#else
        public string CustomExtensionId {
            get { return BackingStore?.Get<string>("customExtensionId"); }
            set { BackingStore?.Set("customExtensionId", value); }
        }
#endif
        /// <summary>Error code that was returned when the last API attempt failed.</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The HTTP status code that was returned by the target API endpoint after the last API attempt.</summary>
        public int? HttpStatus {
            get { return BackingStore?.Get<int?>("httpStatus"); }
            set { BackingStore?.Set("httpStatus", value); }
        }
        /// <summary>The number of API calls to the customer&apos;s API.</summary>
        public int? NumberOfAttempts {
            get { return BackingStore?.Get<int?>("numberOfAttempts"); }
            set { BackingStore?.Set("numberOfAttempts", value); }
        }
        /// <summary>
        /// Instantiates a new CustomExtensionCalloutResult and sets the default values.
        /// </summary>
        public CustomExtensionCalloutResult() : base() {
            OdataType = "#microsoft.graph.customExtensionCalloutResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomExtensionCalloutResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionCalloutResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"calloutDateTime", n => { CalloutDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionId", n => { CustomExtensionId = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"httpStatus", n => { HttpStatus = n.GetIntValue(); } },
                {"numberOfAttempts", n => { NumberOfAttempts = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("calloutDateTime", CalloutDateTime);
            writer.WriteStringValue("customExtensionId", CustomExtensionId);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteIntValue("httpStatus", HttpStatus);
            writer.WriteIntValue("numberOfAttempts", NumberOfAttempts);
        }
    }
}
