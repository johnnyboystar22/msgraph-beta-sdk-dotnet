using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementTemplateStepVersion : Entity, IParsable {
        /// <summary>The acceptedFor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagementTemplateStep? AcceptedFor {
            get { return BackingStore?.Get<ManagementTemplateStep?>("acceptedFor"); }
            set { BackingStore?.Set("acceptedFor", value); }
        }
#nullable restore
#else
        public ManagementTemplateStep AcceptedFor {
            get { return BackingStore?.Get<ManagementTemplateStep>("acceptedFor"); }
            set { BackingStore?.Set("acceptedFor", value); }
        }
#endif
        /// <summary>The contentMarkdown property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentMarkdown {
            get { return BackingStore?.Get<string?>("contentMarkdown"); }
            set { BackingStore?.Set("contentMarkdown", value); }
        }
#nullable restore
#else
        public string ContentMarkdown {
            get { return BackingStore?.Get<string>("contentMarkdown"); }
            set { BackingStore?.Set("contentMarkdown", value); }
        }
#endif
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
#else
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The deployments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateStepDeployment>? Deployments {
            get { return BackingStore?.Get<List<ManagementTemplateStepDeployment>?>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateStepDeployment> Deployments {
            get { return BackingStore?.Get<List<ManagementTemplateStepDeployment>>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
#else
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The name property</summary>
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
        /// <summary>The templateStep property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagementTemplateStep? TemplateStep {
            get { return BackingStore?.Get<ManagementTemplateStep?>("templateStep"); }
            set { BackingStore?.Set("templateStep", value); }
        }
#nullable restore
#else
        public ManagementTemplateStep TemplateStep {
            get { return BackingStore?.Get<ManagementTemplateStep>("templateStep"); }
            set { BackingStore?.Set("templateStep", value); }
        }
#endif
        /// <summary>The version property</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>The versionInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionInformation {
            get { return BackingStore?.Get<string?>("versionInformation"); }
            set { BackingStore?.Set("versionInformation", value); }
        }
#nullable restore
#else
        public string VersionInformation {
            get { return BackingStore?.Get<string>("versionInformation"); }
            set { BackingStore?.Set("versionInformation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateStepVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedFor", n => { AcceptedFor = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"contentMarkdown", n => { ContentMarkdown = n.GetStringValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<ManagementTemplateStepDeployment>(ManagementTemplateStepDeployment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"templateStep", n => { TemplateStep = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
                {"versionInformation", n => { VersionInformation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ManagementTemplateStep>("acceptedFor", AcceptedFor);
            writer.WriteStringValue("contentMarkdown", ContentMarkdown);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepDeployment>("deployments", Deployments);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ManagementTemplateStep>("templateStep", TemplateStep);
            writer.WriteIntValue("version", Version);
            writer.WriteStringValue("versionInformation", VersionInformation);
        }
    }
}
