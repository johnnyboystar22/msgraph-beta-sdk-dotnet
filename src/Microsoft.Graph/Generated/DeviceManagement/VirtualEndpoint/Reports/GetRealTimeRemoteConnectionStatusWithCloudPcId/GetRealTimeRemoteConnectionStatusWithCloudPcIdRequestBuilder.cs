using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId {
    /// <summary>
    /// Provides operations to call the getRealTimeRemoteConnectionStatus method.
    /// </summary>
    public class GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="cloudPcId">Usage: cloudPcId=&apos;{cloudPcId}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string cloudPcId = "") : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/reports/getRealTimeRemoteConnectionStatus(cloudPcId='{cloudPcId}')", pathParameters) {
            if (!string.IsNullOrWhiteSpace(cloudPcId)) PathParameters.Add("cloudPcId", cloudPcId);
        }
        /// <summary>
        /// Instantiates a new GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/reports/getRealTimeRemoteConnectionStatus(cloudPcId='{cloudPcId}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function getRealTimeRemoteConnectionStatus
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getRealTimeRemoteConnectionStatus
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
