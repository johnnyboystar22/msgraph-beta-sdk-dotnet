using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Apple network interface type.</summary>
    public enum WiredNetworkInterface {
        /// <summary>Any Ethernet.</summary>
        [EnumMember(Value = "anyEthernet")]
        AnyEthernet,
        /// <summary>First active Ethernet.</summary>
        [EnumMember(Value = "firstActiveEthernet")]
        FirstActiveEthernet,
        /// <summary>Second active Ethernet.</summary>
        [EnumMember(Value = "secondActiveEthernet")]
        SecondActiveEthernet,
        /// <summary>Third active Ethernet.</summary>
        [EnumMember(Value = "thirdActiveEthernet")]
        ThirdActiveEthernet,
        /// <summary>First Ethernet.</summary>
        [EnumMember(Value = "firstEthernet")]
        FirstEthernet,
        /// <summary>Second Ethernet.</summary>
        [EnumMember(Value = "secondEthernet")]
        SecondEthernet,
        /// <summary>Third Ethernet.</summary>
        [EnumMember(Value = "thirdEthernet")]
        ThirdEthernet,
    }
}
