// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskDetails : PlannerDelta, IParsable {
        /// <summary>The approvalAttachment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerBaseApprovalAttachment? ApprovalAttachment {
            get { return BackingStore?.Get<PlannerBaseApprovalAttachment?>("approvalAttachment"); }
            set { BackingStore?.Set("approvalAttachment", value); }
        }
#nullable restore
#else
        public PlannerBaseApprovalAttachment ApprovalAttachment {
            get { return BackingStore?.Get<PlannerBaseApprovalAttachment>("approvalAttachment"); }
            set { BackingStore?.Set("approvalAttachment", value); }
        }
#endif
        /// <summary>The collection of checklist items on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerChecklistItems? Checklist {
            get { return BackingStore?.Get<PlannerChecklistItems?>("checklist"); }
            set { BackingStore?.Set("checklist", value); }
        }
#nullable restore
#else
        public PlannerChecklistItems Checklist {
            get { return BackingStore?.Get<PlannerChecklistItems>("checklist"); }
            set { BackingStore?.Set("checklist", value); }
        }
#endif
        /// <summary>Contains detailed information about requirements on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskCompletionRequirementDetails? CompletionRequirements {
            get { return BackingStore?.Get<PlannerTaskCompletionRequirementDetails?>("completionRequirements"); }
            set { BackingStore?.Set("completionRequirements", value); }
        }
#nullable restore
#else
        public PlannerTaskCompletionRequirementDetails CompletionRequirements {
            get { return BackingStore?.Get<PlannerTaskCompletionRequirementDetails>("completionRequirements"); }
            set { BackingStore?.Set("completionRequirements", value); }
        }
#endif
        /// <summary>Description of the task.</summary>
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
        /// <summary>The forms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFormsDictionary? Forms {
            get { return BackingStore?.Get<PlannerFormsDictionary?>("forms"); }
            set { BackingStore?.Set("forms", value); }
        }
#nullable restore
#else
        public PlannerFormsDictionary Forms {
            get { return BackingStore?.Get<PlannerFormsDictionary>("forms"); }
            set { BackingStore?.Set("forms", value); }
        }
#endif
        /// <summary>Rich text description of the task. To be used by HTML-aware clients. For backwards compatibility, a plain-text version of the HTML description will be synced to the &apos;description&apos; field. If this field hasn&apos;t previously been set but &apos;description&apos; has been, the existing description is synchronized to &apos;notes&apos; with minimal whitespace-preserving HTML markup. Setting both &apos;description&apos; and &apos;notes&apos; is an error and will result in an exception.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Notes {
            get { return BackingStore?.Get<ItemBody?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public ItemBody Notes {
            get { return BackingStore?.Get<ItemBody>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>This sets the type of preview that shows up on the task. Possible values are: automatic, noPreview, checklist, description, reference. When set to automatic the displayed preview is chosen by the app viewing the task.</summary>
        public PlannerPreviewType? PreviewType {
            get { return BackingStore?.Get<PlannerPreviewType?>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
        /// <summary>The collection of references on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerExternalReferences? References {
            get { return BackingStore?.Get<PlannerExternalReferences?>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#nullable restore
#else
        public PlannerExternalReferences References {
            get { return BackingStore?.Get<PlannerExternalReferences>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlannerTaskDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTaskDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"approvalAttachment", n => { ApprovalAttachment = n.GetObjectValue<PlannerBaseApprovalAttachment>(PlannerBaseApprovalAttachment.CreateFromDiscriminatorValue); } },
                {"checklist", n => { Checklist = n.GetObjectValue<PlannerChecklistItems>(PlannerChecklistItems.CreateFromDiscriminatorValue); } },
                {"completionRequirements", n => { CompletionRequirements = n.GetObjectValue<PlannerTaskCompletionRequirementDetails>(PlannerTaskCompletionRequirementDetails.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"forms", n => { Forms = n.GetObjectValue<PlannerFormsDictionary>(PlannerFormsDictionary.CreateFromDiscriminatorValue); } },
                {"notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"previewType", n => { PreviewType = n.GetEnumValue<PlannerPreviewType>(); } },
                {"references", n => { References = n.GetObjectValue<PlannerExternalReferences>(PlannerExternalReferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerBaseApprovalAttachment>("approvalAttachment", ApprovalAttachment);
            writer.WriteObjectValue<PlannerChecklistItems>("checklist", Checklist);
            writer.WriteObjectValue<PlannerTaskCompletionRequirementDetails>("completionRequirements", CompletionRequirements);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<PlannerFormsDictionary>("forms", Forms);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteEnumValue<PlannerPreviewType>("previewType", PreviewType);
            writer.WriteObjectValue<PlannerExternalReferences>("references", References);
        }
    }
}
