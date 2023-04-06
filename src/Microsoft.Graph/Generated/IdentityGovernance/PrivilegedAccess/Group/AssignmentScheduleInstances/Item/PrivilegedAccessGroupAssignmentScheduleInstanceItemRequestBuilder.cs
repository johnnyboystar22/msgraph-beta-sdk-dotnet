using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleInstances.Item.ActivatedUsing;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleInstances.Item.Group;
using Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleInstances.Item.Principal;
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
namespace Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleInstances.Item {
    /// <summary>
    /// Provides operations to manage the assignmentScheduleInstances property of the microsoft.graph.privilegedAccessGroup entity.
    /// </summary>
    public class PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the activatedUsing property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleInstance entity.</summary>
        public ActivatedUsingRequestBuilder ActivatedUsing { get =>
            new ActivatedUsingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the group property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleInstance entity.</summary>
        public Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleInstances.Item.Group.GroupRequestBuilder Group { get =>
            new Microsoft.Graph.Beta.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleInstances.Item.Group.GroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the principal property of the microsoft.graph.privilegedAccessGroupAssignmentScheduleInstance entity.</summary>
        public PrincipalRequestBuilder Principal { get =>
            new PrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/privilegedAccess/group/assignmentScheduleInstances/{privilegedAccessGroupAssignmentScheduleInstance%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/privilegedAccess/group/assignmentScheduleInstances/{privilegedAccessGroupAssignmentScheduleInstance%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property assignmentScheduleInstances for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get assignmentScheduleInstances from identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PrivilegedAccessGroupAssignmentScheduleInstance?> GetAsync(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PrivilegedAccessGroupAssignmentScheduleInstance> GetAsync(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PrivilegedAccessGroupAssignmentScheduleInstance>(requestInfo, PrivilegedAccessGroupAssignmentScheduleInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property assignmentScheduleInstances in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PrivilegedAccessGroupAssignmentScheduleInstance?> PatchAsync(PrivilegedAccessGroupAssignmentScheduleInstance body, Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PrivilegedAccessGroupAssignmentScheduleInstance> PatchAsync(PrivilegedAccessGroupAssignmentScheduleInstance body, Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PrivilegedAccessGroupAssignmentScheduleInstance>(requestInfo, PrivilegedAccessGroupAssignmentScheduleInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property assignmentScheduleInstances for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get assignmentScheduleInstances from identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property assignmentScheduleInstances in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(PrivilegedAccessGroupAssignmentScheduleInstance body, Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(PrivilegedAccessGroupAssignmentScheduleInstance body, Action<PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get assignmentScheduleInstances from identityGovernance
        /// </summary>
        public class PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetQueryParameters {
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
        public class PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public PrivilegedAccessGroupAssignmentScheduleInstanceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
