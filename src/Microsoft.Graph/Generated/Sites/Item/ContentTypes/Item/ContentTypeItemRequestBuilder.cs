// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.AssociateWithHubSites;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.Base;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.BaseTypes;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.ColumnLinks;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.ColumnPositions;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.Columns;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.CopyToDefaultContentLocation;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.IsPublished;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.Publish;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item.Unpublish;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Sites.Item.ContentTypes.Item {
    /// <summary>
    /// Provides operations to manage the contentTypes property of the microsoft.graph.site entity.
    /// </summary>
    public class ContentTypeItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to call the associateWithHubSites method.</summary>
        public AssociateWithHubSitesRequestBuilder AssociateWithHubSites
        {
            get => new AssociateWithHubSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the base property of the microsoft.graph.contentType entity.</summary>
        public BaseRequestBuilderEscaped Base
        {
            get => new BaseRequestBuilderEscaped(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the baseTypes property of the microsoft.graph.contentType entity.</summary>
        public BaseTypesRequestBuilder BaseTypes
        {
            get => new BaseTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columnLinks property of the microsoft.graph.contentType entity.</summary>
        public ColumnLinksRequestBuilder ColumnLinks
        {
            get => new ColumnLinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columnPositions property of the microsoft.graph.contentType entity.</summary>
        public ColumnPositionsRequestBuilder ColumnPositions
        {
            get => new ColumnPositionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.contentType entity.</summary>
        public ColumnsRequestBuilder Columns
        {
            get => new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the copyToDefaultContentLocation method.</summary>
        public CopyToDefaultContentLocationRequestBuilder CopyToDefaultContentLocation
        {
            get => new CopyToDefaultContentLocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the isPublished method.</summary>
        public IsPublishedRequestBuilder IsPublished
        {
            get => new IsPublishedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the publish method.</summary>
        public PublishRequestBuilder Publish
        {
            get => new PublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unpublish method.</summary>
        public UnpublishRequestBuilder Unpublish
        {
            get => new UnpublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ContentTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/contentTypes/{contentType%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ContentTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/contentTypes/{contentType%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Remove a [content type][contentType] from a [list][] or a [site][].
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the metadata for a [content type][contentType] in a [site][] or a [list][].
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="ContentType"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ContentType?> GetAsync(Action<RequestConfiguration<ContentTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ContentType> GetAsync(Action<RequestConfiguration<ContentTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ContentType>(requestInfo, ContentType.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update contentType
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="ContentType"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ContentType?> PatchAsync(ContentType body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ContentType> PatchAsync(ContentType body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ContentType>(requestInfo, ContentType.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove a [content type][contentType] from a [list][] or a [site][].
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the metadata for a [content type][contentType] in a [site][] or a [list][].
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ContentTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ContentTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update contentType
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ContentType body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ContentType body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ContentTypeItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContentTypeItemRequestBuilder WithUrl(string rawUrl)
        {
            return new ContentTypeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ContentTypeItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Retrieve the metadata for a [content type][contentType] in a [site][] or a [list][].
        /// </summary>
        public class ContentTypeItemRequestBuilderGetQueryParameters 
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
        public class ContentTypeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<ContentTypeItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ContentTypeItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
