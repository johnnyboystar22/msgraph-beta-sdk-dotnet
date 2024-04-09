// <auto-generated/>
using Microsoft.Graph.Beta.Me.ManagedDevices.AppDiagnosticsWithUpn;
using Microsoft.Graph.Beta.Me.ManagedDevices.BulkReprovisionCloudPc;
using Microsoft.Graph.Beta.Me.ManagedDevices.BulkRestoreCloudPc;
using Microsoft.Graph.Beta.Me.ManagedDevices.BulkSetCloudPcReviewStatus;
using Microsoft.Graph.Beta.Me.ManagedDevices.Count;
using Microsoft.Graph.Beta.Me.ManagedDevices.DownloadAppDiagnostics;
using Microsoft.Graph.Beta.Me.ManagedDevices.ExecuteAction;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item;
using Microsoft.Graph.Beta.Me.ManagedDevices.MoveDevicesToOU;
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
namespace Microsoft.Graph.Beta.Me.ManagedDevices {
    /// <summary>
    /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
    /// </summary>
    public class ManagedDevicesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to call the bulkReprovisionCloudPc method.</summary>
        public BulkReprovisionCloudPcRequestBuilder BulkReprovisionCloudPc
        {
            get => new BulkReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the bulkRestoreCloudPc method.</summary>
        public BulkRestoreCloudPcRequestBuilder BulkRestoreCloudPc
        {
            get => new BulkRestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the bulkSetCloudPcReviewStatus method.</summary>
        public BulkSetCloudPcReviewStatusRequestBuilder BulkSetCloudPcReviewStatus
        {
            get => new BulkSetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count
        {
            get => new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the downloadAppDiagnostics method.</summary>
        public DownloadAppDiagnosticsRequestBuilder DownloadAppDiagnostics
        {
            get => new DownloadAppDiagnosticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the executeAction method.</summary>
        public ExecuteActionRequestBuilder ExecuteAction
        {
            get => new ExecuteActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the moveDevicesToOU method.</summary>
        public MoveDevicesToOURequestBuilder MoveDevicesToOU
        {
            get => new MoveDevicesToOURequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.user entity.</summary>
        /// <param name="position">The unique identifier of managedDevice</param>
        /// <returns>A <see cref="ManagedDeviceItemRequestBuilder"/></returns>
        public ManagedDeviceItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("managedDevice%2Did", position);
                return new ManagedDeviceItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Provides operations to call the appDiagnostics method.
        /// </summary>
        /// <returns>A <see cref="AppDiagnosticsWithUpnRequestBuilder"/></returns>
        /// <param name="upn">Usage: upn=&apos;{upn}&apos;</param>
        public AppDiagnosticsWithUpnRequestBuilder AppDiagnosticsWithUpn(string upn)
        {
            if(string.IsNullOrEmpty(upn)) throw new ArgumentNullException(nameof(upn));
            return new AppDiagnosticsWithUpnRequestBuilder(PathParameters, RequestAdapter, upn);
        }
        /// <summary>
        /// Instantiates a new <see cref="ManagedDevicesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDevicesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/managedDevices{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ManagedDevicesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDevicesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/managedDevices{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <returns>A <see cref="ManagedDeviceCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedDeviceCollectionResponse?> GetAsync(Action<RequestConfiguration<ManagedDevicesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ManagedDeviceCollectionResponse> GetAsync(Action<RequestConfiguration<ManagedDevicesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedDeviceCollectionResponse>(requestInfo, ManagedDeviceCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to managedDevices for me
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ManagedDevice"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice?> PostAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice> PostAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ManagedDevice>(requestInfo, Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ManagedDevicesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ManagedDevicesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to managedDevices for me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ManagedDevicesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ManagedDevicesRequestBuilder WithUrl(string rawUrl)
        {
            return new ManagedDevicesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public class ManagedDevicesRequestBuilderGetQueryParameters 
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
        public class ManagedDevicesRequestBuilderGetRequestConfiguration : RequestConfiguration<ManagedDevicesRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ManagedDevicesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
