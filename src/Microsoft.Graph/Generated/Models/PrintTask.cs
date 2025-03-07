// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PrintTask : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The definition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PrintTaskDefinition? Definition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintTaskDefinition?>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PrintTaskDefinition Definition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintTaskDefinition>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
#endif
        /// <summary>The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentUrl
        {
            get { return BackingStore?.Get<string?>("parentUrl"); }
            set { BackingStore?.Set("parentUrl", value); }
        }
#nullable restore
#else
        public string ParentUrl
        {
            get { return BackingStore?.Get<string>("parentUrl"); }
            set { BackingStore?.Set("parentUrl", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PrintTaskStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintTaskStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PrintTaskStatus Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintTaskStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The trigger property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PrintTaskTrigger? Trigger
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintTaskTrigger?>("trigger"); }
            set { BackingStore?.Set("trigger", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PrintTaskTrigger Trigger
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintTaskTrigger>("trigger"); }
            set { BackingStore?.Set("trigger", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PrintTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.PrintTask CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PrintTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "definition", n => { Definition = n.GetObjectValue<Microsoft.Graph.Beta.Models.PrintTaskDefinition>(Microsoft.Graph.Beta.Models.PrintTaskDefinition.CreateFromDiscriminatorValue); } },
                { "parentUrl", n => { ParentUrl = n.GetStringValue(); } },
                { "status", n => { Status = n.GetObjectValue<Microsoft.Graph.Beta.Models.PrintTaskStatus>(Microsoft.Graph.Beta.Models.PrintTaskStatus.CreateFromDiscriminatorValue); } },
                { "trigger", n => { Trigger = n.GetObjectValue<Microsoft.Graph.Beta.Models.PrintTaskTrigger>(Microsoft.Graph.Beta.Models.PrintTaskTrigger.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PrintTaskDefinition>("definition", Definition);
            writer.WriteStringValue("parentUrl", ParentUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PrintTaskStatus>("status", Status);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PrintTaskTrigger>("trigger", Trigger);
        }
    }
}
