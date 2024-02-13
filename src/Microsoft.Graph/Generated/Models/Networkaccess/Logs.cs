// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class Logs : Microsoft.Graph.Beta.Models.Entity, IParsable {
        /// <summary>A collection of remote network health events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RemoteNetworkHealthEvent>? RemoteNetworks {
            get { return BackingStore?.Get<List<RemoteNetworkHealthEvent>?>("remoteNetworks"); }
            set { BackingStore?.Set("remoteNetworks", value); }
        }
#nullable restore
#else
        public List<RemoteNetworkHealthEvent> RemoteNetworks {
            get { return BackingStore?.Get<List<RemoteNetworkHealthEvent>>("remoteNetworks"); }
            set { BackingStore?.Set("remoteNetworks", value); }
        }
#endif
        /// <summary>A network access traffic log entry that contains comprehensive information about network traffic events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NetworkAccessTraffic>? Traffic {
            get { return BackingStore?.Get<List<NetworkAccessTraffic>?>("traffic"); }
            set { BackingStore?.Set("traffic", value); }
        }
#nullable restore
#else
        public List<NetworkAccessTraffic> Traffic {
            get { return BackingStore?.Get<List<NetworkAccessTraffic>>("traffic"); }
            set { BackingStore?.Set("traffic", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Logs"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Logs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Logs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"remoteNetworks", n => { RemoteNetworks = n.GetCollectionOfObjectValues<RemoteNetworkHealthEvent>(RemoteNetworkHealthEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"traffic", n => { Traffic = n.GetCollectionOfObjectValues<NetworkAccessTraffic>(NetworkAccessTraffic.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<RemoteNetworkHealthEvent>("remoteNetworks", RemoteNetworks);
            writer.WriteCollectionOfObjectValues<NetworkAccessTraffic>("traffic", Traffic);
        }
    }
}
