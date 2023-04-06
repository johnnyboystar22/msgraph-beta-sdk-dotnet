using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftStoreForBusinessContainedApp : MobileContainedApp, IParsable {
        /// <summary>The app user model ID of the contained app of a MicrosoftStoreForBusinessApp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUserModelId {
            get { return BackingStore?.Get<string?>("appUserModelId"); }
            set { BackingStore?.Set("appUserModelId", value); }
        }
#nullable restore
#else
        public string AppUserModelId {
            get { return BackingStore?.Get<string>("appUserModelId"); }
            set { BackingStore?.Set("appUserModelId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new MicrosoftStoreForBusinessContainedApp and sets the default values.
        /// </summary>
        public MicrosoftStoreForBusinessContainedApp() : base() {
            OdataType = "#microsoft.graph.microsoftStoreForBusinessContainedApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftStoreForBusinessContainedApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftStoreForBusinessContainedApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appUserModelId", n => { AppUserModelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appUserModelId", AppUserModelId);
        }
    }
}
