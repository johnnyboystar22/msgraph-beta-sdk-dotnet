// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Monitoring.AlertRecords.MicrosoftGraphDeviceManagementGetPortalNotifications
{
    [Obsolete("This class is obsolete. Use GetPortalNotificationsGetResponse instead.")]
    #pragma warning disable CS1591
    public class GetPortalNotificationsResponse : Microsoft.Graph.Beta.Monitoring.AlertRecords.MicrosoftGraphDeviceManagementGetPortalNotifications.GetPortalNotificationsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Monitoring.AlertRecords.MicrosoftGraphDeviceManagementGetPortalNotifications.GetPortalNotificationsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Monitoring.AlertRecords.MicrosoftGraphDeviceManagementGetPortalNotifications.GetPortalNotificationsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Monitoring.AlertRecords.MicrosoftGraphDeviceManagementGetPortalNotifications.GetPortalNotificationsResponse();
        }
    }
}
