// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ExactMatchJobBase : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The completionDateTime property</summary>
        public DateTimeOffset? CompletionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>The creationDateTime property</summary>
        public DateTimeOffset? CreationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ClassificationError? Error
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClassificationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ClassificationError Error
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClassificationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ExactMatchJobBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ExactMatchJobBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.exactMatchLookupJob" => new Microsoft.Graph.Beta.Models.ExactMatchLookupJob(),
                "#microsoft.graph.exactMatchSession" => new Microsoft.Graph.Beta.Models.ExactMatchSession(),
                "#microsoft.graph.exactMatchSessionBase" => new Microsoft.Graph.Beta.Models.ExactMatchSessionBase(),
                _ => new Microsoft.Graph.Beta.Models.ExactMatchJobBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                { "creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                { "error", n => { Error = n.GetObjectValue<Microsoft.Graph.Beta.Models.ClassificationError>(Microsoft.Graph.Beta.Models.ClassificationError.CreateFromDiscriminatorValue); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ClassificationError>("error", Error);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
