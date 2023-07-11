using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAssignmentRequestWorkflowExtension : CustomCalloutExtension, IParsable {
        /// <summary>The callback configuration for a custom extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomExtensionCallbackConfiguration? CallbackConfiguration {
            get { return BackingStore?.Get<CustomExtensionCallbackConfiguration?>("callbackConfiguration"); }
            set { BackingStore?.Set("callbackConfiguration", value); }
        }
#nullable restore
#else
        public CustomExtensionCallbackConfiguration CallbackConfiguration {
            get { return BackingStore?.Get<CustomExtensionCallbackConfiguration>("callbackConfiguration"); }
            set { BackingStore?.Set("callbackConfiguration", value); }
        }
#endif
        /// <summary>The userPrincipalName of the user or identity of the subject that created this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy {
            get { return BackingStore?.Get<string?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public string CreatedBy {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>When the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The userPrincipalName of the identity that last modified the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy {
            get { return BackingStore?.Get<string?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public string LastModifiedBy {
            get { return BackingStore?.Get<string>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>When the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestWorkflowExtension and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestWorkflowExtension() : base() {
            OdataType = "#microsoft.graph.accessPackageAssignmentRequestWorkflowExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentRequestWorkflowExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestWorkflowExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callbackConfiguration", n => { CallbackConfiguration = n.GetObjectValue<CustomExtensionCallbackConfiguration>(CustomExtensionCallbackConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomExtensionCallbackConfiguration>("callbackConfiguration", CallbackConfiguration);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
