using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.Security.Alerts;
using Microsoft.Graph.Beta.Security.Alerts_v2;
using Microsoft.Graph.Beta.Security.AttackSimulation;
using Microsoft.Graph.Beta.Security.Cases;
using Microsoft.Graph.Beta.Security.CloudAppSecurityProfiles;
using Microsoft.Graph.Beta.Security.DomainSecurityProfiles;
using Microsoft.Graph.Beta.Security.FileSecurityProfiles;
using Microsoft.Graph.Beta.Security.HostSecurityProfiles;
using Microsoft.Graph.Beta.Security.Incidents;
using Microsoft.Graph.Beta.Security.InformationProtection;
using Microsoft.Graph.Beta.Security.IpSecurityProfiles;
using Microsoft.Graph.Beta.Security.Labels;
using Microsoft.Graph.Beta.Security.ProviderTenantSettings;
using Microsoft.Graph.Beta.Security.SecureScoreControlProfiles;
using Microsoft.Graph.Beta.Security.SecureScores;
using Microsoft.Graph.Beta.Security.SecurityActions;
using Microsoft.Graph.Beta.Security.SecurityRunHuntingQuery;
using Microsoft.Graph.Beta.Security.SubjectRightsRequests;
using Microsoft.Graph.Beta.Security.ThreatIntelligence;
using Microsoft.Graph.Beta.Security.ThreatSubmission;
using Microsoft.Graph.Beta.Security.TiIndicators;
using Microsoft.Graph.Beta.Security.TriggerTypes;
using Microsoft.Graph.Beta.Security.Triggers;
using Microsoft.Graph.Beta.Security.UserSecurityProfiles;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Security {
    /// <summary>
    /// Provides operations to manage the security singleton.
    /// </summary>
    public class SecurityRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the alerts property of the microsoft.graph.security entity.</summary>
        public AlertsRequestBuilder Alerts { get =>
            new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the alerts_v2 property of the microsoft.graph.security entity.</summary>
        public Alerts_v2RequestBuilder Alerts_v2 { get =>
            new Alerts_v2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
        public AttackSimulationRequestBuilder AttackSimulation { get =>
            new AttackSimulationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cases property of the microsoft.graph.security entity.</summary>
        public CasesRequestBuilder Cases { get =>
            new CasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudAppSecurityProfiles property of the microsoft.graph.security entity.</summary>
        public CloudAppSecurityProfilesRequestBuilder CloudAppSecurityProfiles { get =>
            new CloudAppSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the domainSecurityProfiles property of the microsoft.graph.security entity.</summary>
        public DomainSecurityProfilesRequestBuilder DomainSecurityProfiles { get =>
            new DomainSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the fileSecurityProfiles property of the microsoft.graph.security entity.</summary>
        public FileSecurityProfilesRequestBuilder FileSecurityProfiles { get =>
            new FileSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostSecurityProfiles property of the microsoft.graph.security entity.</summary>
        public HostSecurityProfilesRequestBuilder HostSecurityProfiles { get =>
            new HostSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the incidents property of the microsoft.graph.security entity.</summary>
        public IncidentsRequestBuilder Incidents { get =>
            new IncidentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the informationProtection property of the microsoft.graph.security entity.</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ipSecurityProfiles property of the microsoft.graph.security entity.</summary>
        public IpSecurityProfilesRequestBuilder IpSecurityProfiles { get =>
            new IpSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the labels property of the microsoft.graph.security entity.</summary>
        public LabelsRequestBuilder Labels { get =>
            new LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the providerTenantSettings property of the microsoft.graph.security entity.</summary>
        public ProviderTenantSettingsRequestBuilder ProviderTenantSettings { get =>
            new ProviderTenantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the secureScoreControlProfiles property of the microsoft.graph.security entity.</summary>
        public SecureScoreControlProfilesRequestBuilder SecureScoreControlProfiles { get =>
            new SecureScoreControlProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the secureScores property of the microsoft.graph.security entity.</summary>
        public SecureScoresRequestBuilder SecureScores { get =>
            new SecureScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the securityActions property of the microsoft.graph.security entity.</summary>
        public SecurityActionsRequestBuilder SecurityActions { get =>
            new SecurityActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the runHuntingQuery method.</summary>
        public SecurityRunHuntingQueryRequestBuilder SecurityRunHuntingQuery { get =>
            new SecurityRunHuntingQueryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subjectRightsRequests property of the microsoft.graph.security entity.</summary>
        public SubjectRightsRequestsRequestBuilder SubjectRightsRequests { get =>
            new SubjectRightsRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the threatIntelligence property of the microsoft.graph.security entity.</summary>
        public ThreatIntelligenceRequestBuilder ThreatIntelligence { get =>
            new ThreatIntelligenceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the threatSubmission property of the microsoft.graph.security entity.</summary>
        public ThreatSubmissionRequestBuilder ThreatSubmission { get =>
            new ThreatSubmissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tiIndicators property of the microsoft.graph.security entity.</summary>
        public TiIndicatorsRequestBuilder TiIndicators { get =>
            new TiIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the triggers property of the microsoft.graph.security entity.</summary>
        public TriggersRequestBuilder Triggers { get =>
            new TriggersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the triggerTypes property of the microsoft.graph.security entity.</summary>
        public TriggerTypesRequestBuilder TriggerTypes { get =>
            new TriggerTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userSecurityProfiles property of the microsoft.graph.security entity.</summary>
        public UserSecurityProfilesRequestBuilder UserSecurityProfiles { get =>
            new UserSecurityProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SecurityRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SecurityRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.Security?> GetAsync(Action<SecurityRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.Security> GetAsync(Action<SecurityRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.Security>(requestInfo, Microsoft.Graph.Beta.Models.Security.Security.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update security
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.Security?> PatchAsync(Microsoft.Graph.Beta.Models.Security.Security body, Action<SecurityRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.Security> PatchAsync(Microsoft.Graph.Beta.Models.Security.Security body, Action<SecurityRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.Security>(requestInfo, Microsoft.Graph.Beta.Models.Security.Security.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get security
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SecurityRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SecurityRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SecurityRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update security
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.Security body, Action<SecurityRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.Security body, Action<SecurityRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SecurityRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get security
        /// </summary>
        public class SecurityRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SecurityRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SecurityRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SecurityRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new securityRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SecurityRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SecurityRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new securityRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public SecurityRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
