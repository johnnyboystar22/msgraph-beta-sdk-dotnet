// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ServiceUpdateMessage : Microsoft.Graph.Beta.Models.ServiceAnnouncementBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The expected deadline of the action for the message.</summary>
        public DateTimeOffset? ActionRequiredByDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("actionRequiredByDateTime"); }
            set { BackingStore?.Set("actionRequiredByDateTime", value); }
        }
        /// <summary>A collection of serviceAnnouncementAttachments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment>? Attachments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment> Attachments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The zip file of all attachments for a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttachmentsArchive
        {
            get { return BackingStore?.Get<byte[]?>("attachmentsArchive"); }
            set { BackingStore?.Set("attachmentsArchive", value); }
        }
#nullable restore
#else
        public byte[] AttachmentsArchive
        {
            get { return BackingStore?.Get<byte[]>("attachmentsArchive"); }
            set { BackingStore?.Set("attachmentsArchive", value); }
        }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ItemBody? Body
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ItemBody Body
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>The category property</summary>
        public Microsoft.Graph.Beta.Models.ServiceUpdateCategory? Category
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceUpdateCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>Indicates whether the message has any attachment.</summary>
        public bool? HasAttachments
        {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>Indicates whether the message describes a major update for the service.</summary>
        public bool? IsMajorChange
        {
            get { return BackingStore?.Get<bool?>("isMajorChange"); }
            set { BackingStore?.Set("isMajorChange", value); }
        }
        /// <summary>The affected services by the service message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Services
        {
            get { return BackingStore?.Get<List<string>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<string> Services
        {
            get { return BackingStore?.Get<List<string>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public Microsoft.Graph.Beta.Models.ServiceUpdateSeverity? Severity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceUpdateSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>A collection of tags for the service message. Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags
        {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags
        {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>Represents user viewpoints data of the service message. This data includes message status such as whether the user has archived, read, or marked the message as favorite. This property is null when accessed with application permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint? ViewPoint
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint?>("viewPoint"); }
            set { BackingStore?.Set("viewPoint", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint ViewPoint
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint>("viewPoint"); }
            set { BackingStore?.Set("viewPoint", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ServiceUpdateMessage"/> and sets the default values.
        /// </summary>
        public ServiceUpdateMessage() : base()
        {
            OdataType = "#microsoft.graph.serviceUpdateMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ServiceUpdateMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ServiceUpdateMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ServiceUpdateMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionRequiredByDateTime", n => { ActionRequiredByDateTime = n.GetDateTimeOffsetValue(); } },
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment>(Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "attachmentsArchive", n => { AttachmentsArchive = n.GetByteArrayValue(); } },
                { "body", n => { Body = n.GetObjectValue<Microsoft.Graph.Beta.Models.ItemBody>(Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetEnumValue<Microsoft.Graph.Beta.Models.ServiceUpdateCategory>(); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "isMajorChange", n => { IsMajorChange = n.GetBoolValue(); } },
                { "services", n => { Services = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "severity", n => { Severity = n.GetEnumValue<Microsoft.Graph.Beta.Models.ServiceUpdateSeverity>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "viewPoint", n => { ViewPoint = n.GetObjectValue<Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint>(Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("actionRequiredByDateTime", ActionRequiredByDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ServiceAnnouncementAttachment>("attachments", Attachments);
            writer.WriteByteArrayValue("attachmentsArchive", AttachmentsArchive);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ItemBody>("body", Body);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ServiceUpdateCategory>("category", Category);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isMajorChange", IsMajorChange);
            writer.WriteCollectionOfPrimitiveValues<string>("services", Services);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ServiceUpdateSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ServiceUpdateMessageViewpoint>("viewPoint", ViewPoint);
        }
    }
}
