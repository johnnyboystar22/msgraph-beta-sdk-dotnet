using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CrossTenantAccessPolicy : TenantRelationshipAccessPolicyBase, IParsable {
        /// <summary>Used to specify which Microsoft clouds an organization would like to collaborate with. By default, this value is empty. Supported values for this field are: microsoftonline.com, microsoftonline.us, and partner.microsoftonline.cn.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedCloudEndpoints {
            get { return BackingStore?.Get<List<string>?>("allowedCloudEndpoints"); }
            set { BackingStore?.Set("allowedCloudEndpoints", value); }
        }
#nullable restore
#else
        public List<string> AllowedCloudEndpoints {
            get { return BackingStore?.Get<List<string>>("allowedCloudEndpoints"); }
            set { BackingStore?.Set("allowedCloudEndpoints", value); }
        }
#endif
        /// <summary>Defines the default configuration for how your organization interacts with external Azure Active Directory organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyConfigurationDefault? Default {
            get { return BackingStore?.Get<CrossTenantAccessPolicyConfigurationDefault?>("default"); }
            set { BackingStore?.Set("default", value); }
        }
#nullable restore
#else
        public CrossTenantAccessPolicyConfigurationDefault Default {
            get { return BackingStore?.Get<CrossTenantAccessPolicyConfigurationDefault>("default"); }
            set { BackingStore?.Set("default", value); }
        }
#endif
        /// <summary>Defines partner-specific configurations for external Azure Active Directory organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CrossTenantAccessPolicyConfigurationPartner>? Partners {
            get { return BackingStore?.Get<List<CrossTenantAccessPolicyConfigurationPartner>?>("partners"); }
            set { BackingStore?.Set("partners", value); }
        }
#nullable restore
#else
        public List<CrossTenantAccessPolicyConfigurationPartner> Partners {
            get { return BackingStore?.Get<List<CrossTenantAccessPolicyConfigurationPartner>>("partners"); }
            set { BackingStore?.Set("partners", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicy and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicy() : base() {
            OdataType = "#microsoft.graph.crossTenantAccessPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CrossTenantAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedCloudEndpoints", n => { AllowedCloudEndpoints = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"default", n => { Default = n.GetObjectValue<CrossTenantAccessPolicyConfigurationDefault>(CrossTenantAccessPolicyConfigurationDefault.CreateFromDiscriminatorValue); } },
                {"partners", n => { Partners = n.GetCollectionOfObjectValues<CrossTenantAccessPolicyConfigurationPartner>(CrossTenantAccessPolicyConfigurationPartner.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedCloudEndpoints", AllowedCloudEndpoints);
            writer.WriteObjectValue<CrossTenantAccessPolicyConfigurationDefault>("default", Default);
            writer.WriteCollectionOfObjectValues<CrossTenantAccessPolicyConfigurationPartner>("partners", Partners);
        }
    }
}
