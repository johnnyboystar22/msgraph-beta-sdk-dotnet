using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookWorksheet : Entity, IParsable {
        /// <summary>Returns collection of charts that are part of the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookChart>? Charts {
            get { return BackingStore?.Get<List<WorkbookChart>?>("charts"); }
            set { BackingStore?.Set("charts", value); }
        }
#nullable restore
#else
        public List<WorkbookChart> Charts {
            get { return BackingStore?.Get<List<WorkbookChart>>("charts"); }
            set { BackingStore?.Set("charts", value); }
        }
#endif
        /// <summary>The display name of the worksheet.</summary>
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
        /// <summary>Returns collection of names that are associated with the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookNamedItem>? Names {
            get { return BackingStore?.Get<List<WorkbookNamedItem>?>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#nullable restore
#else
        public List<WorkbookNamedItem> Names {
            get { return BackingStore?.Get<List<WorkbookNamedItem>>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#endif
        /// <summary>Collection of PivotTables that are part of the worksheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookPivotTable>? PivotTables {
            get { return BackingStore?.Get<List<WorkbookPivotTable>?>("pivotTables"); }
            set { BackingStore?.Set("pivotTables", value); }
        }
#nullable restore
#else
        public List<WorkbookPivotTable> PivotTables {
            get { return BackingStore?.Get<List<WorkbookPivotTable>>("pivotTables"); }
            set { BackingStore?.Set("pivotTables", value); }
        }
#endif
        /// <summary>The zero-based position of the worksheet within the workbook.</summary>
        public int? Position {
            get { return BackingStore?.Get<int?>("position"); }
            set { BackingStore?.Set("position", value); }
        }
        /// <summary>Returns sheet protection object for a worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookWorksheetProtection? Protection {
            get { return BackingStore?.Get<WorkbookWorksheetProtection?>("protection"); }
            set { BackingStore?.Set("protection", value); }
        }
#nullable restore
#else
        public WorkbookWorksheetProtection Protection {
            get { return BackingStore?.Get<WorkbookWorksheetProtection>("protection"); }
            set { BackingStore?.Set("protection", value); }
        }
#endif
        /// <summary>Collection of tables that are part of the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookTable>? Tables {
            get { return BackingStore?.Get<List<WorkbookTable>?>("tables"); }
            set { BackingStore?.Set("tables", value); }
        }
#nullable restore
#else
        public List<WorkbookTable> Tables {
            get { return BackingStore?.Get<List<WorkbookTable>>("tables"); }
            set { BackingStore?.Set("tables", value); }
        }
#endif
        /// <summary>The Visibility of the worksheet. The possible values are: Visible, Hidden, VeryHidden.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility {
            get { return BackingStore?.Get<string?>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
#nullable restore
#else
        public string Visibility {
            get { return BackingStore?.Get<string>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookWorksheet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookWorksheet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"charts", n => { Charts = n.GetCollectionOfObjectValues<WorkbookChart>(WorkbookChart.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"names", n => { Names = n.GetCollectionOfObjectValues<WorkbookNamedItem>(WorkbookNamedItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pivotTables", n => { PivotTables = n.GetCollectionOfObjectValues<WorkbookPivotTable>(WorkbookPivotTable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"position", n => { Position = n.GetIntValue(); } },
                {"protection", n => { Protection = n.GetObjectValue<WorkbookWorksheetProtection>(WorkbookWorksheetProtection.CreateFromDiscriminatorValue); } },
                {"tables", n => { Tables = n.GetCollectionOfObjectValues<WorkbookTable>(WorkbookTable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"visibility", n => { Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookChart>("charts", Charts);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<WorkbookPivotTable>("pivotTables", PivotTables);
            writer.WriteIntValue("position", Position);
            writer.WriteObjectValue<WorkbookWorksheetProtection>("protection", Protection);
            writer.WriteCollectionOfObjectValues<WorkbookTable>("tables", Tables);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
