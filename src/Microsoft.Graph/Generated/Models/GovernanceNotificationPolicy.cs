using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class GovernanceNotificationPolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The enabledTemplateTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledTemplateTypes {
            get { return BackingStore?.Get<List<string>?>("enabledTemplateTypes"); }
            set { BackingStore?.Set("enabledTemplateTypes", value); }
        }
#nullable restore
#else
        public List<string> EnabledTemplateTypes {
            get { return BackingStore?.Get<List<string>>("enabledTemplateTypes"); }
            set { BackingStore?.Set("enabledTemplateTypes", value); }
        }
#endif
        /// <summary>The notificationTemplates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GovernanceNotificationTemplate>? NotificationTemplates {
            get { return BackingStore?.Get<List<GovernanceNotificationTemplate>?>("notificationTemplates"); }
            set { BackingStore?.Set("notificationTemplates", value); }
        }
#nullable restore
#else
        public List<GovernanceNotificationTemplate> NotificationTemplates {
            get { return BackingStore?.Get<List<GovernanceNotificationTemplate>>("notificationTemplates"); }
            set { BackingStore?.Set("notificationTemplates", value); }
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
        /// <summary>
        /// Instantiates a new governanceNotificationPolicy and sets the default values.
        /// </summary>
        public GovernanceNotificationPolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GovernanceNotificationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceNotificationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"enabledTemplateTypes", n => { EnabledTemplateTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notificationTemplates", n => { NotificationTemplates = n.GetCollectionOfObjectValues<GovernanceNotificationTemplate>(GovernanceNotificationTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("enabledTemplateTypes", EnabledTemplateTypes);
            writer.WriteCollectionOfObjectValues<GovernanceNotificationTemplate>("notificationTemplates", NotificationTemplates);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
