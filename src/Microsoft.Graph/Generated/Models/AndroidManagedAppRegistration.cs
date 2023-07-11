using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents the synchronization details of an android app, with management capabilities, for a specific user.
    /// </summary>
    public class AndroidManagedAppRegistration : ManagedAppRegistration, IParsable {
        /// <summary>The patch version for the current android app registration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PatchVersion {
            get { return BackingStore?.Get<string?>("patchVersion"); }
            set { BackingStore?.Set("patchVersion", value); }
        }
#nullable restore
#else
        public string PatchVersion {
            get { return BackingStore?.Get<string>("patchVersion"); }
            set { BackingStore?.Set("patchVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new androidManagedAppRegistration and sets the default values.
        /// </summary>
        public AndroidManagedAppRegistration() : base() {
            OdataType = "#microsoft.graph.androidManagedAppRegistration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidManagedAppRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedAppRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"patchVersion", n => { PatchVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("patchVersion", PatchVersion);
        }
    }
}
