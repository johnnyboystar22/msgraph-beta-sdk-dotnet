using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class LabelsRoot : Entity, IParsable {
        /// <summary>Specifies the underlying authority that describes the type of content to be retained and its retention schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthorityTemplate>? Authorities {
            get { return BackingStore?.Get<List<AuthorityTemplate>?>("authorities"); }
            set { BackingStore?.Set("authorities", value); }
        }
#nullable restore
#else
        public List<AuthorityTemplate> Authorities {
            get { return BackingStore?.Get<List<AuthorityTemplate>>("authorities"); }
            set { BackingStore?.Set("authorities", value); }
        }
#endif
        /// <summary>Specifies a group of similar types of content in a particular department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CategoryTemplate>? Categories {
            get { return BackingStore?.Get<List<CategoryTemplate>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<CategoryTemplate> Categories {
            get { return BackingStore?.Get<List<CategoryTemplate>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CitationTemplate>? Citations {
            get { return BackingStore?.Get<List<CitationTemplate>?>("citations"); }
            set { BackingStore?.Set("citations", value); }
        }
#nullable restore
#else
        public List<CitationTemplate> Citations {
            get { return BackingStore?.Get<List<CitationTemplate>>("citations"); }
            set { BackingStore?.Set("citations", value); }
        }
#endif
        /// <summary>Specifies the department or business unit of an organization to which a label belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DepartmentTemplate>? Departments {
            get { return BackingStore?.Get<List<DepartmentTemplate>?>("departments"); }
            set { BackingStore?.Set("departments", value); }
        }
#nullable restore
#else
        public List<DepartmentTemplate> Departments {
            get { return BackingStore?.Get<List<DepartmentTemplate>>("departments"); }
            set { BackingStore?.Set("departments", value); }
        }
#endif
        /// <summary>Specifies a unique alpha-numeric identifier for an organization’s retention schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilePlanReferenceTemplate>? FilePlanReferences {
            get { return BackingStore?.Get<List<FilePlanReferenceTemplate>?>("filePlanReferences"); }
            set { BackingStore?.Set("filePlanReferences", value); }
        }
#nullable restore
#else
        public List<FilePlanReferenceTemplate> FilePlanReferences {
            get { return BackingStore?.Get<List<FilePlanReferenceTemplate>>("filePlanReferences"); }
            set { BackingStore?.Set("filePlanReferences", value); }
        }
#endif
        /// <summary>Represents how customers can manage their data, whether and for how long to retain or delete it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RetentionLabel>? RetentionLabels {
            get { return BackingStore?.Get<List<RetentionLabel>?>("retentionLabels"); }
            set { BackingStore?.Set("retentionLabels", value); }
        }
#nullable restore
#else
        public List<RetentionLabel> RetentionLabels {
            get { return BackingStore?.Get<List<RetentionLabel>>("retentionLabels"); }
            set { BackingStore?.Set("retentionLabels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LabelsRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LabelsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authorities", n => { Authorities = n.GetCollectionOfObjectValues<AuthorityTemplate>(AuthorityTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<CategoryTemplate>(CategoryTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"citations", n => { Citations = n.GetCollectionOfObjectValues<CitationTemplate>(CitationTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"departments", n => { Departments = n.GetCollectionOfObjectValues<DepartmentTemplate>(DepartmentTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"filePlanReferences", n => { FilePlanReferences = n.GetCollectionOfObjectValues<FilePlanReferenceTemplate>(FilePlanReferenceTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"retentionLabels", n => { RetentionLabels = n.GetCollectionOfObjectValues<RetentionLabel>(RetentionLabel.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthorityTemplate>("authorities", Authorities);
            writer.WriteCollectionOfObjectValues<CategoryTemplate>("categories", Categories);
            writer.WriteCollectionOfObjectValues<CitationTemplate>("citations", Citations);
            writer.WriteCollectionOfObjectValues<DepartmentTemplate>("departments", Departments);
            writer.WriteCollectionOfObjectValues<FilePlanReferenceTemplate>("filePlanReferences", FilePlanReferences);
            writer.WriteCollectionOfObjectValues<RetentionLabel>("retentionLabels", RetentionLabels);
        }
    }
}
