using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class Workflow : WorkflowBase, IParsable {
        /// <summary>The deletedDateTime property</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The executionScope property</summary>
        public List<Microsoft.Graph.Beta.Models.User> ExecutionScope {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.User>>("executionScope"); }
            set { BackingStore?.Set("executionScope", value); }
        }
        /// <summary>The id property</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>The isSchedulingEnabled property</summary>
        public bool? IsSchedulingEnabled {
            get { return BackingStore?.Get<bool?>("isSchedulingEnabled"); }
            set { BackingStore?.Set("isSchedulingEnabled", value); }
        }
        /// <summary>The nextScheduleRunDateTime property</summary>
        public DateTimeOffset? NextScheduleRunDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("nextScheduleRunDateTime"); }
            set { BackingStore?.Set("nextScheduleRunDateTime", value); }
        }
        /// <summary>The runs property</summary>
        public List<Run> Runs {
            get { return BackingStore?.Get<List<Run>>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
        /// <summary>The taskReports property</summary>
        public List<TaskReport> TaskReports {
            get { return BackingStore?.Get<List<TaskReport>>("taskReports"); }
            set { BackingStore?.Set("taskReports", value); }
        }
        /// <summary>The userProcessingResults property</summary>
        public List<UserProcessingResult> UserProcessingResults {
            get { return BackingStore?.Get<List<UserProcessingResult>>("userProcessingResults"); }
            set { BackingStore?.Set("userProcessingResults", value); }
        }
        /// <summary>The version property</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>The versions property</summary>
        public List<WorkflowVersion> Versions {
            get { return BackingStore?.Get<List<WorkflowVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
        /// <summary>
        /// Instantiates a new Workflow and sets the default values.
        /// </summary>
        public Workflow() : base() {
            OdataType = "#microsoft.graph.identityGovernance.workflow";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Workflow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Workflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"executionScope", n => { ExecutionScope = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue).ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isSchedulingEnabled", n => { IsSchedulingEnabled = n.GetBoolValue(); } },
                {"nextScheduleRunDateTime", n => { NextScheduleRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"runs", n => { Runs = n.GetCollectionOfObjectValues<Run>(Run.CreateFromDiscriminatorValue).ToList(); } },
                {"taskReports", n => { TaskReports = n.GetCollectionOfObjectValues<TaskReport>(TaskReport.CreateFromDiscriminatorValue).ToList(); } },
                {"userProcessingResults", n => { UserProcessingResults = n.GetCollectionOfObjectValues<UserProcessingResult>(UserProcessingResult.CreateFromDiscriminatorValue).ToList(); } },
                {"version", n => { Version = n.GetIntValue(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<WorkflowVersion>(WorkflowVersion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.User>("executionScope", ExecutionScope);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isSchedulingEnabled", IsSchedulingEnabled);
            writer.WriteDateTimeOffsetValue("nextScheduleRunDateTime", NextScheduleRunDateTime);
            writer.WriteCollectionOfObjectValues<Run>("runs", Runs);
            writer.WriteCollectionOfObjectValues<TaskReport>("taskReports", TaskReports);
            writer.WriteCollectionOfObjectValues<UserProcessingResult>("userProcessingResults", UserProcessingResults);
            writer.WriteIntValue("version", Version);
            writer.WriteCollectionOfObjectValues<WorkflowVersion>("versions", Versions);
        }
    }
}
