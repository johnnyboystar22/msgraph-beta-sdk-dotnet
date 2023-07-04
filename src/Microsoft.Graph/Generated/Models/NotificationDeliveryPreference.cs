using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum NotificationDeliveryPreference {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "deliverImmedietly")]
        DeliverImmedietly,
        [EnumMember(Value = "deliverAfterCampaignEnd")]
        DeliverAfterCampaignEnd,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
