// <auto-generated/>
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item.CreatedBy;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item.LastModifiedBy;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item.Tasks;
using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item {
    /// <summary>
    /// Provides operations to manage the versions property of the microsoft.graph.identityGovernance.workflow entity.
    /// </summary>
    public class WorkflowVersionVersionNumberItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the createdBy property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public CreatedByRequestBuilder CreatedBy { get =>
            new CreatedByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedBy property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public LastModifiedByRequestBuilder LastModifiedBy { get =>
            new LastModifiedByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tasks property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public TasksRequestBuilder Tasks { get =>
            new TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowVersionVersionNumberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowVersionVersionNumberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/versions/{workflowVersion%2DversionNumber}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowVersionVersionNumberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowVersionVersionNumberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/versions/{workflowVersion%2DversionNumber}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Read the properties and relationships of a workflowVersion object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-workflowversion-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="WorkflowVersion"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkflowVersion?> GetAsync(Action<RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkflowVersion> GetAsync(Action<RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkflowVersion>(requestInfo, WorkflowVersion.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read the properties and relationships of a workflowVersion object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WorkflowVersionVersionNumberItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WorkflowVersionVersionNumberItemRequestBuilder WithUrl(string rawUrl) {
            return new WorkflowVersionVersionNumberItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Read the properties and relationships of a workflowVersion object.
        /// </summary>
        public class WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters {
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
        public class WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration : RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters> {
        }
    }
}
