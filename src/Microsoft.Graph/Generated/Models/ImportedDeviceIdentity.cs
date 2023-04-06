using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The importedDeviceIdentity resource represents a unique hardware identity of a device that has been pre-staged for pre-enrollment configuration.
    /// </summary>
    public class ImportedDeviceIdentity : Entity, IParsable {
        /// <summary>Created Date Time of the device</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The enrollmentState property</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>("enrollmentState"); }
            set { BackingStore?.Set("enrollmentState", value); }
        }
        /// <summary>Imported Device Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImportedDeviceIdentifier {
            get { return BackingStore?.Get<string?>("importedDeviceIdentifier"); }
            set { BackingStore?.Set("importedDeviceIdentifier", value); }
        }
#nullable restore
#else
        public string ImportedDeviceIdentifier {
            get { return BackingStore?.Get<string>("importedDeviceIdentifier"); }
            set { BackingStore?.Set("importedDeviceIdentifier", value); }
        }
#endif
        /// <summary>The importedDeviceIdentityType property</summary>
        public Microsoft.Graph.Beta.Models.ImportedDeviceIdentityType? ImportedDeviceIdentityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ImportedDeviceIdentityType?>("importedDeviceIdentityType"); }
            set { BackingStore?.Set("importedDeviceIdentityType", value); }
        }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastContactedDateTime"); }
            set { BackingStore?.Set("lastContactedDateTime", value); }
        }
        /// <summary>Last Modified DateTime of the description</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The platform property</summary>
        public Microsoft.Graph.Beta.Models.Platform? Platform {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Platform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImportedDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.importedDeviceIdentityResult" => new ImportedDeviceIdentityResult(),
                _ => new ImportedDeviceIdentity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"importedDeviceIdentifier", n => { ImportedDeviceIdentifier = n.GetStringValue(); } },
                {"importedDeviceIdentityType", n => { ImportedDeviceIdentityType = n.GetEnumValue<ImportedDeviceIdentityType>(); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<Platform>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteStringValue("importedDeviceIdentifier", ImportedDeviceIdentifier);
            writer.WriteEnumValue<ImportedDeviceIdentityType>("importedDeviceIdentityType", ImportedDeviceIdentityType);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Platform>("platform", Platform);
        }
    }
}
