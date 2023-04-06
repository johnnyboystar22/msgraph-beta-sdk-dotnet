using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConditionalAccessRule {
        [EnumMember(Value = "allApps")]
        AllApps,
        [EnumMember(Value = "firstPartyApps")]
        FirstPartyApps,
        [EnumMember(Value = "office365")]
        Office365,
        [EnumMember(Value = "appId")]
        AppId,
        [EnumMember(Value = "acr")]
        Acr,
        [EnumMember(Value = "appFilter")]
        AppFilter,
        [EnumMember(Value = "allUsers")]
        AllUsers,
        [EnumMember(Value = "guest")]
        Guest,
        [EnumMember(Value = "groupId")]
        GroupId,
        [EnumMember(Value = "roleId")]
        RoleId,
        [EnumMember(Value = "userId")]
        UserId,
        [EnumMember(Value = "allDevicePlatforms")]
        AllDevicePlatforms,
        [EnumMember(Value = "devicePlatform")]
        DevicePlatform,
        [EnumMember(Value = "allLocations")]
        AllLocations,
        [EnumMember(Value = "insideCorpnet")]
        InsideCorpnet,
        [EnumMember(Value = "allTrustedLocations")]
        AllTrustedLocations,
        [EnumMember(Value = "locationId")]
        LocationId,
        [EnumMember(Value = "allDevices")]
        AllDevices,
        [EnumMember(Value = "deviceFilter")]
        DeviceFilter,
        [EnumMember(Value = "deviceState")]
        DeviceState,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "deviceFilterIncludeRuleNotMatched")]
        DeviceFilterIncludeRuleNotMatched,
        [EnumMember(Value = "allDeviceStates")]
        AllDeviceStates,
        [EnumMember(Value = "anonymizedIPAddress")]
        AnonymizedIPAddress,
        [EnumMember(Value = "unfamiliarFeatures")]
        UnfamiliarFeatures,
        [EnumMember(Value = "nationStateIPAddress")]
        NationStateIPAddress,
        [EnumMember(Value = "realTimeThreatIntelligence")]
        RealTimeThreatIntelligence,
        [EnumMember(Value = "internalGuest")]
        InternalGuest,
        [EnumMember(Value = "b2bCollaborationGuest")]
        B2bCollaborationGuest,
        [EnumMember(Value = "b2bCollaborationMember")]
        B2bCollaborationMember,
        [EnumMember(Value = "b2bDirectConnectUser")]
        B2bDirectConnectUser,
        [EnumMember(Value = "otherExternalUser")]
        OtherExternalUser,
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        [EnumMember(Value = "microsoftAdminPortals")]
        MicrosoftAdminPortals,
    }
}
