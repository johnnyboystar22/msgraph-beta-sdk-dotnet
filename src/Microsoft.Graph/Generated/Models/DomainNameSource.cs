using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Domainname source.</summary>
    public enum DomainNameSource {
        /// <summary>Full domain name.</summary>
        [EnumMember(Value = "fullDomainName")]
        FullDomainName,
        /// <summary>net bios domain name.</summary>
        [EnumMember(Value = "netBiosDomainName")]
        NetBiosDomainName,
    }
}
