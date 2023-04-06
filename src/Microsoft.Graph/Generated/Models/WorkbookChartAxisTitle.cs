using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookChartAxisTitle : Entity, IParsable {
        /// <summary>Represents the formatting of chart axis title. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxisTitleFormat? Format {
            get { return BackingStore?.Get<WorkbookChartAxisTitleFormat?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#nullable restore
#else
        public WorkbookChartAxisTitleFormat Format {
            get { return BackingStore?.Get<WorkbookChartAxisTitleFormat>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#endif
        /// <summary>Represents the axis title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text {
            get { return BackingStore?.Get<string?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public string Text {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>A boolean that specifies the visibility of an axis title.</summary>
        public bool? Visible {
            get { return BackingStore?.Get<bool?>("visible"); }
            set { BackingStore?.Set("visible", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookChartAxisTitle CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAxisTitle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"format", n => { Format = n.GetObjectValue<WorkbookChartAxisTitleFormat>(WorkbookChartAxisTitleFormat.CreateFromDiscriminatorValue); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"visible", n => { Visible = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxisTitleFormat>("format", Format);
            writer.WriteStringValue("text", Text);
            writer.WriteBoolValue("visible", Visible);
        }
    }
}
