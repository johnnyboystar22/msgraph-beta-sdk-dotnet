// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class GoalsExportJob : LongRunningOperation, IParsable {
        /// <summary>The content of the goalsExportJob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The date and time of expiry of the result of the operation.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The unique identifier of the explorer view to be exported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExplorerViewId {
            get { return BackingStore?.Get<string?>("explorerViewId"); }
            set { BackingStore?.Set("explorerViewId", value); }
        }
#nullable restore
#else
        public string ExplorerViewId {
            get { return BackingStore?.Get<string>("explorerViewId"); }
            set { BackingStore?.Set("explorerViewId", value); }
        }
#endif
        /// <summary>The unique identifier of the viva goals organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GoalsOrganizationId {
            get { return BackingStore?.Get<string?>("goalsOrganizationId"); }
            set { BackingStore?.Set("goalsOrganizationId", value); }
        }
#nullable restore
#else
        public string GoalsOrganizationId {
            get { return BackingStore?.Get<string>("goalsOrganizationId"); }
            set { BackingStore?.Set("goalsOrganizationId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GoalsExportJob"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GoalsExportJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GoalsExportJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"explorerViewId", n => { ExplorerViewId = n.GetStringValue(); } },
                {"goalsOrganizationId", n => { GoalsOrganizationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("explorerViewId", ExplorerViewId);
            writer.WriteStringValue("goalsOrganizationId", GoalsOrganizationId);
        }
    }
}
