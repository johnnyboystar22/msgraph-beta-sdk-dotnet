// <auto-generated/>
using Microsoft.Graph.Beta.Groups.Count;
using Microsoft.Graph.Beta.Groups.Delta;
using Microsoft.Graph.Beta.Groups.EvaluateDynamicMembership;
using Microsoft.Graph.Beta.Groups.GetByIds;
using Microsoft.Graph.Beta.Groups.GetUserOwnedObjects;
using Microsoft.Graph.Beta.Groups.Item;
using Microsoft.Graph.Beta.Groups.ValidateProperties;
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
namespace Microsoft.Graph.Beta.Groups {
    /// <summary>
    /// Provides operations to manage the collection of group entities.
    /// </summary>
    public class GroupsRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delta method.</summary>
        public DeltaRequestBuilder Delta { get =>
            new DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the evaluateDynamicMembership method.</summary>
        public EvaluateDynamicMembershipRequestBuilder EvaluateDynamicMembership { get =>
            new EvaluateDynamicMembershipRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getByIds method.</summary>
        public GetByIdsRequestBuilder GetByIds { get =>
            new GetByIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUserOwnedObjects method.</summary>
        public GetUserOwnedObjectsRequestBuilder GetUserOwnedObjects { get =>
            new GetUserOwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the validateProperties method.</summary>
        public ValidatePropertiesRequestBuilder ValidateProperties { get =>
            new ValidatePropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of group entities.</summary>
        /// <param name="position">The unique identifier of group</param>
        /// <returns>A <see cref="GroupItemRequestBuilder"/></returns>
        public GroupItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("group%2Did", position);
            return new GroupItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="GroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="GroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl) {
        }
        /// <summary>
        /// List all the groups available in an organization, excluding dynamic distribution groups. To retrieve dynamic distribution groups, use the Exchange admin center. This operation returns by default only a subset of the more commonly used properties for each group. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation for the group and specify the properties in a $select OData query option. The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-list?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="GroupCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GroupCollectionResponse?> GetAsync(Action<RequestConfiguration<GroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GroupCollectionResponse> GetAsync(Action<RequestConfiguration<GroupsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GroupCollectionResponse>(requestInfo, GroupCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new group as specified in the request body. You can create one of the following groups: This operation returns by default only a subset of the properties for each group. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation and specify the properties in a $select OData query option. Note: To create a team, first create a group then add a team to it, see create team.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-post-groups?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Group"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Group?> PostAsync(Microsoft.Graph.Beta.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Group> PostAsync(Microsoft.Graph.Beta.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Group>(requestInfo, Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all the groups available in an organization, excluding dynamic distribution groups. To retrieve dynamic distribution groups, use the Exchange admin center. This operation returns by default only a subset of the more commonly used properties for each group. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation for the group and specify the properties in a $select OData query option. The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GroupsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new group as specified in the request body. You can create one of the following groups: This operation returns by default only a subset of the properties for each group. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation and specify the properties in a $select OData query option. Note: To create a team, first create a group then add a team to it, see create team.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.Group body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/groups", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="GroupsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GroupsRequestBuilder WithUrl(string rawUrl) {
            return new GroupsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all the groups available in an organization, excluding dynamic distribution groups. To retrieve dynamic distribution groups, use the Exchange admin center. This operation returns by default only a subset of the more commonly used properties for each group. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation for the group and specify the properties in a $select OData query option. The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query.
        /// </summary>
        public class GroupsRequestBuilderGetQueryParameters {
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
        public class GroupsRequestBuilderGetRequestConfiguration : RequestConfiguration<GroupsRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GroupsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
