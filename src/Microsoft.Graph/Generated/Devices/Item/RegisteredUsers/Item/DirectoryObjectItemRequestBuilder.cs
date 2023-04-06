using Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphEndpoint;
using Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphServicePrincipal;
using Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphUser;
using Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item {
    /// <summary>
    /// Builds and executes requests for operations under \devices\{device-id}\registeredUsers\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Casts the previous resource to endpoint.</summary>
        public GraphEndpointRequestBuilder GraphEndpoint { get =>
            new GraphEndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public GraphServicePrincipalRequestBuilder GraphServicePrincipal { get =>
            new GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public GraphUserRequestBuilder GraphUser { get =>
            new GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of device entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/devices/{device%2Did}/registeredUsers/{directoryObject%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/devices/{device%2Did}/registeredUsers/{directoryObject%2Did}", rawUrl) {
        }
    }
}
