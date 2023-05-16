using Microsoft.Graph.Beta.Identity.B2cUserFlows.Item.Languages.Item.DefaultPages;
using Microsoft.Graph.Beta.Identity.B2cUserFlows.Item.Languages.Item.OverridesPages;
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
namespace Microsoft.Graph.Beta.Identity.B2cUserFlows.Item.Languages.Item {
    /// <summary>
    /// Provides operations to manage the languages property of the microsoft.graph.b2cIdentityUserFlow entity.
    /// </summary>
    public class UserFlowLanguageConfigurationItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the defaultPages property of the microsoft.graph.userFlowLanguageConfiguration entity.</summary>
        public DefaultPagesRequestBuilder DefaultPages { get =>
            new DefaultPagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the overridesPages property of the microsoft.graph.userFlowLanguageConfiguration entity.</summary>
        public OverridesPagesRequestBuilder OverridesPages { get =>
            new OverridesPagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserFlowLanguageConfigurationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserFlowLanguageConfigurationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/languages/{userFlowLanguageConfiguration%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserFlowLanguageConfigurationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserFlowLanguageConfigurationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/languages/{userFlowLanguageConfiguration%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Deletes a userFlowLanguageConfiguration object from a Azure AD B2C user flow. **Note:** You cannot delete languages from an Azure Active Directory user flow.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/userflowlanguageconfiguration-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Read the properties and relationships of a userFlowLanguageConfiguration object. These objects represent a language available in a user flow. **Note:** To retrieve a language supported for customization, you must first enable language customization on your Azure AD B2C user flow. For more information, see Update b2cIdentityUserFlow. Language customization is enabled by default in Azure Active Directory user flows.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/userflowlanguageconfiguration-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserFlowLanguageConfiguration?> GetAsync(Action<UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserFlowLanguageConfiguration> GetAsync(Action<UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserFlowLanguageConfiguration>(requestInfo, UserFlowLanguageConfiguration.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// This method is used to create or update a custom language in an Azure AD B2C user flow. **Note:** You must enable language customization in the Azure AD B2C user flow before you can create a custom language. For more information, see Update b2cIdentityUserFlow.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/b2cidentityuserflow-put-languages?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserFlowLanguageConfiguration?> PatchAsync(UserFlowLanguageConfiguration body, Action<UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserFlowLanguageConfiguration> PatchAsync(UserFlowLanguageConfiguration body, Action<UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserFlowLanguageConfiguration>(requestInfo, UserFlowLanguageConfiguration.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Deletes a userFlowLanguageConfiguration object from a Azure AD B2C user flow. **Note:** You cannot delete languages from an Azure Active Directory user flow.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a userFlowLanguageConfiguration object. These objects represent a language available in a user flow. **Note:** To retrieve a language supported for customization, you must first enable language customization on your Azure AD B2C user flow. For more information, see Update b2cIdentityUserFlow. Language customization is enabled by default in Azure Active Directory user flows.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// This method is used to create or update a custom language in an Azure AD B2C user flow. **Note:** You must enable language customization in the Azure AD B2C user flow before you can create a custom language. For more information, see Update b2cIdentityUserFlow.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(UserFlowLanguageConfiguration body, Action<UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(UserFlowLanguageConfiguration body, Action<UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public UserFlowLanguageConfigurationItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read the properties and relationships of a userFlowLanguageConfiguration object. These objects represent a language available in a user flow. **Note:** To retrieve a language supported for customization, you must first enable language customization on your Azure AD B2C user flow. For more information, see Update b2cIdentityUserFlow. Language customization is enabled by default in Azure Active Directory user flows.
        /// </summary>
        public class UserFlowLanguageConfigurationItemRequestBuilderGetQueryParameters {
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
        public class UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserFlowLanguageConfigurationItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserFlowLanguageConfigurationItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserFlowLanguageConfigurationItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public UserFlowLanguageConfigurationItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
