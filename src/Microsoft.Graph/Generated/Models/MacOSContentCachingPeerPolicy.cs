using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determines which content caches other content caches will peer with.</summary>
    public enum MacOSContentCachingPeerPolicy {
        /// <summary>Defaults to peers in local network.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Content caches will only peer with caches in their immediate local network.</summary>
        [EnumMember(Value = "peersInLocalNetwork")]
        PeersInLocalNetwork,
        /// <summary>Content caches will only peer with caches that share the same public IP address.</summary>
        [EnumMember(Value = "peersWithSamePublicIpAddress")]
        PeersWithSamePublicIpAddress,
        /// <summary>Content caches will use contentCachingPeerFilterRanges and contentCachingPeerListenRanges to determine which caches to peer with.</summary>
        [EnumMember(Value = "peersInCustomLocalNetworks")]
        PeersInCustomLocalNetworks,
    }
}
