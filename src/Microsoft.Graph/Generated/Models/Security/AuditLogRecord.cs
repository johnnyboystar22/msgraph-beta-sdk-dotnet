// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AuditLogRecord : Microsoft.Graph.Beta.Models.Entity, IParsable {
        /// <summary>The administrative units tagged to an audit log record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdministrativeUnits {
            get { return BackingStore?.Get<List<string>?>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#nullable restore
#else
        public List<string> AdministrativeUnits {
            get { return BackingStore?.Get<List<string>>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#endif
        /// <summary>A JSON object that contains the actual audit log data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.AuditData? AuditData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AuditData?>("auditData"); }
            set { BackingStore?.Set("auditData", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.AuditData AuditData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AuditData>("auditData"); }
            set { BackingStore?.Set("auditData", value); }
        }
#endif
        /// <summary>The type of operation indicated by the record. The possible values are: exchangeAdmin, exchangeItem, exchangeItemGroup, sharePoint, syntheticProbe, sharePointFileOperation, oneDrive, azureActiveDirectory, azureActiveDirectoryAccountLogon, dataCenterSecurityCmdlet, complianceDLPSharePoint, sway, complianceDLPExchange, sharePointSharingOperation, azureActiveDirectoryStsLogon, skypeForBusinessPSTNUsage, skypeForBusinessUsersBlocked, securityComplianceCenterEOPCmdlet, exchangeAggregatedOperation, powerBIAudit, crm, yammer, skypeForBusinessCmdlets, discovery, microsoftTeams, threatIntelligence, mailSubmission, microsoftFlow, aeD, microsoftStream, complianceDLPSharePointClassification, threatFinder, project, sharePointListOperation, sharePointCommentOperation, dataGovernance, kaizala, securityComplianceAlerts, threatIntelligenceUrl, securityComplianceInsights, mipLabel, workplaceAnalytics, powerAppsApp, powerAppsPlan, threatIntelligenceAtpContent, labelContentExplorer, teamsHealthcare, exchangeItemAggregated, hygieneEvent, dataInsightsRestApiAudit, informationBarrierPolicyApplication, sharePointListItemOperation, sharePointContentTypeOperation, sharePointFieldOperation, microsoftTeamsAdmin, hrSignal, microsoftTeamsDevice, microsoftTeamsAnalytics, informationWorkerProtection, campaign, dlpEndpoint, airInvestigation, quarantine, microsoftForms, applicationAudit, complianceSupervisionExchange, customerKeyServiceEncryption, officeNative, mipAutoLabelSharePointItem, mipAutoLabelSharePointPolicyLocation, microsoftTeamsShifts, secureScore, mipAutoLabelExchangeItem, cortanaBriefing, search, wdatpAlerts, powerPlatformAdminDlp, powerPlatformAdminEnvironment, mdatpAudit, sensitivityLabelPolicyMatch, sensitivityLabelAction, sensitivityLabeledFileAction, attackSim, airManualInvestigation, securityComplianceRBAC, userTraining, airAdminActionInvestigation, mstic, physicalBadgingSignal, teamsEasyApprovals, aipDiscover, aipSensitivityLabelAction, aipProtectionAction, aipFileDeleted, aipHeartBeat, mcasAlerts, onPremisesFileShareScannerDlp, onPremisesSharePointScannerDlp, exchangeSearch, sharePointSearch, privacyDataMinimization, labelAnalyticsAggregate, myAnalyticsSettings, securityComplianceUserChange, complianceDLPExchangeClassification, complianceDLPEndpoint, mipExactDataMatch, msdeResponseActions, msdeGeneralSettings, msdeIndicatorsSettings, ms365DCustomDetection, msdeRolesSettings, mapgAlerts, mapgPolicy, mapgRemediation, privacyRemediationAction, privacyDigestEmail, mipAutoLabelSimulationProgress, mipAutoLabelSimulationCompletion, mipAutoLabelProgressFeedback, dlpSensitiveInformationType, mipAutoLabelSimulationStatistics, largeContentMetadata, microsoft365Group, cdpMlInferencingResult, filteringMailMetadata, cdpClassificationMailItem, cdpClassificationDocument, officeScriptsRunAction, filteringPostMailDeliveryAction, cdpUnifiedFeedback, tenantAllowBlockList, consumptionResource, healthcareSignal, dlpImportResult, cdpCompliancePolicyExecution, multiStageDisposition, privacyDataMatch, filteringDocMetadata, filteringEmailFeatures, powerBIDlp, filteringUrlInfo, filteringAttachmentInfo, coreReportingSettings, complianceConnector, powerPlatformLockboxResourceAccessRequest, powerPlatformLockboxResourceCommand, cdpPredictiveCodingLabel, cdpCompliancePolicyUserFeedback, webpageActivityEndpoint, omePortal, cmImprovementActionChange, filteringUrlClick, mipLabelAnalyticsAuditRecord, filteringEntityEvent, filteringRuleHits, filteringMailSubmission, labelExplorer, microsoftManagedServicePlatform, powerPlatformServiceActivity, scorePlatformGenericAuditRecord, filteringTimeTravelDocMetadata, alert, alertStatus, alertIncident, incidentStatus, case, caseInvestigation, recordsManagement, privacyRemediation, dataShareOperation, cdpDlpSensitive, ehrConnector, filteringMailGradingResult, publicFolder, privacyTenantAuditHistoryRecord, aipScannerDiscoverEvent, eduDataLakeDownloadOperation, m365ComplianceConnector, microsoftGraphDataConnectOperation, microsoftPurview, filteringEmailContentFeatures, powerPagesSite, powerAppsResource, plannerPlan, plannerCopyPlan, plannerTask, plannerRoster, plannerPlanList, plannerTaskList, plannerTenantSettings, projectForTheWebProject, projectForTheWebTask, projectForTheWebRoadmap, projectForTheWebRoadmapItem, projectForTheWebProjectSettings, projectForTheWebRoadmapSettings, quarantineMetadata, microsoftTodoAudit, timeTravelFilteringDocMetadata, teamsQuarantineMetadata, sharePointAppPermissionOperation, microsoftTeamsSensitivityLabelAction, filteringTeamsMetadata, filteringTeamsUrlInfo, filteringTeamsPostDeliveryAction, mdcAssessments, mdcRegulatoryComplianceStandards, mdcRegulatoryComplianceControls, mdcRegulatoryComplianceAssessments, mdcSecurityConnectors, mdaDataSecuritySignal, vivaGoals, filteringRuntimeInfo, attackSimAdmin, microsoftGraphDataConnectConsent, filteringAtpDetonationInfo, privacyPortal, managedTenants, unifiedSimulationMatchedItem, unifiedSimulationSummary, updateQuarantineMetadata, ms365DSuppressionRule, purviewDataMapOperation, filteringUrlPostClickAction, irmUserDefinedDetectionSignal, teamsUpdates, plannerRosterSensitivityLabel, ms365DIncident, filteringDelistingMetadata, complianceDLPSharePointClassificationExtended, microsoftDefenderForIdentityAudit, supervisoryReviewDayXInsight, defenderExpertsforXDRAdmin, cdpEdgeBlockedMessage, hostedRpa, cdpContentExplorerAggregateRecord, cdpHygieneAttachmentInfo, cdpHygieneSummary, cdpPostMailDeliveryAction, cdpEmailFeatures, cdpHygieneUrlInfo, cdpUrlClick, cdpPackageManagerHygieneEvent, filteringDocScan, timeTravelFilteringDocScan, mapgOnboard, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.AuditLogRecordType? AuditLogRecordType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AuditLogRecordType?>("auditLogRecordType"); }
            set { BackingStore?.Set("auditLogRecordType", value); }
        }
        /// <summary>The IP address of the device used when the activity was logged. The IP address is displayed in either an IPv4 or IPv6 address format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientIp {
            get { return BackingStore?.Get<string?>("clientIp"); }
            set { BackingStore?.Set("clientIp", value); }
        }
#nullable restore
#else
        public string ClientIp {
            get { return BackingStore?.Get<string>("clientIp"); }
            set { BackingStore?.Set("clientIp", value); }
        }
#endif
        /// <summary>The date and time in UTC when the user performed the activity.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>For Exchange admin audit logging, the name of the object modified by the cmdlet. For SharePoint activity, the full URL path name of the file or folder accessed by a user. For Microsoft Entra activity, the name of the user account that was modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId {
            get { return BackingStore?.Get<string?>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#nullable restore
#else
        public string ObjectId {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#endif
        /// <summary>The name of the user or admin activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operation {
            get { return BackingStore?.Get<string?>("operation"); }
            set { BackingStore?.Set("operation", value); }
        }
#nullable restore
#else
        public string Operation {
            get { return BackingStore?.Get<string>("operation"); }
            set { BackingStore?.Set("operation", value); }
        }
#endif
        /// <summary>The GUID for your organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId {
            get { return BackingStore?.Get<string?>("organizationId"); }
            set { BackingStore?.Set("organizationId", value); }
        }
#nullable restore
#else
        public string OrganizationId {
            get { return BackingStore?.Get<string>("organizationId"); }
            set { BackingStore?.Set("organizationId", value); }
        }
#endif
        /// <summary>The Microsoft 365 service where the activity occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service {
            get { return BackingStore?.Get<string?>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#nullable restore
#else
        public string Service {
            get { return BackingStore?.Get<string>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#endif
        /// <summary>The user who performed the action (specified in the Operation property) that resulted in the record being logged. Audit records for activity performed by system accounts (such as SHAREPOINT/system or NT AUTHORITY/SYSTEM) are also included in the audit log. Another common value for the UserId property is app@sharepoint. It indicates that the &apos;user&apos; who performed the activity was an application with the necessary permissions in SharePoint to perform organization-wide actions (such as searching a SharePoint site or OneDrive account) on behalf of a user, admin, or service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>UPN of the user who performed the action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The type of user that performed the operation. The possible values are: regular, reserved, admin, dcAdmin, system, application, servicePrincipal, customPolicy, systemPolicy, partnerTechnician, guest, unknownFutureValue.</summary>
        public AuditLogUserType? UserType {
            get { return BackingStore?.Get<AuditLogUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuditLogRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuditLogRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"auditData", n => { AuditData = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.AuditData>(Microsoft.Graph.Beta.Models.Security.AuditData.CreateFromDiscriminatorValue); } },
                {"auditLogRecordType", n => { AuditLogRecordType = n.GetEnumValue<AuditLogRecordType>(); } },
                {"clientIp", n => { ClientIp = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"operation", n => { Operation = n.GetStringValue(); } },
                {"organizationId", n => { OrganizationId = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<AuditLogUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("administrativeUnits", AdministrativeUnits);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.AuditData>("auditData", AuditData);
            writer.WriteEnumValue<AuditLogRecordType>("auditLogRecordType", AuditLogRecordType);
            writer.WriteStringValue("clientIp", ClientIp);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("operation", Operation);
            writer.WriteStringValue("organizationId", OrganizationId);
            writer.WriteStringValue("service", Service);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<AuditLogUserType>("userType", UserType);
        }
    }
}
