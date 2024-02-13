// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Schedule.TimeCards.ClockIn;
using Microsoft.Graph.Beta.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Schedule.TimeCards.Count;
using Microsoft.Graph.Beta.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Schedule.TimeCards.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Schedule.TimeCards {
    /// <summary>
    /// Provides operations to manage the timeCards property of the microsoft.graph.schedule entity.
    /// </summary>
    public class TimeCardsRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the clockIn method.</summary>
        public ClockInRequestBuilder ClockIn { get =>
            new ClockInRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timeCards property of the microsoft.graph.schedule entity.</summary>
        /// <param name="position">The unique identifier of timeCard</param>
        /// <returns>A <see cref="TimeCardItemRequestBuilder"/></returns>
        public TimeCardItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("timeCard%2Did", position);
            return new TimeCardItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="TimeCardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeCardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/schedule/timeCards{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="TimeCardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeCardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/schedule/timeCards{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl) {
        }
        /// <summary>
        /// Retrieve a list of timeCard entries in a schedule.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timecard-list?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="TimeCardCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TimeCardCollectionResponse?> GetAsync(Action<RequestConfiguration<TimeCardsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TimeCardCollectionResponse> GetAsync(Action<RequestConfiguration<TimeCardsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TimeCardCollectionResponse>(requestInfo, TimeCardCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a timeCard instance in a schedule.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timecard-post?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="TimeCard"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TimeCard?> PostAsync(TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TimeCard> PostAsync(TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TimeCard>(requestInfo, TimeCard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of timeCard entries in a schedule.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeCardsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeCardsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a timeCard instance in a schedule.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/schedule/timeCards", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="TimeCardsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TimeCardsRequestBuilder WithUrl(string rawUrl) {
            return new TimeCardsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a list of timeCard entries in a schedule.
        /// </summary>
        public class TimeCardsRequestBuilderGetQueryParameters {
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
        public class TimeCardsRequestBuilderGetRequestConfiguration : RequestConfiguration<TimeCardsRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TimeCardsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
