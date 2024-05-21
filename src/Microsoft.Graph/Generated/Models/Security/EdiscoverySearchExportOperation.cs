// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class EdiscoverySearchExportOperation : CaseOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The additional items to include in the export. The possible values are: none, teamsAndYammerConversations, cloudAttachments, allDocumentVersions, subfolderContents, listAttachments, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.AdditionalOptions? AdditionalOptions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AdditionalOptions?>("additionalOptions"); }
            set { BackingStore?.Set("additionalOptions", value); }
        }
        /// <summary>The name of export provided by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The description of the export by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Items to be included in the export. The possible values are: searchHits, partiallyIndexed, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.ExportCriteria? ExportCriteria
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ExportCriteria?>("exportCriteria"); }
            set { BackingStore?.Set("exportCriteria", value); }
        }
        /// <summary>Contains the properties for an export file metadata, including downloadUrl, fileName, and size.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.ExportFileMetadata>? ExportFileMetadata
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.ExportFileMetadata>?>("exportFileMetadata"); }
            set { BackingStore?.Set("exportFileMetadata", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.ExportFileMetadata> ExportFileMetadata
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.ExportFileMetadata>>("exportFileMetadata"); }
            set { BackingStore?.Set("exportFileMetadata", value); }
        }
#endif
        /// <summary>Format of the emails of the export. The possible values are: pst, msg, eml, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.ExportFormat? ExportFormat
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ExportFormat?>("exportFormat"); }
            set { BackingStore?.Set("exportFormat", value); }
        }
        /// <summary>Location scope for partially indexed items. You can choose to include partially indexed items only in responsive locations with search hits or in all targeted locations. The possible values are: responsiveLocations, nonresponsiveLocations, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.ExportLocation? ExportLocation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ExportLocation?>("exportLocation"); }
            set { BackingStore?.Set("exportLocation", value); }
        }
        /// <summary>Indicates whether to export single items.</summary>
        public bool? ExportSingleItems
        {
            get { return BackingStore?.Get<bool?>("exportSingleItems"); }
            set { BackingStore?.Set("exportSingleItems", value); }
        }
        /// <summary>The eDiscovery searches under each case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoverySearch? Search
        {
            get { return BackingStore?.Get<EdiscoverySearch?>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#nullable restore
#else
        public EdiscoverySearch Search
        {
            get { return BackingStore?.Get<EdiscoverySearch>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EdiscoverySearchExportOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoverySearchExportOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoverySearchExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalOptions", n => { AdditionalOptions = n.GetEnumValue<AdditionalOptions>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "exportCriteria", n => { ExportCriteria = n.GetEnumValue<ExportCriteria>(); } },
                { "exportFileMetadata", n => { ExportFileMetadata = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.ExportFileMetadata>(Microsoft.Graph.Beta.Models.Security.ExportFileMetadata.CreateFromDiscriminatorValue)?.ToList(); } },
                { "exportFormat", n => { ExportFormat = n.GetEnumValue<ExportFormat>(); } },
                { "exportLocation", n => { ExportLocation = n.GetEnumValue<ExportLocation>(); } },
                { "exportSingleItems", n => { ExportSingleItems = n.GetBoolValue(); } },
                { "search", n => { Search = n.GetObjectValue<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<AdditionalOptions>("additionalOptions", AdditionalOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<ExportCriteria>("exportCriteria", ExportCriteria);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.ExportFileMetadata>("exportFileMetadata", ExportFileMetadata);
            writer.WriteEnumValue<ExportFormat>("exportFormat", ExportFormat);
            writer.WriteEnumValue<ExportLocation>("exportLocation", ExportLocation);
            writer.WriteBoolValue("exportSingleItems", ExportSingleItems);
            writer.WriteObjectValue<EdiscoverySearch>("search", Search);
        }
    }
}
