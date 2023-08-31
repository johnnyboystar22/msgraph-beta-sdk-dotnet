// <auto-generated/>
using Microsoft.Graph.Beta.Groups.Item.AcceptedSenders;
using Microsoft.Graph.Beta.Groups.Item.AddFavorite;
using Microsoft.Graph.Beta.Groups.Item.AppRoleAssignments;
using Microsoft.Graph.Beta.Groups.Item.AssignLicense;
using Microsoft.Graph.Beta.Groups.Item.Calendar;
using Microsoft.Graph.Beta.Groups.Item.CalendarView;
using Microsoft.Graph.Beta.Groups.Item.CheckGrantedPermissionsForApp;
using Microsoft.Graph.Beta.Groups.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.Groups.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.Groups.Item.Conversations;
using Microsoft.Graph.Beta.Groups.Item.CreatedOnBehalfOf;
using Microsoft.Graph.Beta.Groups.Item.Drive;
using Microsoft.Graph.Beta.Groups.Item.Drives;
using Microsoft.Graph.Beta.Groups.Item.Endpoints;
using Microsoft.Graph.Beta.Groups.Item.EvaluateDynamicMembership;
using Microsoft.Graph.Beta.Groups.Item.Events;
using Microsoft.Graph.Beta.Groups.Item.Extensions;
using Microsoft.Graph.Beta.Groups.Item.GetMemberGroups;
using Microsoft.Graph.Beta.Groups.Item.GetMemberObjects;
using Microsoft.Graph.Beta.Groups.Item.GroupLifecyclePolicies;
using Microsoft.Graph.Beta.Groups.Item.MemberOf;
using Microsoft.Graph.Beta.Groups.Item.Members;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors;
using Microsoft.Graph.Beta.Groups.Item.Onenote;
using Microsoft.Graph.Beta.Groups.Item.Owners;
using Microsoft.Graph.Beta.Groups.Item.PermissionGrants;
using Microsoft.Graph.Beta.Groups.Item.Photo;
using Microsoft.Graph.Beta.Groups.Item.Photos;
using Microsoft.Graph.Beta.Groups.Item.Planner;
using Microsoft.Graph.Beta.Groups.Item.RejectedSenders;
using Microsoft.Graph.Beta.Groups.Item.RemoveFavorite;
using Microsoft.Graph.Beta.Groups.Item.Renew;
using Microsoft.Graph.Beta.Groups.Item.ResetUnseenCount;
using Microsoft.Graph.Beta.Groups.Item.Restore;
using Microsoft.Graph.Beta.Groups.Item.RetryServiceProvisioning;
using Microsoft.Graph.Beta.Groups.Item.Settings;
using Microsoft.Graph.Beta.Groups.Item.Sites;
using Microsoft.Graph.Beta.Groups.Item.SubscribeByMail;
using Microsoft.Graph.Beta.Groups.Item.Team;
using Microsoft.Graph.Beta.Groups.Item.Threads;
using Microsoft.Graph.Beta.Groups.Item.TransitiveMemberOf;
using Microsoft.Graph.Beta.Groups.Item.TransitiveMembers;
using Microsoft.Graph.Beta.Groups.Item.UnsubscribeByMail;
using Microsoft.Graph.Beta.Groups.Item.ValidateProperties;
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
namespace Microsoft.Graph.Beta.Groups.Item {
    /// <summary>
    /// Provides operations to manage the collection of group entities.
    /// </summary>
    public class GroupItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the acceptedSenders property of the microsoft.graph.group entity.</summary>
        public AcceptedSendersRequestBuilder AcceptedSenders { get =>
            new AcceptedSendersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the addFavorite method.</summary>
        public AddFavoriteRequestBuilder AddFavorite { get =>
            new AddFavoriteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignments property of the microsoft.graph.group entity.</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignLicense method.</summary>
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendar property of the microsoft.graph.group entity.</summary>
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarView property of the microsoft.graph.group entity.</summary>
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkGrantedPermissionsForApp method.</summary>
        public CheckGrantedPermissionsForAppRequestBuilder CheckGrantedPermissionsForApp { get =>
            new CheckGrantedPermissionsForAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the conversations property of the microsoft.graph.group entity.</summary>
        public ConversationsRequestBuilder Conversations { get =>
            new ConversationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdOnBehalfOf property of the microsoft.graph.group entity.</summary>
        public CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf { get =>
            new CreatedOnBehalfOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.group entity.</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.group entity.</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the endpoints property of the microsoft.graph.group entity.</summary>
        public EndpointsRequestBuilder Endpoints { get =>
            new EndpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the evaluateDynamicMembership method.</summary>
        public EvaluateDynamicMembershipRequestBuilder EvaluateDynamicMembership { get =>
            new EvaluateDynamicMembershipRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the events property of the microsoft.graph.group entity.</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.group entity.</summary>
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupLifecyclePolicies property of the microsoft.graph.group entity.</summary>
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.group entity.</summary>
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the members property of the microsoft.graph.group entity.</summary>
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the membersWithLicenseErrors property of the microsoft.graph.group entity.</summary>
        public MembersWithLicenseErrorsRequestBuilder MembersWithLicenseErrors { get =>
            new MembersWithLicenseErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.group entity.</summary>
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the owners property of the microsoft.graph.group entity.</summary>
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionGrants property of the microsoft.graph.group entity.</summary>
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photo property of the microsoft.graph.group entity.</summary>
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photos property of the microsoft.graph.group entity.</summary>
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the planner property of the microsoft.graph.group entity.</summary>
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the rejectedSenders property of the microsoft.graph.group entity.</summary>
        public RejectedSendersRequestBuilder RejectedSenders { get =>
            new RejectedSendersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeFavorite method.</summary>
        public RemoveFavoriteRequestBuilder RemoveFavorite { get =>
            new RemoveFavoriteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the renew method.</summary>
        public RenewRequestBuilder Renew { get =>
            new RenewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetUnseenCount method.</summary>
        public ResetUnseenCountRequestBuilder ResetUnseenCount { get =>
            new ResetUnseenCountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retryServiceProvisioning method.</summary>
        public RetryServiceProvisioningRequestBuilder RetryServiceProvisioning { get =>
            new RetryServiceProvisioningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.group entity.</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.group entity.</summary>
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the subscribeByMail method.</summary>
        public SubscribeByMailRequestBuilder SubscribeByMail { get =>
            new SubscribeByMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the team property of the microsoft.graph.group entity.</summary>
        public TeamRequestBuilder Team { get =>
            new TeamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the threads property of the microsoft.graph.group entity.</summary>
        public ThreadsRequestBuilder Threads { get =>
            new ThreadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.group entity.</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMembers property of the microsoft.graph.group entity.</summary>
        public TransitiveMembersRequestBuilder TransitiveMembers { get =>
            new TransitiveMembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unsubscribeByMail method.</summary>
        public UnsubscribeByMailRequestBuilder UnsubscribeByMail { get =>
            new UnsubscribeByMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the validateProperties method.</summary>
        public ValidatePropertiesRequestBuilder ValidateProperties { get =>
            new ValidatePropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Deletes a group. When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days. After that time, they are permanently deleted. This isn&apos;t applicable to Security groups and Distribution groups which are permanently deleted immediately. To learn more, see deletedItems.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<GroupItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<GroupItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are not returned by default, specify them in a $select OData query option. The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query. Because the group resource supports extensions, you can also use the GET operation to get custom properties and extension data in a group instance.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Group?> GetAsync(Action<GroupItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Group> GetAsync(Action<GroupItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Group>(requestInfo, Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the properties of a group object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Group?> PatchAsync(Microsoft.Graph.Beta.Models.Group body, Action<GroupItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Group> PatchAsync(Microsoft.Graph.Beta.Models.Group body, Action<GroupItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Group>(requestInfo, Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Deletes a group. When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days. After that time, they are permanently deleted. This isn&apos;t applicable to Security groups and Distribution groups which are permanently deleted immediately. To learn more, see deletedItems.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<GroupItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<GroupItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new GroupItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are not returned by default, specify them in a $select OData query option. The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query. Because the group resource supports extensions, you can also use the GET operation to get custom properties and extension data in a group instance.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GroupItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GroupItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GroupItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a group object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Group body, Action<GroupItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Group body, Action<GroupItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new GroupItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GroupItemRequestBuilder WithUrl(string rawUrl) {
            return new GroupItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GroupItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new GroupItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public GroupItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get the properties and relationships of a group object. This operation returns by default only a subset of all the available properties, as noted in the Properties section. To get properties that are not returned by default, specify them in a $select OData query option. The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query. Because the group resource supports extensions, you can also use the GET operation to get custom properties and extension data in a group instance.
        /// </summary>
        public class GroupItemRequestBuilderGetQueryParameters {
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
        public class GroupItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GroupItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GroupItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GroupItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GroupItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GroupItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new GroupItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public GroupItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
