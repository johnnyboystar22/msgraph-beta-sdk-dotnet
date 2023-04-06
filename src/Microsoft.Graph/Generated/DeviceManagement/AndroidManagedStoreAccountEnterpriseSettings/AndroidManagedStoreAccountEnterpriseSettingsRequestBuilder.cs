using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.AddApps;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CompleteSignup;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RequestSignupUrl;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.SetAndroidDeviceOwnerFullyManagedEnrollmentState;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.SyncApps;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.Unbind;
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
namespace Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings {
    /// <summary>
    /// Provides operations to manage the androidManagedStoreAccountEnterpriseSettings property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the addApps method.</summary>
        public AddAppsRequestBuilder AddApps { get =>
            new AddAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the approveApps method.</summary>
        public ApproveAppsRequestBuilder ApproveApps { get =>
            new ApproveAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the completeSignup method.</summary>
        public CompleteSignupRequestBuilder CompleteSignup { get =>
            new CompleteSignupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createGooglePlayWebToken method.</summary>
        public CreateGooglePlayWebTokenRequestBuilder CreateGooglePlayWebToken { get =>
            new CreateGooglePlayWebTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestSignupUrl method.</summary>
        public RequestSignupUrlRequestBuilder RequestSignupUrl { get =>
            new RequestSignupUrlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setAndroidDeviceOwnerFullyManagedEnrollmentState method.</summary>
        public SetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder SetAndroidDeviceOwnerFullyManagedEnrollmentState { get =>
            new SetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncApps method.</summary>
        public SyncAppsRequestBuilder SyncApps { get =>
            new SyncAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unbind method.</summary>
        public UnbindRequestBuilder Unbind { get =>
            new UnbindRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/androidManagedStoreAccountEnterpriseSettings{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/androidManagedStoreAccountEnterpriseSettings{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property androidManagedStoreAccountEnterpriseSettings for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The singleton Android managed store account enterprise settings entity.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings?> GetAsync(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings> GetAsync(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(requestInfo, Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property androidManagedStoreAccountEnterpriseSettings in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings?> PatchAsync(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings body, Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings> PatchAsync(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings body, Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(requestInfo, Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property androidManagedStoreAccountEnterpriseSettings for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The singleton Android managed store account enterprise settings entity.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property androidManagedStoreAccountEnterpriseSettings in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings body, Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings body, Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new androidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The singleton Android managed store account enterprise settings entity.
        /// </summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetQueryParameters {
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
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new androidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new androidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
