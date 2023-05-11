// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SecurityRequestBuilder.
    /// </summary>
    public partial class SecurityRequestBuilder : EntityRequestBuilder, ISecurityRequestBuilder
    {

        /// <summary>
        /// Constructs a new SecurityRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISecurityRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISecurityRequest Request(IEnumerable<Option> options)
        {
            return new SecurityRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SubjectRightsRequests.
        /// </summary>
        /// <returns>The <see cref="ISecuritySubjectRightsRequestsCollectionRequestBuilder"/>.</returns>
        public ISecuritySubjectRightsRequestsCollectionRequestBuilder SubjectRightsRequests
        {
            get
            {
                return new SecuritySubjectRightsRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("subjectRightsRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Cases.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.ICasesRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.ICasesRootRequestBuilder Cases
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.CasesRootRequestBuilder(this.AppendSegmentToRequestUrl("cases"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for InformationProtection.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.IInformationProtectionRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.IInformationProtectionRequestBuilder InformationProtection
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.InformationProtectionRequestBuilder(this.AppendSegmentToRequestUrl("informationProtection"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Alerts_v2.
        /// </summary>
        /// <returns>The <see cref="ISecurityAlerts_v2CollectionRequestBuilder"/>.</returns>
        public ISecurityAlerts_v2CollectionRequestBuilder Alerts_v2
        {
            get
            {
                return new SecurityAlerts_v2CollectionRequestBuilder(this.AppendSegmentToRequestUrl("alerts_v2"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Incidents.
        /// </summary>
        /// <returns>The <see cref="ISecurityIncidentsCollectionRequestBuilder"/>.</returns>
        public ISecurityIncidentsCollectionRequestBuilder Incidents
        {
            get
            {
                return new SecurityIncidentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("incidents"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AttackSimulation.
        /// </summary>
        /// <returns>The <see cref="IAttackSimulationRootRequestBuilder"/>.</returns>
        public IAttackSimulationRootRequestBuilder AttackSimulation
        {
            get
            {
                return new AttackSimulationRootRequestBuilder(this.AppendSegmentToRequestUrl("attackSimulation"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Labels.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.ILabelsRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.ILabelsRootRequestBuilder Labels
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.LabelsRootRequestBuilder(this.AppendSegmentToRequestUrl("labels"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Triggers.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.ITriggersRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.ITriggersRootRequestBuilder Triggers
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.TriggersRootRequestBuilder(this.AppendSegmentToRequestUrl("triggers"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TriggerTypes.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.ITriggerTypesRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.ITriggerTypesRootRequestBuilder TriggerTypes
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.TriggerTypesRootRequestBuilder(this.AppendSegmentToRequestUrl("triggerTypes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ThreatSubmission.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.IThreatSubmissionRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.IThreatSubmissionRootRequestBuilder ThreatSubmission
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.ThreatSubmissionRootRequestBuilder(this.AppendSegmentToRequestUrl("threatSubmission"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Alerts.
        /// </summary>
        /// <returns>The <see cref="ISecurityAlertsCollectionRequestBuilder"/>.</returns>
        public ISecurityAlertsCollectionRequestBuilder Alerts
        {
            get
            {
                return new SecurityAlertsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("alerts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CloudAppSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityCloudAppSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityCloudAppSecurityProfilesCollectionRequestBuilder CloudAppSecurityProfiles
        {
            get
            {
                return new SecurityCloudAppSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("cloudAppSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DomainSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityDomainSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityDomainSecurityProfilesCollectionRequestBuilder DomainSecurityProfiles
        {
            get
            {
                return new SecurityDomainSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("domainSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for FileSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityFileSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityFileSecurityProfilesCollectionRequestBuilder FileSecurityProfiles
        {
            get
            {
                return new SecurityFileSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("fileSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for HostSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityHostSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityHostSecurityProfilesCollectionRequestBuilder HostSecurityProfiles
        {
            get
            {
                return new SecurityHostSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("hostSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IpSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityIpSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityIpSecurityProfilesCollectionRequestBuilder IpSecurityProfiles
        {
            get
            {
                return new SecurityIpSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("ipSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ProviderTenantSettings.
        /// </summary>
        /// <returns>The <see cref="ISecurityProviderTenantSettingsCollectionRequestBuilder"/>.</returns>
        public ISecurityProviderTenantSettingsCollectionRequestBuilder ProviderTenantSettings
        {
            get
            {
                return new SecurityProviderTenantSettingsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("providerTenantSettings"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SecureScoreControlProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecureScoreControlProfilesCollectionRequestBuilder"/>.</returns>
        public ISecuritySecureScoreControlProfilesCollectionRequestBuilder SecureScoreControlProfiles
        {
            get
            {
                return new SecuritySecureScoreControlProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("secureScoreControlProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SecureScores.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecureScoresCollectionRequestBuilder"/>.</returns>
        public ISecuritySecureScoresCollectionRequestBuilder SecureScores
        {
            get
            {
                return new SecuritySecureScoresCollectionRequestBuilder(this.AppendSegmentToRequestUrl("secureScores"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SecurityActions.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecurityActionsCollectionRequestBuilder"/>.</returns>
        public ISecuritySecurityActionsCollectionRequestBuilder SecurityActions
        {
            get
            {
                return new SecuritySecurityActionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("securityActions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TiIndicators.
        /// </summary>
        /// <returns>The <see cref="ISecurityTiIndicatorsCollectionRequestBuilder"/>.</returns>
        public ISecurityTiIndicatorsCollectionRequestBuilder TiIndicators
        {
            get
            {
                return new SecurityTiIndicatorsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tiIndicators"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityUserSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityUserSecurityProfilesCollectionRequestBuilder UserSecurityProfiles
        {
            get
            {
                return new SecurityUserSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ThreatIntelligence.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.IThreatIntelligenceRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.IThreatIntelligenceRequestBuilder ThreatIntelligence
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.ThreatIntelligenceRequestBuilder(this.AppendSegmentToRequestUrl("threatIntelligence"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for SecurityRunHuntingQuery.
        /// </summary>
        /// <returns>The <see cref="ISecurityRunHuntingQueryRequestBuilder"/>.</returns>
        public ISecurityRunHuntingQueryRequestBuilder RunHuntingQuery(
            string query = null)
        {
            return new SecurityRunHuntingQueryRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.runHuntingQuery"),
                this.Client,
                query);
        }
    
    }
}
