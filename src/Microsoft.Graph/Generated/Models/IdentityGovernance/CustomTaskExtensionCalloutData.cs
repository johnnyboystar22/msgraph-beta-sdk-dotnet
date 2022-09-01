using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class CustomTaskExtensionCalloutData : CustomExtensionData, IParsable {
        /// <summary>The subject property</summary>
        public Microsoft.Graph.Beta.Models.User Subject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>The task property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject TaskObject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task"); }
            set { BackingStore?.Set("task", value); }
        }
        /// <summary>The taskProcessingresult property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult TaskProcessingresult {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult>("taskProcessingresult"); }
            set { BackingStore?.Set("taskProcessingresult", value); }
        }
        /// <summary>The workflow property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow Workflow {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow>("workflow"); }
            set { BackingStore?.Set("workflow", value); }
        }
        /// <summary>
        /// Instantiates a new CustomTaskExtensionCalloutData and sets the default values.
        /// </summary>
        public CustomTaskExtensionCalloutData() : base() {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtensionCalloutData";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomTaskExtensionCalloutData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomTaskExtensionCalloutData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"subject", n => { Subject = n.GetObjectValue<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                {"task", n => { TaskObject = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>(Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
                {"taskProcessingresult", n => { TaskProcessingresult = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult>(Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult.CreateFromDiscriminatorValue); } },
                {"workflow", n => { Workflow = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow>(Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.User>("subject", Subject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task", TaskObject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult>("taskProcessingresult", TaskProcessingresult);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow>("workflow", Workflow);
        }
    }
}
