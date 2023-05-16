using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesCurrentExportData : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the onPremises client machine which ran the last export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientMachineName {
            get { return BackingStore?.Get<string?>("clientMachineName"); }
            set { BackingStore?.Set("clientMachineName", value); }
        }
#nullable restore
#else
        public string ClientMachineName {
            get { return BackingStore?.Get<string>("clientMachineName"); }
            set { BackingStore?.Set("clientMachineName", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The count of pending adds from on-premises directory.</summary>
        public int? PendingObjectsAddition {
            get { return BackingStore?.Get<int?>("pendingObjectsAddition"); }
            set { BackingStore?.Set("pendingObjectsAddition", value); }
        }
        /// <summary>The count of pending deletes from on-premises directory.</summary>
        public int? PendingObjectsDeletion {
            get { return BackingStore?.Get<int?>("pendingObjectsDeletion"); }
            set { BackingStore?.Set("pendingObjectsDeletion", value); }
        }
        /// <summary>The count of pending updates from on-premises directory.</summary>
        public int? PendingObjectsUpdate {
            get { return BackingStore?.Get<int?>("pendingObjectsUpdate"); }
            set { BackingStore?.Set("pendingObjectsUpdate", value); }
        }
        /// <summary>The name of the dirsync service account which is configured to connect to the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceAccount {
            get { return BackingStore?.Get<string?>("serviceAccount"); }
            set { BackingStore?.Set("serviceAccount", value); }
        }
#nullable restore
#else
        public string ServiceAccount {
            get { return BackingStore?.Get<string>("serviceAccount"); }
            set { BackingStore?.Set("serviceAccount", value); }
        }
#endif
        /// <summary>The count of updated links during the current directory sync export run.</summary>
        public long? SuccessfulLinksProvisioningCount {
            get { return BackingStore?.Get<long?>("successfulLinksProvisioningCount"); }
            set { BackingStore?.Set("successfulLinksProvisioningCount", value); }
        }
        /// <summary>The count of objects which were successfully provisioned during the current directory sync export run.</summary>
        public int? SuccessfulObjectsProvisioningCount {
            get { return BackingStore?.Get<int?>("successfulObjectsProvisioningCount"); }
            set { BackingStore?.Set("successfulObjectsProvisioningCount", value); }
        }
        /// <summary>The total number of objects in the AAD Connector Space.</summary>
        public int? TotalConnectorSpaceObjects {
            get { return BackingStore?.Get<int?>("totalConnectorSpaceObjects"); }
            set { BackingStore?.Set("totalConnectorSpaceObjects", value); }
        }
        /// <summary>
        /// Instantiates a new onPremisesCurrentExportData and sets the default values.
        /// </summary>
        public OnPremisesCurrentExportData() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesCurrentExportData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesCurrentExportData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientMachineName", n => { ClientMachineName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"pendingObjectsAddition", n => { PendingObjectsAddition = n.GetIntValue(); } },
                {"pendingObjectsDeletion", n => { PendingObjectsDeletion = n.GetIntValue(); } },
                {"pendingObjectsUpdate", n => { PendingObjectsUpdate = n.GetIntValue(); } },
                {"serviceAccount", n => { ServiceAccount = n.GetStringValue(); } },
                {"successfulLinksProvisioningCount", n => { SuccessfulLinksProvisioningCount = n.GetLongValue(); } },
                {"successfulObjectsProvisioningCount", n => { SuccessfulObjectsProvisioningCount = n.GetIntValue(); } },
                {"totalConnectorSpaceObjects", n => { TotalConnectorSpaceObjects = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientMachineName", ClientMachineName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("pendingObjectsAddition", PendingObjectsAddition);
            writer.WriteIntValue("pendingObjectsDeletion", PendingObjectsDeletion);
            writer.WriteIntValue("pendingObjectsUpdate", PendingObjectsUpdate);
            writer.WriteStringValue("serviceAccount", ServiceAccount);
            writer.WriteLongValue("successfulLinksProvisioningCount", SuccessfulLinksProvisioningCount);
            writer.WriteIntValue("successfulObjectsProvisioningCount", SuccessfulObjectsProvisioningCount);
            writer.WriteIntValue("totalConnectorSpaceObjects", TotalConnectorSpaceObjects);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
