// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ImportedWindowsAutopilotDeviceIdentityState : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device error code reported by Device Directory Service(DDS).</summary>
        public int? DeviceErrorCode
        {
            get { return BackingStore?.Get<int?>("deviceErrorCode"); }
            set { BackingStore?.Set("deviceErrorCode", value); }
        }
        /// <summary>Device error name reported by Device Directory Service(DDS).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceErrorName
        {
            get { return BackingStore?.Get<string?>("deviceErrorName"); }
            set { BackingStore?.Set("deviceErrorName", value); }
        }
#nullable restore
#else
        public string DeviceErrorName
        {
            get { return BackingStore?.Get<string>("deviceErrorName"); }
            set { BackingStore?.Set("deviceErrorName", value); }
        }
#endif
        /// <summary>The deviceImportStatus property</summary>
        public Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityImportStatus? DeviceImportStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityImportStatus?>("deviceImportStatus"); }
            set { BackingStore?.Set("deviceImportStatus", value); }
        }
        /// <summary>Device Registration ID for successfully added device reported by Device Directory Service(DDS).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceRegistrationId
        {
            get { return BackingStore?.Get<string?>("deviceRegistrationId"); }
            set { BackingStore?.Set("deviceRegistrationId", value); }
        }
#nullable restore
#else
        public string DeviceRegistrationId
        {
            get { return BackingStore?.Get<string>("deviceRegistrationId"); }
            set { BackingStore?.Set("deviceRegistrationId", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityState"/> and sets the default values.
        /// </summary>
        public ImportedWindowsAutopilotDeviceIdentityState()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceErrorCode", n => { DeviceErrorCode = n.GetIntValue(); } },
                { "deviceErrorName", n => { DeviceErrorName = n.GetStringValue(); } },
                { "deviceImportStatus", n => { DeviceImportStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityImportStatus>(); } },
                { "deviceRegistrationId", n => { DeviceRegistrationId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceErrorCode", DeviceErrorCode);
            writer.WriteStringValue("deviceErrorName", DeviceErrorName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentityImportStatus>("deviceImportStatus", DeviceImportStatus);
            writer.WriteStringValue("deviceRegistrationId", DeviceRegistrationId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
