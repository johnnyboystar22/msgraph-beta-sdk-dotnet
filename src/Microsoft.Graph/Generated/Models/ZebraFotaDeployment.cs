// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The Zebra FOTA deployment entity that describes settings, deployment device groups required to create a FOTA deployment, and deployment status.
    /// </summary>
    public class ZebraFotaDeployment : Entity, IParsable {
        /// <summary>Collection of Android FOTA Assignment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidFotaDeploymentAssignment>? DeploymentAssignments {
            get { return BackingStore?.Get<List<AndroidFotaDeploymentAssignment>?>("deploymentAssignments"); }
            set { BackingStore?.Set("deploymentAssignments", value); }
        }
#nullable restore
#else
        public List<AndroidFotaDeploymentAssignment> DeploymentAssignments {
            get { return BackingStore?.Get<List<AndroidFotaDeploymentAssignment>>("deploymentAssignments"); }
            set { BackingStore?.Set("deploymentAssignments", value); }
        }
#endif
        /// <summary>The Zebra FOTA deployment complex type that describes the settings required to create a FOTA deployment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ZebraFotaDeploymentSettings? DeploymentSettings {
            get { return BackingStore?.Get<ZebraFotaDeploymentSettings?>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#nullable restore
#else
        public ZebraFotaDeploymentSettings DeploymentSettings {
            get { return BackingStore?.Get<ZebraFotaDeploymentSettings>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#endif
        /// <summary>Represents the deployment status from Zebra. The status is a high level status of the deployment as opposed being a detailed status per device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ZebraFotaDeploymentStatus? DeploymentStatus {
            get { return BackingStore?.Get<ZebraFotaDeploymentStatus?>("deploymentStatus"); }
            set { BackingStore?.Set("deploymentStatus", value); }
        }
#nullable restore
#else
        public ZebraFotaDeploymentStatus DeploymentStatus {
            get { return BackingStore?.Get<ZebraFotaDeploymentStatus>("deploymentStatus"); }
            set { BackingStore?.Set("deploymentStatus", value); }
        }
#endif
        /// <summary>A human readable description of the deployment.</summary>
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
        /// <summary>A human readable name of the deployment.</summary>
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
        /// <summary>List of Scope Tags for this Entity instance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ZebraFotaDeployment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ZebraFotaDeployment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaDeployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deploymentAssignments", n => { DeploymentAssignments = n.GetCollectionOfObjectValues<AndroidFotaDeploymentAssignment>(AndroidFotaDeploymentAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<ZebraFotaDeploymentSettings>(ZebraFotaDeploymentSettings.CreateFromDiscriminatorValue); } },
                {"deploymentStatus", n => { DeploymentStatus = n.GetObjectValue<ZebraFotaDeploymentStatus>(ZebraFotaDeploymentStatus.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidFotaDeploymentAssignment>("deploymentAssignments", DeploymentAssignments);
            writer.WriteObjectValue<ZebraFotaDeploymentSettings>("deploymentSettings", DeploymentSettings);
            writer.WriteObjectValue<ZebraFotaDeploymentStatus>("deploymentStatus", DeploymentStatus);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
