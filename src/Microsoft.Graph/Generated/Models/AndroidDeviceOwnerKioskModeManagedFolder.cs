// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A folder containing pages of apps and weblinks on the Managed Home Screen
    /// </summary>
    public class AndroidDeviceOwnerKioskModeManagedFolder : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Unique identifier for the folder</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FolderIdentifier {
            get { return BackingStore?.Get<string?>("folderIdentifier"); }
            set { BackingStore?.Set("folderIdentifier", value); }
        }
#nullable restore
#else
        public string FolderIdentifier {
            get { return BackingStore?.Get<string>("folderIdentifier"); }
            set { BackingStore?.Set("folderIdentifier", value); }
        }
#endif
        /// <summary>Display name for the folder</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FolderName {
            get { return BackingStore?.Get<string?>("folderName"); }
            set { BackingStore?.Set("folderName", value); }
        }
#nullable restore
#else
        public string FolderName {
            get { return BackingStore?.Get<string>("folderName"); }
            set { BackingStore?.Set("folderName", value); }
        }
#endif
        /// <summary>Items to be added to managed folder. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerKioskModeFolderItem>? Items {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeFolderItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerKioskModeFolderItem> Items {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeFolderItem>>("items"); }
            set { BackingStore?.Set("items", value); }
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
        /// Instantiates a new <see cref="AndroidDeviceOwnerKioskModeManagedFolder"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeManagedFolder() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidDeviceOwnerKioskModeManagedFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidDeviceOwnerKioskModeManagedFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerKioskModeManagedFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"folderIdentifier", n => { FolderIdentifier = n.GetStringValue(); } },
                {"folderName", n => { FolderName = n.GetStringValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<AndroidDeviceOwnerKioskModeFolderItem>(AndroidDeviceOwnerKioskModeFolderItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("folderIdentifier", FolderIdentifier);
            writer.WriteStringValue("folderName", FolderName);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerKioskModeFolderItem>("items", Items);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
