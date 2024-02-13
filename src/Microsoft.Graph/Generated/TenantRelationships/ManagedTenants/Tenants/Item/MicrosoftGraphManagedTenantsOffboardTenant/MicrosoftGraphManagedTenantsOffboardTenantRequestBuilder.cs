// <auto-generated/>
using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.Tenants.Item.MicrosoftGraphManagedTenantsOffboardTenant {
    /// <summary>
    /// Provides operations to call the offboardTenant method.
    /// </summary>
    public class MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants/tenants/{tenant%2Did}/microsoft.graph.managedTenants.offboardTenant", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants/tenants/{tenant%2Did}/microsoft.graph.managedTenants.offboardTenant", rawUrl) {
        }
        /// <summary>
        /// Carries out the appropriate procedures to remove a managed tenant from the multitenant management platform. No relationships, such as commerce and delegate administrative privileges, will be impacted. The only change made by invoking this action is the tenant will be deprovisioned from the multitenant management platform.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/managedtenants-tenant-offboardtenant?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Tenant"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Tenant?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Tenant> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Tenant>(requestInfo, Tenant.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Carries out the appropriate procedures to remove a managed tenant from the multitenant management platform. No relationships, such as commerce and delegate administrative privileges, will be impacted. The only change made by invoking this action is the tenant will be deprovisioned from the multitenant management platform.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder WithUrl(string rawUrl) {
            return new MicrosoftGraphManagedTenantsOffboardTenantRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MicrosoftGraphManagedTenantsOffboardTenantRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
