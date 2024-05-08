// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class TeamsAppInstallation : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The set of resource-specific permissions consented to while installing or upgrading the teamsApp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamsAppPermissionSet? ConsentedPermissionSet {
            get { return BackingStore?.Get<TeamsAppPermissionSet?>("consentedPermissionSet"); }
            set { BackingStore?.Set("consentedPermissionSet", value); }
        }
#nullable restore
#else
        public TeamsAppPermissionSet ConsentedPermissionSet {
            get { return BackingStore?.Get<TeamsAppPermissionSet>("consentedPermissionSet"); }
            set { BackingStore?.Set("consentedPermissionSet", value); }
        }
#endif
        /// <summary>The scopeInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamsAppInstallationScopeInfo? ScopeInfo {
            get { return BackingStore?.Get<TeamsAppInstallationScopeInfo?>("scopeInfo"); }
            set { BackingStore?.Set("scopeInfo", value); }
        }
#nullable restore
#else
        public TeamsAppInstallationScopeInfo ScopeInfo {
            get { return BackingStore?.Get<TeamsAppInstallationScopeInfo>("scopeInfo"); }
            set { BackingStore?.Set("scopeInfo", value); }
        }
#endif
        /// <summary>The app that is installed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsApp? TeamsApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsApp?>("teamsApp"); }
            set { BackingStore?.Set("teamsApp", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsApp TeamsApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsApp>("teamsApp"); }
            set { BackingStore?.Set("teamsApp", value); }
        }
#endif
        /// <summary>The details of this version of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsAppDefinition? TeamsAppDefinition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDefinition?>("teamsAppDefinition"); }
            set { BackingStore?.Set("teamsAppDefinition", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsAppDefinition TeamsAppDefinition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDefinition>("teamsAppDefinition"); }
            set { BackingStore?.Set("teamsAppDefinition", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamsAppInstallation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.userScopeTeamsAppInstallation" => new UserScopeTeamsAppInstallation(),
                _ => new TeamsAppInstallation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"consentedPermissionSet", n => { ConsentedPermissionSet = n.GetObjectValue<TeamsAppPermissionSet>(TeamsAppPermissionSet.CreateFromDiscriminatorValue); } },
                {"scopeInfo", n => { ScopeInfo = n.GetObjectValue<TeamsAppInstallationScopeInfo>(TeamsAppInstallationScopeInfo.CreateFromDiscriminatorValue); } },
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsApp>(Microsoft.Graph.Beta.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppDefinition", n => { TeamsAppDefinition = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDefinition>(Microsoft.Graph.Beta.Models.TeamsAppDefinition.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<TeamsAppPermissionSet>("consentedPermissionSet", ConsentedPermissionSet);
            writer.WriteObjectValue<TeamsAppInstallationScopeInfo>("scopeInfo", ScopeInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDefinition>("teamsAppDefinition", TeamsAppDefinition);
        }
    }
}
