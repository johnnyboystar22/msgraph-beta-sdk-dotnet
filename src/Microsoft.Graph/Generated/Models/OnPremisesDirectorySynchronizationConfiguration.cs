using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesDirectorySynchronizationConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Contains the accidental deletion prevention configuration for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesAccidentalDeletionPrevention? AccidentalDeletionPrevention {
            get { return BackingStore?.Get<OnPremisesAccidentalDeletionPrevention?>("accidentalDeletionPrevention"); }
            set { BackingStore?.Set("accidentalDeletionPrevention", value); }
        }
#nullable restore
#else
        public OnPremisesAccidentalDeletionPrevention AccidentalDeletionPrevention {
            get { return BackingStore?.Get<OnPremisesAccidentalDeletionPrevention>("accidentalDeletionPrevention"); }
            set { BackingStore?.Set("accidentalDeletionPrevention", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The anchor attribute allows customers to customize the property used to create source anchors for synchronization enabled objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnchorAttribute {
            get { return BackingStore?.Get<string?>("anchorAttribute"); }
            set { BackingStore?.Set("anchorAttribute", value); }
        }
#nullable restore
#else
        public string AnchorAttribute {
            get { return BackingStore?.Get<string>("anchorAttribute"); }
            set { BackingStore?.Set("anchorAttribute", value); }
        }
#endif
        /// <summary>The identifier of the on-premises directory synchronization client application that is configured for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationId {
            get { return BackingStore?.Get<string?>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#nullable restore
#else
        public string ApplicationId {
            get { return BackingStore?.Get<string>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data for the current export run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesCurrentExportData? CurrentExportData {
            get { return BackingStore?.Get<OnPremisesCurrentExportData?>("currentExportData"); }
            set { BackingStore?.Set("currentExportData", value); }
        }
#nullable restore
#else
        public OnPremisesCurrentExportData CurrentExportData {
            get { return BackingStore?.Get<OnPremisesCurrentExportData>("currentExportData"); }
            set { BackingStore?.Set("currentExportData", value); }
        }
#endif
        /// <summary>Interval of time that the customer requested the sync client waits between sync cycles.</summary>
        public TimeSpan? CustomerRequestedSynchronizationInterval {
            get { return BackingStore?.Get<TimeSpan?>("customerRequestedSynchronizationInterval"); }
            set { BackingStore?.Set("customerRequestedSynchronizationInterval", value); }
        }
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
        /// <summary>Indicates the version of the on-premises directory synchronization application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SynchronizationClientVersion {
            get { return BackingStore?.Get<string?>("synchronizationClientVersion"); }
            set { BackingStore?.Set("synchronizationClientVersion", value); }
        }
#nullable restore
#else
        public string SynchronizationClientVersion {
            get { return BackingStore?.Get<string>("synchronizationClientVersion"); }
            set { BackingStore?.Set("synchronizationClientVersion", value); }
        }
#endif
        /// <summary>Interval of time the sync client should honor between sync cycles</summary>
        public TimeSpan? SynchronizationInterval {
            get { return BackingStore?.Get<TimeSpan?>("synchronizationInterval"); }
            set { BackingStore?.Set("synchronizationInterval", value); }
        }
        /// <summary>Configuration to control how cloud created or owned objects are synchronized back to the on-premises directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesWritebackConfiguration? WritebackConfiguration {
            get { return BackingStore?.Get<OnPremisesWritebackConfiguration?>("writebackConfiguration"); }
            set { BackingStore?.Set("writebackConfiguration", value); }
        }
#nullable restore
#else
        public OnPremisesWritebackConfiguration WritebackConfiguration {
            get { return BackingStore?.Get<OnPremisesWritebackConfiguration>("writebackConfiguration"); }
            set { BackingStore?.Set("writebackConfiguration", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onPremisesDirectorySynchronizationConfiguration and sets the default values.
        /// </summary>
        public OnPremisesDirectorySynchronizationConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesDirectorySynchronizationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesDirectorySynchronizationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accidentalDeletionPrevention", n => { AccidentalDeletionPrevention = n.GetObjectValue<OnPremisesAccidentalDeletionPrevention>(OnPremisesAccidentalDeletionPrevention.CreateFromDiscriminatorValue); } },
                {"anchorAttribute", n => { AnchorAttribute = n.GetStringValue(); } },
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"currentExportData", n => { CurrentExportData = n.GetObjectValue<OnPremisesCurrentExportData>(OnPremisesCurrentExportData.CreateFromDiscriminatorValue); } },
                {"customerRequestedSynchronizationInterval", n => { CustomerRequestedSynchronizationInterval = n.GetTimeSpanValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"synchronizationClientVersion", n => { SynchronizationClientVersion = n.GetStringValue(); } },
                {"synchronizationInterval", n => { SynchronizationInterval = n.GetTimeSpanValue(); } },
                {"writebackConfiguration", n => { WritebackConfiguration = n.GetObjectValue<OnPremisesWritebackConfiguration>(OnPremisesWritebackConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<OnPremisesAccidentalDeletionPrevention>("accidentalDeletionPrevention", AccidentalDeletionPrevention);
            writer.WriteStringValue("anchorAttribute", AnchorAttribute);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteObjectValue<OnPremisesCurrentExportData>("currentExportData", CurrentExportData);
            writer.WriteTimeSpanValue("customerRequestedSynchronizationInterval", CustomerRequestedSynchronizationInterval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("synchronizationClientVersion", SynchronizationClientVersion);
            writer.WriteTimeSpanValue("synchronizationInterval", SynchronizationInterval);
            writer.WriteObjectValue<OnPremisesWritebackConfiguration>("writebackConfiguration", WritebackConfiguration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
