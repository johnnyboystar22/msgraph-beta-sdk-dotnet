// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Users.Item.IsManagedAppUserBlocked
{
    [Obsolete("This class is obsolete. Use IsManagedAppUserBlockedGetResponse instead.")]
    #pragma warning disable CS1591
    public class IsManagedAppUserBlockedResponse : Microsoft.Graph.Beta.Users.Item.IsManagedAppUserBlocked.IsManagedAppUserBlockedGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Users.Item.IsManagedAppUserBlocked.IsManagedAppUserBlockedResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Users.Item.IsManagedAppUserBlocked.IsManagedAppUserBlockedResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Users.Item.IsManagedAppUserBlocked.IsManagedAppUserBlockedResponse();
        }
    }
}
