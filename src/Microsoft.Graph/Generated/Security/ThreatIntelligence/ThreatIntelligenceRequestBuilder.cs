// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.ArticleIndicators;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Articles;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostComponents;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostCookies;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostPairs;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostPorts;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostSslCertificates;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostTrackers;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.IntelProfiles;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.IntelligenceProfileIndicators;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.PassiveDnsRecords;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.SslCertificates;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Subdomains;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Vulnerabilities;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.WhoisHistoryRecords;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.WhoisRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Security.ThreatIntelligence {
    /// <summary>
    /// Provides operations to manage the threatIntelligence property of the microsoft.graph.security entity.
    /// </summary>
    public class ThreatIntelligenceRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the articleIndicators property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public ArticleIndicatorsRequestBuilder ArticleIndicators { get =>
            new ArticleIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the articles property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public ArticlesRequestBuilder Articles { get =>
            new ArticlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostComponents property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostComponentsRequestBuilder HostComponents { get =>
            new HostComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostCookies property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostCookiesRequestBuilder HostCookies { get =>
            new HostCookiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostPairs property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostPairsRequestBuilder HostPairs { get =>
            new HostPairsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostPorts property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostPortsRequestBuilder HostPorts { get =>
            new HostPortsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hosts property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostsRequestBuilder Hosts { get =>
            new HostsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostSslCertificates property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostSslCertificatesRequestBuilder HostSslCertificates { get =>
            new HostSslCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostTrackers property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostTrackersRequestBuilder HostTrackers { get =>
            new HostTrackersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intelligenceProfileIndicators property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public IntelligenceProfileIndicatorsRequestBuilder IntelligenceProfileIndicators { get =>
            new IntelligenceProfileIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intelProfiles property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public IntelProfilesRequestBuilder IntelProfiles { get =>
            new IntelProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passiveDnsRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public PassiveDnsRecordsRequestBuilder PassiveDnsRecords { get =>
            new PassiveDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sslCertificates property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public SslCertificatesRequestBuilder SslCertificates { get =>
            new SslCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subdomains property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public SubdomainsRequestBuilder Subdomains { get =>
            new SubdomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the vulnerabilities property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public VulnerabilitiesRequestBuilder Vulnerabilities { get =>
            new VulnerabilitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the whoisHistoryRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public WhoisHistoryRecordsRequestBuilder WhoisHistoryRecords { get =>
            new WhoisHistoryRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the whoisRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public WhoisRecordsRequestBuilder WhoisRecords { get =>
            new WhoisRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ThreatIntelligenceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreatIntelligenceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ThreatIntelligenceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreatIntelligenceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property threatIntelligence for security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence?> GetAsync(Action<RequestConfiguration<ThreatIntelligenceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence> GetAsync(Action<RequestConfiguration<ThreatIntelligenceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence>(requestInfo, Microsoft.Graph.Beta.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property threatIntelligence in security
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence?> PatchAsync(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence> PatchAsync(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence>(requestInfo, Microsoft.Graph.Beta.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property threatIntelligence for security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/security/threatIntelligence", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ThreatIntelligenceRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ThreatIntelligenceRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property threatIntelligence in security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/security/threatIntelligence", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ThreatIntelligenceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ThreatIntelligenceRequestBuilder WithUrl(string rawUrl) {
            return new ThreatIntelligenceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ThreatIntelligenceRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        public class ThreatIntelligenceRequestBuilderGetQueryParameters {
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
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ThreatIntelligenceRequestBuilderGetRequestConfiguration : RequestConfiguration<ThreatIntelligenceRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ThreatIntelligenceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
