// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem
{
    /// <summary>
    /// Provides operations to manage the authorizationSystem property of the microsoft.graph.permissionsCreepIndexDistribution entity.
    /// </summary>
    public class AuthorizationSystemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthorizationSystemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/permissionsAnalytics/aws/permissionsCreepIndexDistributions/{permissionsCreepIndexDistribution%2Did}/authorizationSystem{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthorizationSystemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/permissionsAnalytics/aws/permissionsCreepIndexDistributions/{permissionsCreepIndexDistribution%2Did}/authorizationSystem{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Represents an authorization system onboarded to Permissions Management.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AuthorizationSystem"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.AuthorizationSystem?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder.AuthorizationSystemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.AuthorizationSystem> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder.AuthorizationSystemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AuthorizationSystem>(requestInfo, Microsoft.Graph.Beta.Models.AuthorizationSystem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Represents an authorization system onboarded to Permissions Management.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder.AuthorizationSystemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder.AuthorizationSystemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Represents an authorization system onboarded to Permissions Management.
        /// </summary>
        public class AuthorizationSystemRequestBuilderGetQueryParameters 
        {
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
        public class AuthorizationSystemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.PermissionsAnalytics.Aws.PermissionsCreepIndexDistributions.Item.AuthorizationSystem.AuthorizationSystemRequestBuilder.AuthorizationSystemRequestBuilderGetQueryParameters>
        {
        }
    }
}
