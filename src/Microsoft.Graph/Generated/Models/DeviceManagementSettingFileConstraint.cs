// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Constraint enforcing the file extension is acceptable for a given setting
    /// </summary>
    public class DeviceManagementSettingFileConstraint : Microsoft.Graph.Beta.Models.DeviceManagementConstraint, IParsable
    {
        /// <summary>Acceptable file extensions to upload for this setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedExtensions
        {
            get { return BackingStore?.Get<List<string>?>("supportedExtensions"); }
            set { BackingStore?.Set("supportedExtensions", value); }
        }
#nullable restore
#else
        public List<string> SupportedExtensions
        {
            get { return BackingStore?.Get<List<string>>("supportedExtensions"); }
            set { BackingStore?.Set("supportedExtensions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingFileConstraint"/> and sets the default values.
        /// </summary>
        public DeviceManagementSettingFileConstraint() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementSettingFileConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingFileConstraint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementSettingFileConstraint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementSettingFileConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "supportedExtensions", n => { SupportedExtensions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("supportedExtensions", SupportedExtensions);
        }
    }
}
