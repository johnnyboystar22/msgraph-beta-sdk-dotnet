using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics tenant level information for all the device scope configurations
    /// </summary>
    public class UserExperienceAnalyticsDeviceScopeSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A collection of the user experience analytics device scope Unique Identifiers that are enabled and finished recalculating the report metric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CompletedDeviceScopeIds {
            get { return BackingStore?.Get<List<string>?>("completedDeviceScopeIds"); }
            set { BackingStore?.Set("completedDeviceScopeIds", value); }
        }
#nullable restore
#else
        public List<string> CompletedDeviceScopeIds {
            get { return BackingStore?.Get<List<string>>("completedDeviceScopeIds"); }
            set { BackingStore?.Set("completedDeviceScopeIds", value); }
        }
#endif
        /// <summary>A collection of user experience analytics device scope Unique Identitfiers that are enabled but there is insufficient data to calculate results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InsufficientDataDeviceScopeIds {
            get { return BackingStore?.Get<List<string>?>("insufficientDataDeviceScopeIds"); }
            set { BackingStore?.Set("insufficientDataDeviceScopeIds", value); }
        }
#nullable restore
#else
        public List<string> InsufficientDataDeviceScopeIds {
            get { return BackingStore?.Get<List<string>>("insufficientDataDeviceScopeIds"); }
            set { BackingStore?.Set("insufficientDataDeviceScopeIds", value); }
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
        /// <summary>The total number of user experience analytics device scopes. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceScopes {
            get { return BackingStore?.Get<int?>("totalDeviceScopes"); }
            set { BackingStore?.Set("totalDeviceScopes", value); }
        }
        /// <summary>The total number of user experience analytics device scopes that are enabled. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceScopesEnabled {
            get { return BackingStore?.Get<int?>("totalDeviceScopesEnabled"); }
            set { BackingStore?.Set("totalDeviceScopesEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsDeviceScopeSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsDeviceScopeSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsDeviceScopeSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceScopeSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedDeviceScopeIds", n => { CompletedDeviceScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"insufficientDataDeviceScopeIds", n => { InsufficientDataDeviceScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalDeviceScopes", n => { TotalDeviceScopes = n.GetIntValue(); } },
                {"totalDeviceScopesEnabled", n => { TotalDeviceScopesEnabled = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("completedDeviceScopeIds", CompletedDeviceScopeIds);
            writer.WriteCollectionOfPrimitiveValues<string>("insufficientDataDeviceScopeIds", InsufficientDataDeviceScopeIds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("totalDeviceScopes", TotalDeviceScopes);
            writer.WriteIntValue("totalDeviceScopesEnabled", TotalDeviceScopesEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
