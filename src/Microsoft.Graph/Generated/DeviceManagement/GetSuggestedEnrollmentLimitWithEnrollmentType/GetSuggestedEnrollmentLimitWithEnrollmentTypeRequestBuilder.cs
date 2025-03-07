// <auto-generated/>
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
namespace Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType
{
    /// <summary>
    /// Provides operations to call the getSuggestedEnrollmentLimit method.
    /// </summary>
    public class GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType.GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="enrollmentType">Usage: enrollmentType=&apos;{enrollmentType}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string enrollmentType = "") : base(requestAdapter, "{+baseurl}/deviceManagement/getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(enrollmentType)) PathParameters.Add("enrollmentType", enrollmentType);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType.GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function getSuggestedEnrollmentLimit
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SuggestedEnrollmentLimit"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.SuggestedEnrollmentLimit?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.SuggestedEnrollmentLimit> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.SuggestedEnrollmentLimit>(requestInfo, Microsoft.Graph.Beta.Models.SuggestedEnrollmentLimit.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getSuggestedEnrollmentLimit
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType.GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType.GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType.GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
