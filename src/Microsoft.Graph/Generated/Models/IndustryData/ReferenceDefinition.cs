using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class ReferenceDefinition : Entity, IParsable {
        /// <summary>The code value for the definition that must be unique within the referenceType.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code {
            get { return BackingStore?.Get<string?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#nullable restore
#else
        public string Code {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#endif
        /// <summary>The date and time when the definition was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Indicates whether the definition has been disabled.</summary>
        public bool? IsDisabled {
            get { return BackingStore?.Get<bool?>("isDisabled"); }
            set { BackingStore?.Set("isDisabled", value); }
        }
        /// <summary>The date and time when the definition was most recently changed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The categorical type for a collection of enumerated values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceType {
            get { return BackingStore?.Get<string?>("referenceType"); }
            set { BackingStore?.Set("referenceType", value); }
        }
#nullable restore
#else
        public string ReferenceType {
            get { return BackingStore?.Get<string>("referenceType"); }
            set { BackingStore?.Set("referenceType", value); }
        }
#endif
        /// <summary>The ordering index to present the definitions within a type consistently in user interfaces.</summary>
        public int? SortIndex {
            get { return BackingStore?.Get<int?>("sortIndex"); }
            set { BackingStore?.Set("sortIndex", value); }
        }
        /// <summary>The standards body or organization source which defined the code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source {
            get { return BackingStore?.Get<string?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public string Source {
            get { return BackingStore?.Get<string>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ReferenceDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReferenceDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"code", n => { Code = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isDisabled", n => { IsDisabled = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"referenceType", n => { ReferenceType = n.GetStringValue(); } },
                {"sortIndex", n => { SortIndex = n.GetIntValue(); } },
                {"source", n => { Source = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("code", Code);
            writer.WriteBoolValue("isDisabled", IsDisabled);
            writer.WriteStringValue("referenceType", ReferenceType);
            writer.WriteIntValue("sortIndex", SortIndex);
        }
    }
}
