// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICloudPCRequestBuilder.
    /// </summary>
    public partial interface ICloudPCRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICloudPCRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICloudPCRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for CloudPCChangeUserAccountType.
        /// </summary>
        /// <returns>The <see cref="ICloudPCChangeUserAccountTypeRequestBuilder"/>.</returns>
        ICloudPCChangeUserAccountTypeRequestBuilder ChangeUserAccountType(
            CloudPcUserAccountType? userAccountType = null);

        /// <summary>
        /// Gets the request builder for CloudPCCreateSnapshot.
        /// </summary>
        /// <returns>The <see cref="ICloudPCCreateSnapshotRequestBuilder"/>.</returns>
        ICloudPCCreateSnapshotRequestBuilder CreateSnapshot();

        /// <summary>
        /// Gets the request builder for CloudPCEndGracePeriod.
        /// </summary>
        /// <returns>The <see cref="ICloudPCEndGracePeriodRequestBuilder"/>.</returns>
        ICloudPCEndGracePeriodRequestBuilder EndGracePeriod();

        /// <summary>
        /// Gets the request builder for CloudPCPowerOff.
        /// </summary>
        /// <returns>The <see cref="ICloudPCPowerOffRequestBuilder"/>.</returns>
        ICloudPCPowerOffRequestBuilder PowerOff();

        /// <summary>
        /// Gets the request builder for CloudPCPowerOn.
        /// </summary>
        /// <returns>The <see cref="ICloudPCPowerOnRequestBuilder"/>.</returns>
        ICloudPCPowerOnRequestBuilder PowerOn();

        /// <summary>
        /// Gets the request builder for CloudPCReboot.
        /// </summary>
        /// <returns>The <see cref="ICloudPCRebootRequestBuilder"/>.</returns>
        ICloudPCRebootRequestBuilder Reboot();

        /// <summary>
        /// Gets the request builder for CloudPCRename.
        /// </summary>
        /// <returns>The <see cref="ICloudPCRenameRequestBuilder"/>.</returns>
        ICloudPCRenameRequestBuilder Rename(
            string displayName = null);

        /// <summary>
        /// Gets the request builder for CloudPCReprovision.
        /// </summary>
        /// <returns>The <see cref="ICloudPCReprovisionRequestBuilder"/>.</returns>
        ICloudPCReprovisionRequestBuilder Reprovision(
            CloudPcUserAccountType? userAccountType = null,
            CloudPcOperatingSystem? osVersion = null);

        /// <summary>
        /// Gets the request builder for CloudPCResize.
        /// </summary>
        /// <returns>The <see cref="ICloudPCResizeRequestBuilder"/>.</returns>
        ICloudPCResizeRequestBuilder Resize(
            string targetServicePlanId = null);

        /// <summary>
        /// Gets the request builder for CloudPCRestore.
        /// </summary>
        /// <returns>The <see cref="ICloudPCRestoreRequestBuilder"/>.</returns>
        ICloudPCRestoreRequestBuilder Restore(
            string cloudPcSnapshotId = null);

        /// <summary>
        /// Gets the request builder for CloudPCRetryPartnerAgentInstallation.
        /// </summary>
        /// <returns>The <see cref="ICloudPCRetryPartnerAgentInstallationRequestBuilder"/>.</returns>
        ICloudPCRetryPartnerAgentInstallationRequestBuilder RetryPartnerAgentInstallation();

        /// <summary>
        /// Gets the request builder for CloudPCStart.
        /// </summary>
        /// <returns>The <see cref="ICloudPCStartRequestBuilder"/>.</returns>
        ICloudPCStartRequestBuilder Start();

        /// <summary>
        /// Gets the request builder for CloudPCStop.
        /// </summary>
        /// <returns>The <see cref="ICloudPCStopRequestBuilder"/>.</returns>
        ICloudPCStopRequestBuilder Stop();

        /// <summary>
        /// Gets the request builder for CloudPCTroubleshoot.
        /// </summary>
        /// <returns>The <see cref="ICloudPCTroubleshootRequestBuilder"/>.</returns>
        ICloudPCTroubleshootRequestBuilder Troubleshoot();

        /// <summary>
        /// Gets the request builder for CloudPCGetCloudPcConnectivityHistory.
        /// </summary>
        /// <returns>The <see cref="ICloudPCGetCloudPcConnectivityHistoryRequestBuilder"/>.</returns>
        ICloudPCGetCloudPcConnectivityHistoryRequestBuilder GetCloudPcConnectivityHistory();

        /// <summary>
        /// Gets the request builder for CloudPCGetCloudPcLaunchInfo.
        /// </summary>
        /// <returns>The <see cref="ICloudPCGetCloudPcLaunchInfoRequestBuilder"/>.</returns>
        ICloudPCGetCloudPcLaunchInfoRequestBuilder GetCloudPcLaunchInfo();

        /// <summary>
        /// Gets the request builder for CloudPCGetShiftWorkCloudPcAccessState.
        /// </summary>
        /// <returns>The <see cref="ICloudPCGetShiftWorkCloudPcAccessStateRequestBuilder"/>.</returns>
        ICloudPCGetShiftWorkCloudPcAccessStateRequestBuilder GetShiftWorkCloudPcAccessState();

        /// <summary>
        /// Gets the request builder for CloudPCGetSupportedCloudPcRemoteActions.
        /// </summary>
        /// <returns>The <see cref="ICloudPCGetSupportedCloudPcRemoteActionsRequestBuilder"/>.</returns>
        ICloudPCGetSupportedCloudPcRemoteActionsRequestBuilder GetSupportedCloudPcRemoteActions();
    
    }
}
