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
namespace Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Names.Item.RangeNamespace
{
    /// <summary>
    /// Provides operations to call the range method.
    /// </summary>
    public class RangeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Names.Item.RangeNamespace.RangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RangeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/names/{workbookNamedItem%2Did}/range()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Names.Item.RangeNamespace.RangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RangeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/names/{workbookNamedItem%2Did}/range()", rawUrl)
        {
        }
        /// <summary>
        /// Returns the range object that is associated with the name. Throws an exception if the named item&apos;s type is not a range.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/nameditem-range?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WorkbookRange"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WorkbookRange?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WorkbookRange> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WorkbookRange>(requestInfo, Microsoft.Graph.Beta.Models.WorkbookRange.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the range object that is associated with the name. Throws an exception if the named item&apos;s type is not a range.
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Names.Item.RangeNamespace.RangeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Names.Item.RangeNamespace.RangeRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Names.Item.RangeNamespace.RangeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RangeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
