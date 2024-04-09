// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.AuditEvents;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.BulkActions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CrossCloudGovernmentOrganizationMapping;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.DeviceImages;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ExternalPartnerSettings;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.FrontLineServicePlans;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GalleryImages;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OnPremisesConnections;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OrganizationSettings;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.RetrieveScopedPermissions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.RetrieveTenantEncryptionSetting;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ServicePlans;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.SharedUseServicePlans;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Snapshots;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.SupportedRegions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.UserSettings;
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
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint {
    /// <summary>
    /// Provides operations to manage the virtualEndpoint property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class VirtualEndpointRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the auditEvents property of the microsoft.graph.virtualEndpoint entity.</summary>
        public AuditEventsRequestBuilder AuditEvents
        {
            get => new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the bulkActions property of the microsoft.graph.virtualEndpoint entity.</summary>
        public BulkActionsRequestBuilder BulkActions
        {
            get => new BulkActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPCs property of the microsoft.graph.virtualEndpoint entity.</summary>
        public CloudPCsRequestBuilder CloudPCs
        {
            get => new CloudPCsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the crossCloudGovernmentOrganizationMapping property of the microsoft.graph.virtualEndpoint entity.</summary>
        public CrossCloudGovernmentOrganizationMappingRequestBuilder CrossCloudGovernmentOrganizationMapping
        {
            get => new CrossCloudGovernmentOrganizationMappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceImages property of the microsoft.graph.virtualEndpoint entity.</summary>
        public DeviceImagesRequestBuilder DeviceImages
        {
            get => new DeviceImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalPartnerSettings property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ExternalPartnerSettingsRequestBuilder ExternalPartnerSettings
        {
            get => new ExternalPartnerSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the frontLineServicePlans property of the microsoft.graph.virtualEndpoint entity.</summary>
        public FrontLineServicePlansRequestBuilder FrontLineServicePlans
        {
            get => new FrontLineServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the galleryImages property of the microsoft.graph.virtualEndpoint entity.</summary>
        public GalleryImagesRequestBuilder GalleryImages
        {
            get => new GalleryImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEffectivePermissions method.</summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions
        {
            get => new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onPremisesConnections property of the microsoft.graph.virtualEndpoint entity.</summary>
        public OnPremisesConnectionsRequestBuilder OnPremisesConnections
        {
            get => new OnPremisesConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the organizationSettings property of the microsoft.graph.virtualEndpoint entity.</summary>
        public OrganizationSettingsRequestBuilder OrganizationSettings
        {
            get => new OrganizationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the provisioningPolicies property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ProvisioningPoliciesRequestBuilder ProvisioningPolicies
        {
            get => new ProvisioningPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reports property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ReportsRequestBuilder Reports
        {
            get => new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retrieveScopedPermissions method.</summary>
        public RetrieveScopedPermissionsRequestBuilder RetrieveScopedPermissions
        {
            get => new RetrieveScopedPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retrieveTenantEncryptionSetting method.</summary>
        public RetrieveTenantEncryptionSettingRequestBuilder RetrieveTenantEncryptionSetting
        {
            get => new RetrieveTenantEncryptionSettingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the servicePlans property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ServicePlansRequestBuilder ServicePlans
        {
            get => new ServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharedUseServicePlans property of the microsoft.graph.virtualEndpoint entity.</summary>
        public SharedUseServicePlansRequestBuilder SharedUseServicePlans
        {
            get => new SharedUseServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the snapshots property of the microsoft.graph.virtualEndpoint entity.</summary>
        public SnapshotsRequestBuilder Snapshots
        {
            get => new SnapshotsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the supportedRegions property of the microsoft.graph.virtualEndpoint entity.</summary>
        public SupportedRegionsRequestBuilder SupportedRegions
        {
            get => new SupportedRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userSettings property of the microsoft.graph.virtualEndpoint entity.</summary>
        public UserSettingsRequestBuilder UserSettings
        {
            get => new UserSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="VirtualEndpointRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEndpointRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="VirtualEndpointRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEndpointRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property virtualEndpoint for deviceManagement
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
        /// Get virtualEndpoint from deviceManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.VirtualEndpoint"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint?> GetAsync(Action<RequestConfiguration<VirtualEndpointRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint> GetAsync(Action<RequestConfiguration<VirtualEndpointRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.VirtualEndpoint>(requestInfo, Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.VirtualEndpoint"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint?> PatchAsync(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint> PatchAsync(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.VirtualEndpoint>(requestInfo, Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property virtualEndpoint for deviceManagement
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
        /// Get virtualEndpoint from deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<VirtualEndpointRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<VirtualEndpointRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="VirtualEndpointRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VirtualEndpointRequestBuilder WithUrl(string rawUrl)
        {
            return new VirtualEndpointRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VirtualEndpointRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Get virtualEndpoint from deviceManagement
        /// </summary>
        public class VirtualEndpointRequestBuilderGetQueryParameters 
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
        public class VirtualEndpointRequestBuilderGetRequestConfiguration : RequestConfiguration<VirtualEndpointRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VirtualEndpointRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
