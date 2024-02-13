// <auto-generated/>
using Microsoft.Graph.Beta.Me.Authentication.EmailMethods;
using Microsoft.Graph.Beta.Me.Authentication.Fido2Methods;
using Microsoft.Graph.Beta.Me.Authentication.Methods;
using Microsoft.Graph.Beta.Me.Authentication.MicrosoftAuthenticatorMethods;
using Microsoft.Graph.Beta.Me.Authentication.Operations;
using Microsoft.Graph.Beta.Me.Authentication.PasswordMethods;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods;
using Microsoft.Graph.Beta.Me.Authentication.PhoneMethods;
using Microsoft.Graph.Beta.Me.Authentication.PlatformCredentialMethods;
using Microsoft.Graph.Beta.Me.Authentication.SignInPreferences;
using Microsoft.Graph.Beta.Me.Authentication.SoftwareOathMethods;
using Microsoft.Graph.Beta.Me.Authentication.TemporaryAccessPassMethods;
using Microsoft.Graph.Beta.Me.Authentication.WindowsHelloForBusinessMethods;
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
namespace Microsoft.Graph.Beta.Me.Authentication {
    /// <summary>
    /// Provides operations to manage the authentication property of the microsoft.graph.user entity.
    /// </summary>
    public class AuthenticationRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the emailMethods property of the microsoft.graph.authentication entity.</summary>
        public EmailMethodsRequestBuilder EmailMethods { get =>
            new EmailMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the fido2Methods property of the microsoft.graph.authentication entity.</summary>
        public Fido2MethodsRequestBuilder Fido2Methods { get =>
            new Fido2MethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the methods property of the microsoft.graph.authentication entity.</summary>
        public MethodsRequestBuilder Methods { get =>
            new MethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftAuthenticatorMethods property of the microsoft.graph.authentication entity.</summary>
        public MicrosoftAuthenticatorMethodsRequestBuilder MicrosoftAuthenticatorMethods { get =>
            new MicrosoftAuthenticatorMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.authentication entity.</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passwordlessMicrosoftAuthenticatorMethods property of the microsoft.graph.authentication entity.</summary>
        public PasswordlessMicrosoftAuthenticatorMethodsRequestBuilder PasswordlessMicrosoftAuthenticatorMethods { get =>
            new PasswordlessMicrosoftAuthenticatorMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passwordMethods property of the microsoft.graph.authentication entity.</summary>
        public PasswordMethodsRequestBuilder PasswordMethods { get =>
            new PasswordMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the phoneMethods property of the microsoft.graph.authentication entity.</summary>
        public PhoneMethodsRequestBuilder PhoneMethods { get =>
            new PhoneMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the platformCredentialMethods property of the microsoft.graph.authentication entity.</summary>
        public PlatformCredentialMethodsRequestBuilder PlatformCredentialMethods { get =>
            new PlatformCredentialMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The signInPreferences property</summary>
        public SignInPreferencesRequestBuilder SignInPreferences { get =>
            new SignInPreferencesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the softwareOathMethods property of the microsoft.graph.authentication entity.</summary>
        public SoftwareOathMethodsRequestBuilder SoftwareOathMethods { get =>
            new SoftwareOathMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the temporaryAccessPassMethods property of the microsoft.graph.authentication entity.</summary>
        public TemporaryAccessPassMethodsRequestBuilder TemporaryAccessPassMethods { get =>
            new TemporaryAccessPassMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsHelloForBusinessMethods property of the microsoft.graph.authentication entity.</summary>
        public WindowsHelloForBusinessMethodsRequestBuilder WindowsHelloForBusinessMethods { get =>
            new WindowsHelloForBusinessMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/authentication{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/authentication{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property authentication for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The authentication methods that are supported for the user.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Authentication"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Authentication?> GetAsync(Action<RequestConfiguration<AuthenticationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Authentication> GetAsync(Action<RequestConfiguration<AuthenticationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Authentication>(requestInfo, Microsoft.Graph.Beta.Models.Authentication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property authentication in me
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Authentication"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Authentication?> PatchAsync(Microsoft.Graph.Beta.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Authentication> PatchAsync(Microsoft.Graph.Beta.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Authentication>(requestInfo, Microsoft.Graph.Beta.Models.Authentication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property authentication for me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/me/authentication", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The authentication methods that are supported for the user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AuthenticationRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AuthenticationRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property authentication in me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/me/authentication", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="AuthenticationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AuthenticationRequestBuilder WithUrl(string rawUrl) {
            return new AuthenticationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AuthenticationRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// The authentication methods that are supported for the user.
        /// </summary>
        public class AuthenticationRequestBuilderGetQueryParameters {
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
        public class AuthenticationRequestBuilderGetRequestConfiguration : RequestConfiguration<AuthenticationRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AuthenticationRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
