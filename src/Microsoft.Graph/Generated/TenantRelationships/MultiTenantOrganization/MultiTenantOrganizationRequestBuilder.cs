// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.JoinRequest;
using Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.Tenants;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization
{
    /// <summary>
    /// Provides operations to manage the multiTenantOrganization property of the microsoft.graph.tenantRelationship entity.
    /// </summary>
    public class MultiTenantOrganizationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the joinRequest property of the microsoft.graph.multiTenantOrganization entity.</summary>
        public Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.JoinRequest.JoinRequestRequestBuilder JoinRequest
        {
            get => new Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.JoinRequest.JoinRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenants property of the microsoft.graph.multiTenantOrganization entity.</summary>
        public Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.Tenants.TenantsRequestBuilder Tenants
        {
            get => new Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.Tenants.TenantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultiTenantOrganizationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/multiTenantOrganization{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultiTenantOrganizationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/multiTenantOrganization{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get properties of the multitenant organization.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/multitenantorganization-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MultiTenantOrganization"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.MultiTenantOrganization?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder.MultiTenantOrganizationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.MultiTenantOrganization> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder.MultiTenantOrganizationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.MultiTenantOrganization>(requestInfo, Microsoft.Graph.Beta.Models.MultiTenantOrganization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a multi-tenant organization.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/multitenantorganization-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MultiTenantOrganization"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.MultiTenantOrganization?> PatchAsync(Microsoft.Graph.Beta.Models.MultiTenantOrganization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.MultiTenantOrganization> PatchAsync(Microsoft.Graph.Beta.Models.MultiTenantOrganization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.MultiTenantOrganization>(requestInfo, Microsoft.Graph.Beta.Models.MultiTenantOrganization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get properties of the multitenant organization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder.MultiTenantOrganizationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder.MultiTenantOrganizationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a multi-tenant organization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.MultiTenantOrganization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.MultiTenantOrganization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get properties of the multitenant organization.
        /// </summary>
        public class MultiTenantOrganizationRequestBuilderGetQueryParameters 
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
        public class MultiTenantOrganizationRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder.MultiTenantOrganizationRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MultiTenantOrganizationRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
