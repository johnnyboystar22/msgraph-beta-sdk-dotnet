using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkNineWorkEasConfiguration : AndroidForWorkEasEmailProfileBase, IParsable {
        /// <summary>Toggles syncing the calendar. If set to false the calendar is turned off on the device.</summary>
        public bool? SyncCalendar {
            get { return BackingStore?.Get<bool?>("syncCalendar"); }
            set { BackingStore?.Set("syncCalendar", value); }
        }
        /// <summary>Toggles syncing contacts. If set to false contacts are turned off on the device.</summary>
        public bool? SyncContacts {
            get { return BackingStore?.Get<bool?>("syncContacts"); }
            set { BackingStore?.Set("syncContacts", value); }
        }
        /// <summary>Toggles syncing tasks. If set to false tasks are turned off on the device.</summary>
        public bool? SyncTasks {
            get { return BackingStore?.Get<bool?>("syncTasks"); }
            set { BackingStore?.Set("syncTasks", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidForWorkNineWorkEasConfiguration and sets the default values.
        /// </summary>
        public AndroidForWorkNineWorkEasConfiguration() : base() {
            OdataType = "#microsoft.graph.androidForWorkNineWorkEasConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidForWorkNineWorkEasConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkNineWorkEasConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"syncCalendar", n => { SyncCalendar = n.GetBoolValue(); } },
                {"syncContacts", n => { SyncContacts = n.GetBoolValue(); } },
                {"syncTasks", n => { SyncTasks = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("syncCalendar", SyncCalendar);
            writer.WriteBoolValue("syncContacts", SyncContacts);
            writer.WriteBoolValue("syncTasks", SyncTasks);
        }
    }
}
