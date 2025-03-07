// <auto-generated/>
using Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Count;
using Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Item;
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
namespace Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods
{
    /// <summary>
    /// Provides operations to manage the temporaryAccessPassMethods property of the microsoft.graph.authentication entity.
    /// </summary>
    public class TemporaryAccessPassMethodsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the temporaryAccessPassMethods property of the microsoft.graph.authentication entity.</summary>
        /// <param name="position">The unique identifier of temporaryAccessPassAuthenticationMethod</param>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Item.TemporaryAccessPassAuthenticationMethodItemRequestBuilder"/></returns>
        public Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Item.TemporaryAccessPassAuthenticationMethodItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("temporaryAccessPassAuthenticationMethod%2Did", position);
                return new Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.Item.TemporaryAccessPassAuthenticationMethodItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TemporaryAccessPassMethodsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/authentication/temporaryAccessPassMethods{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TemporaryAccessPassMethodsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/authentication/temporaryAccessPassMethods{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethodCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethodCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder.TemporaryAccessPassMethodsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethodCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder.TemporaryAccessPassMethodsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethodCollectionResponse>(requestInfo, Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethodCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to temporaryAccessPassMethods for me
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod?> PostAsync(Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod> PostAsync(Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod>(requestInfo, Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder.TemporaryAccessPassMethodsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder.TemporaryAccessPassMethodsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to temporaryAccessPassMethods for me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.
        /// </summary>
        public class TemporaryAccessPassMethodsRequestBuilderGetQueryParameters 
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
        public class TemporaryAccessPassMethodsRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder.TemporaryAccessPassMethodsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TemporaryAccessPassMethodsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
