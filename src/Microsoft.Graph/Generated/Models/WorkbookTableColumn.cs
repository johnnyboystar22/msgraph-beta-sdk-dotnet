using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookTableColumn : Entity, IParsable {
        /// <summary>Retrieve the filter applied to the column. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookFilter? Filter {
            get { return BackingStore?.Get<WorkbookFilter?>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
#nullable restore
#else
        public WorkbookFilter Filter {
            get { return BackingStore?.Get<WorkbookFilter>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
#endif
        /// <summary>Returns the index number of the column within the columns collection of the table. Zero-indexed. Read-only.</summary>
        public int? Index {
            get { return BackingStore?.Get<int?>("index"); }
            set { BackingStore?.Set("index", value); }
        }
        /// <summary>Returns the name of the table column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Represents the raw values of the specified range. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Values {
            get { return BackingStore?.Get<Json?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public Json Values {
            get { return BackingStore?.Get<Json>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookTableColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTableColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"filter", n => { Filter = n.GetObjectValue<WorkbookFilter>(WorkbookFilter.CreateFromDiscriminatorValue); } },
                {"index", n => { Index = n.GetIntValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"values", n => { Values = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookFilter>("filter", Filter);
            writer.WriteIntValue("index", Index);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Json>("values", Values);
        }
    }
}
