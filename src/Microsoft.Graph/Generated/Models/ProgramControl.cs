using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ProgramControl : Entity, IParsable {
        /// <summary>The controlId of the control, in particular the identifier of an access review. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ControlId {
            get { return BackingStore?.Get<string?>("controlId"); }
            set { BackingStore?.Set("controlId", value); }
        }
#nullable restore
#else
        public string ControlId {
            get { return BackingStore?.Get<string>("controlId"); }
            set { BackingStore?.Set("controlId", value); }
        }
#endif
        /// <summary>The programControlType identifies the type of program control - for example, a control linking to guest access reviews. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ControlTypeId {
            get { return BackingStore?.Get<string?>("controlTypeId"); }
            set { BackingStore?.Set("controlTypeId", value); }
        }
#nullable restore
#else
        public string ControlTypeId {
            get { return BackingStore?.Get<string>("controlTypeId"); }
            set { BackingStore?.Set("controlTypeId", value); }
        }
#endif
        /// <summary>The creation date and time of the program control.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The name of the control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The user who created the program control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? Owner {
            get { return BackingStore?.Get<UserIdentity?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public UserIdentity Owner {
            get { return BackingStore?.Get<UserIdentity>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The program this control is part of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Program? Program {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Program?>("program"); }
            set { BackingStore?.Set("program", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Program Program {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Program>("program"); }
            set { BackingStore?.Set("program", value); }
        }
#endif
        /// <summary>The programId of the program this control is a part of. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProgramId {
            get { return BackingStore?.Get<string?>("programId"); }
            set { BackingStore?.Set("programId", value); }
        }
#nullable restore
#else
        public string ProgramId {
            get { return BackingStore?.Get<string>("programId"); }
            set { BackingStore?.Set("programId", value); }
        }
#endif
        /// <summary>The resource, a group or an app, targeted by this program control&apos;s access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProgramResource? Resource {
            get { return BackingStore?.Get<ProgramResource?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public ProgramResource Resource {
            get { return BackingStore?.Get<ProgramResource>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>The life cycle status of the control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProgramControl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProgramControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"controlId", n => { ControlId = n.GetStringValue(); } },
                {"controlTypeId", n => { ControlTypeId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"program", n => { Program = n.GetObjectValue<Microsoft.Graph.Beta.Models.Program>(Microsoft.Graph.Beta.Models.Program.CreateFromDiscriminatorValue); } },
                {"programId", n => { ProgramId = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<ProgramResource>(ProgramResource.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("controlId", ControlId);
            writer.WriteStringValue("controlTypeId", ControlTypeId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<UserIdentity>("owner", Owner);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Program>("program", Program);
            writer.WriteStringValue("programId", ProgramId);
            writer.WriteObjectValue<ProgramResource>("resource", Resource);
            writer.WriteStringValue("status", Status);
        }
    }
}
