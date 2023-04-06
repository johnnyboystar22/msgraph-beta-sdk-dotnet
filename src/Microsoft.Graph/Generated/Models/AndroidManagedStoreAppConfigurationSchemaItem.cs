using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Single configuration item inside an Android application&apos;s custom configuration schema.
    /// </summary>
    public class AndroidManagedStoreAppConfigurationSchemaItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data type for a configuration item inside an Android application&apos;s custom configuration schema</summary>
        public AndroidManagedStoreAppConfigurationSchemaItemDataType? DataType {
            get { return BackingStore?.Get<AndroidManagedStoreAppConfigurationSchemaItemDataType?>("dataType"); }
            set { BackingStore?.Set("dataType", value); }
        }
        /// <summary>Default value for boolean type items, if specified by the app developer</summary>
        public bool? DefaultBoolValue {
            get { return BackingStore?.Get<bool?>("defaultBoolValue"); }
            set { BackingStore?.Set("defaultBoolValue", value); }
        }
        /// <summary>Default value for integer type items, if specified by the app developer</summary>
        public int? DefaultIntValue {
            get { return BackingStore?.Get<int?>("defaultIntValue"); }
            set { BackingStore?.Set("defaultIntValue", value); }
        }
        /// <summary>Default value for string array type items, if specified by the app developer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefaultStringArrayValue {
            get { return BackingStore?.Get<List<string>?>("defaultStringArrayValue"); }
            set { BackingStore?.Set("defaultStringArrayValue", value); }
        }
#nullable restore
#else
        public List<string> DefaultStringArrayValue {
            get { return BackingStore?.Get<List<string>>("defaultStringArrayValue"); }
            set { BackingStore?.Set("defaultStringArrayValue", value); }
        }
#endif
        /// <summary>Default value for string type items, if specified by the app developer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultStringValue {
            get { return BackingStore?.Get<string?>("defaultStringValue"); }
            set { BackingStore?.Set("defaultStringValue", value); }
        }
#nullable restore
#else
        public string DefaultStringValue {
            get { return BackingStore?.Get<string>("defaultStringValue"); }
            set { BackingStore?.Set("defaultStringValue", value); }
        }
#endif
        /// <summary>Description of what the item controls within the application</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Human readable name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Unique index the application uses to maintain nested schema items</summary>
        public int? Index {
            get { return BackingStore?.Get<int?>("index"); }
            set { BackingStore?.Set("index", value); }
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
        /// <summary>Index of parent schema item to track nested schema items</summary>
        public int? ParentIndex {
            get { return BackingStore?.Get<int?>("parentIndex"); }
            set { BackingStore?.Set("parentIndex", value); }
        }
        /// <summary>Unique key the application uses to identify the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchemaItemKey {
            get { return BackingStore?.Get<string?>("schemaItemKey"); }
            set { BackingStore?.Set("schemaItemKey", value); }
        }
#nullable restore
#else
        public string SchemaItemKey {
            get { return BackingStore?.Get<string>("schemaItemKey"); }
            set { BackingStore?.Set("schemaItemKey", value); }
        }
#endif
        /// <summary>List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? Selections {
            get { return BackingStore?.Get<List<KeyValuePair>?>("selections"); }
            set { BackingStore?.Set("selections", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> Selections {
            get { return BackingStore?.Get<List<KeyValuePair>>("selections"); }
            set { BackingStore?.Set("selections", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new androidManagedStoreAppConfigurationSchemaItem and sets the default values.
        /// </summary>
        public AndroidManagedStoreAppConfigurationSchemaItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidManagedStoreAppConfigurationSchemaItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedStoreAppConfigurationSchemaItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataType", n => { DataType = n.GetEnumValue<AndroidManagedStoreAppConfigurationSchemaItemDataType>(); } },
                {"defaultBoolValue", n => { DefaultBoolValue = n.GetBoolValue(); } },
                {"defaultIntValue", n => { DefaultIntValue = n.GetIntValue(); } },
                {"defaultStringArrayValue", n => { DefaultStringArrayValue = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defaultStringValue", n => { DefaultStringValue = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"index", n => { Index = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parentIndex", n => { ParentIndex = n.GetIntValue(); } },
                {"schemaItemKey", n => { SchemaItemKey = n.GetStringValue(); } },
                {"selections", n => { Selections = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AndroidManagedStoreAppConfigurationSchemaItemDataType>("dataType", DataType);
            writer.WriteBoolValue("defaultBoolValue", DefaultBoolValue);
            writer.WriteIntValue("defaultIntValue", DefaultIntValue);
            writer.WriteCollectionOfPrimitiveValues<string>("defaultStringArrayValue", DefaultStringArrayValue);
            writer.WriteStringValue("defaultStringValue", DefaultStringValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("index", Index);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("parentIndex", ParentIndex);
            writer.WriteStringValue("schemaItemKey", SchemaItemKey);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("selections", Selections);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
