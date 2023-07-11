using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity representing a template setting category
    /// </summary>
    public class DeviceManagementTemplateSettingCategory : DeviceManagementSettingCategory, IParsable {
        /// <summary>The settings this category contains</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementSettingInstance>? RecommendedSettings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>?>("recommendedSettings"); }
            set { BackingStore?.Set("recommendedSettings", value); }
        }
#nullable restore
#else
        public List<DeviceManagementSettingInstance> RecommendedSettings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>>("recommendedSettings"); }
            set { BackingStore?.Set("recommendedSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementTemplateSettingCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementTemplateSettingCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"recommendedSettings", n => { RecommendedSettings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("recommendedSettings", RecommendedSettings);
        }
    }
}
