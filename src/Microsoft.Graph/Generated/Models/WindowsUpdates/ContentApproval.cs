// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    #pragma warning disable CS1591
    public class ContentApproval : Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent? Content
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent Content
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>Deployments created as a result of applying the approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>? Deployments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>?>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment> Deployments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#endif
        /// <summary>Settings for governing how to deploy content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings? DeploymentSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings?>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings DeploymentSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApproval"/> and sets the default values.
        /// </summary>
        public ContentApproval() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.contentApproval";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApproval"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApproval CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApproval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "content", n => { Content = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent>(Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent.CreateFromDiscriminatorValue); } },
                { "deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>(Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
                { "deployments", n => { Deployments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>(Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent>("content", Content);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>("deployments", Deployments);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings", DeploymentSettings);
        }
    }
}
