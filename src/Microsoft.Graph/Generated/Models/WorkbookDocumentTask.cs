// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookDocumentTask : Entity, IParsable {
        /// <summary>A collection of user identities the task is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookEmailIdentity>? Assignees {
            get { return BackingStore?.Get<List<WorkbookEmailIdentity>?>("assignees"); }
            set { BackingStore?.Set("assignees", value); }
        }
#nullable restore
#else
        public List<WorkbookEmailIdentity> Assignees {
            get { return BackingStore?.Get<List<WorkbookEmailIdentity>>("assignees"); }
            set { BackingStore?.Set("assignees", value); }
        }
#endif
        /// <summary>A collection of task change histories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookDocumentTaskChange>? Changes {
            get { return BackingStore?.Get<List<WorkbookDocumentTaskChange>?>("changes"); }
            set { BackingStore?.Set("changes", value); }
        }
#nullable restore
#else
        public List<WorkbookDocumentTaskChange> Changes {
            get { return BackingStore?.Get<List<WorkbookDocumentTaskChange>>("changes"); }
            set { BackingStore?.Set("changes", value); }
        }
#endif
        /// <summary>The comment that the task is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookComment? Comment {
            get { return BackingStore?.Get<WorkbookComment?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public WorkbookComment Comment {
            get { return BackingStore?.Get<WorkbookComment>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The identity of the user who completed the task. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookEmailIdentity? CompletedBy {
            get { return BackingStore?.Get<WorkbookEmailIdentity?>("completedBy"); }
            set { BackingStore?.Set("completedBy", value); }
        }
#nullable restore
#else
        public WorkbookEmailIdentity CompletedBy {
            get { return BackingStore?.Get<WorkbookEmailIdentity>("completedBy"); }
            set { BackingStore?.Set("completedBy", value); }
        }
#endif
        /// <summary>Date and time when the task was completed. Nullable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>A user identity that creates the task. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookEmailIdentity? CreatedBy {
            get { return BackingStore?.Get<WorkbookEmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public WorkbookEmailIdentity CreatedBy {
            get { return BackingStore?.Get<WorkbookEmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time when the task was created. Nullable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>An integer value from 0 to 100 that represents the percentage of the completion of the task. 100 means that the task is completed. Nullable.</summary>
        public int? PercentComplete {
            get { return BackingStore?.Get<int?>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
        /// <summary>An integer value from 0 to 10 that represents the priority of the task. A lower value indicates a higher priority. Nullable.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Start and due date of the task. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookDocumentTaskSchedule? StartAndDueDateTime {
            get { return BackingStore?.Get<WorkbookDocumentTaskSchedule?>("startAndDueDateTime"); }
            set { BackingStore?.Set("startAndDueDateTime", value); }
        }
#nullable restore
#else
        public WorkbookDocumentTaskSchedule StartAndDueDateTime {
            get { return BackingStore?.Get<WorkbookDocumentTaskSchedule>("startAndDueDateTime"); }
            set { BackingStore?.Set("startAndDueDateTime", value); }
        }
#endif
        /// <summary>The title of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkbookDocumentTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookDocumentTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookDocumentTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignees", n => { Assignees = n.GetCollectionOfObjectValues<WorkbookEmailIdentity>(WorkbookEmailIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"changes", n => { Changes = n.GetCollectionOfObjectValues<WorkbookDocumentTaskChange>(WorkbookDocumentTaskChange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"comment", n => { Comment = n.GetObjectValue<WorkbookComment>(WorkbookComment.CreateFromDiscriminatorValue); } },
                {"completedBy", n => { CompletedBy = n.GetObjectValue<WorkbookEmailIdentity>(WorkbookEmailIdentity.CreateFromDiscriminatorValue); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<WorkbookEmailIdentity>(WorkbookEmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"percentComplete", n => { PercentComplete = n.GetIntValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"startAndDueDateTime", n => { StartAndDueDateTime = n.GetObjectValue<WorkbookDocumentTaskSchedule>(WorkbookDocumentTaskSchedule.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookEmailIdentity>("assignees", Assignees);
            writer.WriteCollectionOfObjectValues<WorkbookDocumentTaskChange>("changes", Changes);
            writer.WriteObjectValue<WorkbookComment>("comment", Comment);
            writer.WriteObjectValue<WorkbookEmailIdentity>("completedBy", CompletedBy);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<WorkbookEmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<WorkbookDocumentTaskSchedule>("startAndDueDateTime", StartAndDueDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
