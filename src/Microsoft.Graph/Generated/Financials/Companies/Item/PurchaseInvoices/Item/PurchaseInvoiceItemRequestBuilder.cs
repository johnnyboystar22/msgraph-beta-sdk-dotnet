// <auto-generated/>
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Currency;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Post;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Vendor;
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
namespace Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item
{
    /// <summary>
    /// Provides operations to manage the purchaseInvoices property of the microsoft.graph.company entity.
    /// </summary>
    public class PurchaseInvoiceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the currency property of the microsoft.graph.purchaseInvoice entity.</summary>
        public Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Currency.CurrencyRequestBuilder Currency
        {
            get => new Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Currency.CurrencyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the post method.</summary>
        public Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Post.PostRequestBuilder PostPath
        {
            get => new Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Post.PostRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the purchaseInvoiceLines property of the microsoft.graph.purchaseInvoice entity.</summary>
        public Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceLines.PurchaseInvoiceLinesRequestBuilder PurchaseInvoiceLines
        {
            get => new Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceLines.PurchaseInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the vendor property of the microsoft.graph.purchaseInvoice entity.</summary>
        public Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Vendor.VendorRequestBuilder Vendor
        {
            get => new Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.Vendor.VendorRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PurchaseInvoiceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}/purchaseInvoices/{purchaseInvoice%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PurchaseInvoiceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}/purchaseInvoices/{purchaseInvoice%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get purchaseInvoices from financials
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PurchaseInvoice"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.PurchaseInvoice?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder.PurchaseInvoiceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.PurchaseInvoice> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder.PurchaseInvoiceItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.PurchaseInvoice>(requestInfo, Microsoft.Graph.Beta.Models.PurchaseInvoice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property purchaseInvoices in financials
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PurchaseInvoice"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.PurchaseInvoice?> PatchAsync(Microsoft.Graph.Beta.Models.PurchaseInvoice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.PurchaseInvoice> PatchAsync(Microsoft.Graph.Beta.Models.PurchaseInvoice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.PurchaseInvoice>(requestInfo, Microsoft.Graph.Beta.Models.PurchaseInvoice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get purchaseInvoices from financials
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder.PurchaseInvoiceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder.PurchaseInvoiceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property purchaseInvoices in financials
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.PurchaseInvoice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.PurchaseInvoice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get purchaseInvoices from financials
        /// </summary>
        public class PurchaseInvoiceItemRequestBuilderGetQueryParameters 
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
        public class PurchaseInvoiceItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices.Item.PurchaseInvoiceItemRequestBuilder.PurchaseInvoiceItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PurchaseInvoiceItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
