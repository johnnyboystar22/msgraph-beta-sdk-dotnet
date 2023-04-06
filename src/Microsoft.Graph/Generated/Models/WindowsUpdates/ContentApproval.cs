using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class ContentApproval : ComplianceChange, IParsable {
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeployableContent? Content {
            get { return BackingStore?.Get<DeployableContent?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public DeployableContent Content {
            get { return BackingStore?.Get<DeployableContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>Deployments created as a result of applying the approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Deployment>? Deployments {
            get { return BackingStore?.Get<List<Deployment>?>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#nullable restore
#else
        public List<Deployment> Deployments {
            get { return BackingStore?.Get<List<Deployment>>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#endif
        /// <summary>Settings for governing how to deploy content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings? DeploymentSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings?>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings DeploymentSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ContentApproval and sets the default values.
        /// </summary>
        public ContentApproval() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.contentApproval";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContentApproval CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentApproval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetObjectValue<DeployableContent>(DeployableContent.CreateFromDiscriminatorValue); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<Deployment>(Deployment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>(Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeployableContent>("content", Content);
            writer.WriteCollectionOfObjectValues<Deployment>("deployments", Deployments);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings", DeploymentSettings);
        }
    }
}
