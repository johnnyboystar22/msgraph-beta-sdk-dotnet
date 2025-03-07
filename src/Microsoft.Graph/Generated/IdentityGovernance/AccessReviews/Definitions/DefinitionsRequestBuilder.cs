// <auto-generated/>
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Count;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.FilterByCurrentUserWithOn;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item;
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
namespace Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions
{
    /// <summary>
    /// Provides operations to manage the definitions property of the microsoft.graph.accessReviewSet entity.
    /// </summary>
    public class DefinitionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the definitions property of the microsoft.graph.accessReviewSet entity.</summary>
        /// <param name="position">The unique identifier of accessReviewScheduleDefinition</param>
        /// <returns>A <see cref="Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.AccessReviewScheduleDefinitionItemRequestBuilder"/></returns>
        public Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.AccessReviewScheduleDefinitionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("accessReviewScheduleDefinition%2Did", position);
                return new Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.AccessReviewScheduleDefinitionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefinitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/accessReviews/definitions{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefinitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/accessReviews/definitions{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the filterByCurrentUser method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder"/></returns>
        /// <param name="on">Usage: on=&apos;{on}&apos;</param>
        public Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder FilterByCurrentUserWithOn(string on)
        {
            if(string.IsNullOrEmpty(on)) throw new ArgumentNullException(nameof(on));
            return new Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder(PathParameters, RequestAdapter, on);
        }
        /// <summary>
        /// Retrieve the accessReviewScheduleDefinition objects. A list of zero or more accessReviewScheduleDefinition objects are returned, including all of their nested properties, for each access review series created. This does not include the associated accessReviewInstance objects.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewset-list-definitions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinitionCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinitionCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder.DefinitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinitionCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder.DefinitionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinitionCollectionResponse>(requestInfo, Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinitionCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new accessReviewScheduleDefinition object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewset-post-definitions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition?> PostAsync(Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition> PostAsync(Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition>(requestInfo, Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the accessReviewScheduleDefinition objects. A list of zero or more accessReviewScheduleDefinition objects are returned, including all of their nested properties, for each access review series created. This does not include the associated accessReviewInstance objects.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder.DefinitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder.DefinitionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new accessReviewScheduleDefinition object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.AccessReviewScheduleDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the accessReviewScheduleDefinition objects. A list of zero or more accessReviewScheduleDefinition objects are returned, including all of their nested properties, for each access review series created. This does not include the associated accessReviewInstance objects.
        /// </summary>
        public class DefinitionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DefinitionsRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.DefinitionsRequestBuilder.DefinitionsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DefinitionsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
