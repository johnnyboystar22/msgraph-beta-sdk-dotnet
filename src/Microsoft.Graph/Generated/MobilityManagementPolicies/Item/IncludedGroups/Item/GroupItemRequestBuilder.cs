using Microsoft.Graph.Beta.MobilityManagementPolicies.Item.IncludedGroups.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.MobilityManagementPolicies.Item.IncludedGroups.Item {
    /// <summary>
    /// Builds and executes requests for operations under \mobilityManagementPolicies\{mobilityManagementPolicy-id}\includedGroups\{group-id}
    /// </summary>
    public class GroupItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of mobilityManagementPolicy entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/mobilityManagementPolicies/{mobilityManagementPolicy%2Did}/includedGroups/{group%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/mobilityManagementPolicies/{mobilityManagementPolicy%2Did}/includedGroups/{group%2Did}", rawUrl) {
        }
    }
}
