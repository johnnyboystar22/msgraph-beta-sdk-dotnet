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
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.Oauth2PermissionGrants.Item {
    /// <summary>
    /// Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.servicePrincipal entity.
    /// </summary>
    public class OAuth2PermissionGrantItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="OAuth2PermissionGrantItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OAuth2PermissionGrantItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/oauth2PermissionGrants/{oAuth2PermissionGrant%2Did}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="OAuth2PermissionGrantItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OAuth2PermissionGrantItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/oauth2PermissionGrants/{oAuth2PermissionGrant%2Did}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="OAuth2PermissionGrant"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OAuth2PermissionGrant?> GetAsync(Action<RequestConfiguration<OAuth2PermissionGrantItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OAuth2PermissionGrant> GetAsync(Action<RequestConfiguration<OAuth2PermissionGrantItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OAuth2PermissionGrant>(requestInfo, OAuth2PermissionGrant.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OAuth2PermissionGrantItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OAuth2PermissionGrantItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="OAuth2PermissionGrantItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OAuth2PermissionGrantItemRequestBuilder WithUrl(string rawUrl) {
            return new OAuth2PermissionGrantItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
        /// </summary>
        public class OAuth2PermissionGrantItemRequestBuilderGetQueryParameters {
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
        public class OAuth2PermissionGrantItemRequestBuilderGetRequestConfiguration : RequestConfiguration<OAuth2PermissionGrantItemRequestBuilderGetQueryParameters> {
        }
    }
}
