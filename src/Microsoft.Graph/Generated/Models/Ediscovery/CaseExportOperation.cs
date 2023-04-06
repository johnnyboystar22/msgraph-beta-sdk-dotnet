using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class CaseExportOperation : CaseOperation, IParsable {
        /// <summary>The name of the Azure storage location where the export will be stored. This only applies to exports stored in your own Azure storage location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureBlobContainer {
            get { return BackingStore?.Get<string?>("azureBlobContainer"); }
            set { BackingStore?.Set("azureBlobContainer", value); }
        }
#nullable restore
#else
        public string AzureBlobContainer {
            get { return BackingStore?.Get<string>("azureBlobContainer"); }
            set { BackingStore?.Set("azureBlobContainer", value); }
        }
#endif
        /// <summary>The SAS token for the Azure storage location.  This only applies to exports stored in your own Azure storage location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureBlobToken {
            get { return BackingStore?.Get<string?>("azureBlobToken"); }
            set { BackingStore?.Set("azureBlobToken", value); }
        }
#nullable restore
#else
        public string AzureBlobToken {
            get { return BackingStore?.Get<string>("azureBlobToken"); }
            set { BackingStore?.Set("azureBlobToken", value); }
        }
#endif
        /// <summary>The description provided for the export.</summary>
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
        /// <summary>The options provided for the export. For more details, see reviewSet: export. Possible values are: originalFiles, text, pdfReplacement, fileInfo, tags.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.ExportOptions? ExportOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.ExportOptions?>("exportOptions"); }
            set { BackingStore?.Set("exportOptions", value); }
        }
        /// <summary>The options provided that specify the structure of the export. For more details, see reviewSet: export. Possible values are: none, directory, pst.</summary>
        public ExportFileStructure? ExportStructure {
            get { return BackingStore?.Get<ExportFileStructure?>("exportStructure"); }
            set { BackingStore?.Set("exportStructure", value); }
        }
        /// <summary>The outputFolderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputFolderId {
            get { return BackingStore?.Get<string?>("outputFolderId"); }
            set { BackingStore?.Set("outputFolderId", value); }
        }
#nullable restore
#else
        public string OutputFolderId {
            get { return BackingStore?.Get<string>("outputFolderId"); }
            set { BackingStore?.Set("outputFolderId", value); }
        }
#endif
        /// <summary>The name provided for the export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputName {
            get { return BackingStore?.Get<string?>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#nullable restore
#else
        public string OutputName {
            get { return BackingStore?.Get<string>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#endif
        /// <summary>The review set the content is being exported from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet? ReviewSet {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet?>("reviewSet"); }
            set { BackingStore?.Set("reviewSet", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet ReviewSet {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet>("reviewSet"); }
            set { BackingStore?.Set("reviewSet", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CaseExportOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CaseExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureBlobContainer", n => { AzureBlobContainer = n.GetStringValue(); } },
                {"azureBlobToken", n => { AzureBlobToken = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputFolderId", n => { OutputFolderId = n.GetStringValue(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
                {"reviewSet", n => { ReviewSet = n.GetObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet>(Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureBlobContainer", AzureBlobContainer);
            writer.WriteStringValue("azureBlobToken", AzureBlobToken);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputFolderId", OutputFolderId);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet>("reviewSet", ReviewSet);
        }
    }
}
