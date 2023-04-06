using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the state of Zebra FOTA deployment.</summary>
    public enum ZebraFotaDeploymentState {
        /// <summary>Deployment is created but Zebra has not confirmed its creation.</summary>
        [EnumMember(Value = "pendingCreation")]
        PendingCreation,
        /// <summary>Deployment was not successfully created with Zebra.</summary>
        [EnumMember(Value = "createFailed")]
        CreateFailed,
        /// <summary>Deployment has been created but has not been deployed yet.</summary>
        [EnumMember(Value = "created")]
        Created,
        /// <summary>Deployment has started but not completed.</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Deployment has completed or end date has passed.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Admin has requested to cancel a deployment but Zebra has not confirmed cancellation.</summary>
        [EnumMember(Value = "pendingCancel")]
        PendingCancel,
        /// <summary>Deployment has been successfully canceled by Zebra.</summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>Unknown future enum value.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
