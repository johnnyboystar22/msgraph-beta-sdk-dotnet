using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.AssignedAccessMultiModeProfiles {
    public class AssignedAccessMultiModeProfilesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The assignedAccessMultiModeProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsAssignedAccessProfile>? AssignedAccessMultiModeProfiles {
            get { return BackingStore?.Get<List<WindowsAssignedAccessProfile>?>("assignedAccessMultiModeProfiles"); }
            set { BackingStore?.Set("assignedAccessMultiModeProfiles", value); }
        }
#nullable restore
#else
        public List<WindowsAssignedAccessProfile> AssignedAccessMultiModeProfiles {
            get { return BackingStore?.Get<List<WindowsAssignedAccessProfile>>("assignedAccessMultiModeProfiles"); }
            set { BackingStore?.Set("assignedAccessMultiModeProfiles", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new assignedAccessMultiModeProfilesPostRequestBody and sets the default values.
        /// </summary>
        public AssignedAccessMultiModeProfilesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignedAccessMultiModeProfilesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignedAccessMultiModeProfilesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedAccessMultiModeProfiles", n => { AssignedAccessMultiModeProfiles = n.GetCollectionOfObjectValues<WindowsAssignedAccessProfile>(WindowsAssignedAccessProfile.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WindowsAssignedAccessProfile>("assignedAccessMultiModeProfiles", AssignedAccessMultiModeProfiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
