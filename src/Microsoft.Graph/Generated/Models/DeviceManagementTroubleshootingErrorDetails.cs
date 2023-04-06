using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Object containing detailed information about the error and its remediation.
    /// </summary>
    public class DeviceManagementTroubleshootingErrorDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Context {
            get { return BackingStore?.Get<string?>("context"); }
            set { BackingStore?.Set("context", value); }
        }
#nullable restore
#else
        public string Context {
            get { return BackingStore?.Get<string>("context"); }
            set { BackingStore?.Set("context", value); }
        }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Failure {
            get { return BackingStore?.Get<string?>("failure"); }
            set { BackingStore?.Set("failure", value); }
        }
#nullable restore
#else
        public string Failure {
            get { return BackingStore?.Get<string>("failure"); }
            set { BackingStore?.Set("failure", value); }
        }
#endif
        /// <summary>The detailed description of what went wrong.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailureDetails {
            get { return BackingStore?.Get<string?>("failureDetails"); }
            set { BackingStore?.Set("failureDetails", value); }
        }
#nullable restore
#else
        public string FailureDetails {
            get { return BackingStore?.Get<string>("failureDetails"); }
            set { BackingStore?.Set("failureDetails", value); }
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
        /// <summary>The detailed description of how to remediate this issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Remediation {
            get { return BackingStore?.Get<string?>("remediation"); }
            set { BackingStore?.Set("remediation", value); }
        }
#nullable restore
#else
        public string Remediation {
            get { return BackingStore?.Get<string>("remediation"); }
            set { BackingStore?.Set("remediation", value); }
        }
#endif
        /// <summary>Links to helpful documentation about this failure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTroubleshootingErrorResource>? Resources {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingErrorResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<DeviceManagementTroubleshootingErrorResource> Resources {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingErrorResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementTroubleshootingErrorDetails and sets the default values.
        /// </summary>
        public DeviceManagementTroubleshootingErrorDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementTroubleshootingErrorDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementTroubleshootingErrorDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"context", n => { Context = n.GetStringValue(); } },
                {"failure", n => { Failure = n.GetStringValue(); } },
                {"failureDetails", n => { FailureDetails = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"remediation", n => { Remediation = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingErrorResource>(DeviceManagementTroubleshootingErrorResource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("context", Context);
            writer.WriteStringValue("failure", Failure);
            writer.WriteStringValue("failureDetails", FailureDetails);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("remediation", Remediation);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingErrorResource>("resources", Resources);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
