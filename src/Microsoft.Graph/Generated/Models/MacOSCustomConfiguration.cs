// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the macOSCustomConfiguration resource.
    /// </summary>
    public class MacOSCustomConfiguration : Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Indicates the channel used to deploy the configuration profile. Available choices are DeviceChannel, UserChannel</summary>
        public Microsoft.Graph.Beta.Models.AppleDeploymentChannel? DeploymentChannel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppleDeploymentChannel?>("deploymentChannel"); }
            set { BackingStore?.Set("deploymentChannel", value); }
        }
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Payload
        {
            get { return BackingStore?.Get<byte[]?>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#nullable restore
#else
        public byte[] Payload
        {
            get { return BackingStore?.Get<byte[]>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#endif
        /// <summary>Payload file name (.mobileconfig</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadFileName
        {
            get { return BackingStore?.Get<string?>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#nullable restore
#else
        public string PayloadFileName
        {
            get { return BackingStore?.Get<string>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#endif
        /// <summary>Name that is displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadName
        {
            get { return BackingStore?.Get<string?>("payloadName"); }
            set { BackingStore?.Set("payloadName", value); }
        }
#nullable restore
#else
        public string PayloadName
        {
            get { return BackingStore?.Get<string>("payloadName"); }
            set { BackingStore?.Set("payloadName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MacOSCustomConfiguration"/> and sets the default values.
        /// </summary>
        public MacOSCustomConfiguration() : base()
        {
            OdataType = "#microsoft.graph.macOSCustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MacOSCustomConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MacOSCustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MacOSCustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deploymentChannel", n => { DeploymentChannel = n.GetEnumValue<Microsoft.Graph.Beta.Models.AppleDeploymentChannel>(); } },
                { "payload", n => { Payload = n.GetByteArrayValue(); } },
                { "payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                { "payloadName", n => { PayloadName = n.GetStringValue(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AppleDeploymentChannel>("deploymentChannel", DeploymentChannel);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteStringValue("payloadName", PayloadName);
        }
    }
}
