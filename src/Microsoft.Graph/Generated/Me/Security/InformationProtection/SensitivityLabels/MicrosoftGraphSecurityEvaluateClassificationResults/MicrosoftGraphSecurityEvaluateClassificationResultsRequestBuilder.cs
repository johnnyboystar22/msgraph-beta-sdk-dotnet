// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Me.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateClassificationResults {
    /// <summary>
    /// Provides operations to call the evaluateClassificationResults method.
    /// </summary>
    public class MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/security/informationProtection/sensitivityLabels/microsoft.graph.security.evaluateClassificationResults", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/security/informationProtection/sensitivityLabels/microsoft.graph.security.evaluateClassificationResults", rawUrl) {
        }
        /// <summary>
        /// Use the classification results to compute the sensitivity label that should be applied and return the set of actions that must be taken to correctly label the information. This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.  To evaluate based on classification results, provide the contentInfo, which includes existing content metadata key-value pairs, and classification results. The API returns an informationProtectionAction that contains one of more of the following:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-sensitivitylabel-evaluateclassificationresults?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="EvaluateClassificationResultsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EvaluateClassificationResultsPostResponse?> PostAsEvaluateClassificationResultsPostResponseAsync(EvaluateClassificationResultsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<EvaluateClassificationResultsPostResponse> PostAsEvaluateClassificationResultsPostResponseAsync(EvaluateClassificationResultsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EvaluateClassificationResultsPostResponse>(requestInfo, EvaluateClassificationResultsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use the classification results to compute the sensitivity label that should be applied and return the set of actions that must be taken to correctly label the information. This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.  To evaluate based on classification results, provide the contentInfo, which includes existing content metadata key-value pairs, and classification results. The API returns an informationProtectionAction that contains one of more of the following:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-sensitivitylabel-evaluateclassificationresults?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="EvaluateClassificationResultsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use {TypeName} instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EvaluateClassificationResultsResponse?> PostAsync(EvaluateClassificationResultsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<EvaluateClassificationResultsResponse> PostAsync(EvaluateClassificationResultsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EvaluateClassificationResultsResponse>(requestInfo, EvaluateClassificationResultsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use the classification results to compute the sensitivity label that should be applied and return the set of actions that must be taken to correctly label the information. This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.  To evaluate based on classification results, provide the contentInfo, which includes existing content metadata key-value pairs, and classification results. The API returns an informationProtectionAction that contains one of more of the following:
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(EvaluateClassificationResultsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(EvaluateClassificationResultsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// <returns>A <see cref="MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder WithUrl(string rawUrl) {
            return new MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MicrosoftGraphSecurityEvaluateClassificationResultsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
