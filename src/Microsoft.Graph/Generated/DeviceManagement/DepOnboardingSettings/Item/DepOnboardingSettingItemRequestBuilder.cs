// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.DefaultIosEnrollmentProfile;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.DefaultMacOsEnrollmentProfile;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.EnrollmentProfiles;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.GenerateEncryptionPublicKey;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.GetEncryptionPublicKey;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.ShareForSchoolDataSyncService;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.SyncWithAppleDeviceEnrollmentProgram;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.UnshareForSchoolDataSyncService;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.UploadDepToken;
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
namespace Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item {
    /// <summary>
    /// Provides operations to manage the depOnboardingSettings property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class DepOnboardingSettingItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the defaultIosEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public DefaultIosEnrollmentProfileRequestBuilder DefaultIosEnrollmentProfile
        {
            get => new DefaultIosEnrollmentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the defaultMacOsEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public DefaultMacOsEnrollmentProfileRequestBuilder DefaultMacOsEnrollmentProfile
        {
            get => new DefaultMacOsEnrollmentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the enrollmentProfiles property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public EnrollmentProfilesRequestBuilder EnrollmentProfiles
        {
            get => new EnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the generateEncryptionPublicKey method.</summary>
        public GenerateEncryptionPublicKeyRequestBuilder GenerateEncryptionPublicKey
        {
            get => new GenerateEncryptionPublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEncryptionPublicKey method.</summary>
        public GetEncryptionPublicKeyRequestBuilder GetEncryptionPublicKey
        {
            get => new GetEncryptionPublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the importedAppleDeviceIdentities property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public ImportedAppleDeviceIdentitiesRequestBuilder ImportedAppleDeviceIdentities
        {
            get => new ImportedAppleDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the shareForSchoolDataSyncService method.</summary>
        public ShareForSchoolDataSyncServiceRequestBuilder ShareForSchoolDataSyncService
        {
            get => new ShareForSchoolDataSyncServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncWithAppleDeviceEnrollmentProgram method.</summary>
        public SyncWithAppleDeviceEnrollmentProgramRequestBuilder SyncWithAppleDeviceEnrollmentProgram
        {
            get => new SyncWithAppleDeviceEnrollmentProgramRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unshareForSchoolDataSyncService method.</summary>
        public UnshareForSchoolDataSyncServiceRequestBuilder UnshareForSchoolDataSyncService
        {
            get => new UnshareForSchoolDataSyncServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the uploadDepToken method.</summary>
        public UploadDepTokenRequestBuilder UploadDepToken
        {
            get => new UploadDepTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="DepOnboardingSettingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DepOnboardingSettingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DepOnboardingSettingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DepOnboardingSettingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property depOnboardingSettings for deviceManagement
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
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        /// <returns>A <see cref="DepOnboardingSetting"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DepOnboardingSetting?> GetAsync(Action<RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DepOnboardingSetting> GetAsync(Action<RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DepOnboardingSetting>(requestInfo, DepOnboardingSetting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property depOnboardingSettings in deviceManagement
        /// </summary>
        /// <returns>A <see cref="DepOnboardingSetting"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DepOnboardingSetting?> PatchAsync(DepOnboardingSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DepOnboardingSetting> PatchAsync(DepOnboardingSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DepOnboardingSetting>(requestInfo, DepOnboardingSetting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property depOnboardingSettings for deviceManagement
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
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property depOnboardingSettings in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DepOnboardingSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DepOnboardingSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="DepOnboardingSettingItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DepOnboardingSettingItemRequestBuilder WithUrl(string rawUrl)
        {
            return new DepOnboardingSettingItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        public class DepOnboardingSettingItemRequestBuilderGetQueryParameters 
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
        public class DepOnboardingSettingItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
