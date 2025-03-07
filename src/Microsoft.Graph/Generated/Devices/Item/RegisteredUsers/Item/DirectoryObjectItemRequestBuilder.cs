// <auto-generated/>
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
namespace Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \devices\{device-id}\registeredUsers\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Casts the previous resource to endpoint.</summary>
        public Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphEndpoint.GraphEndpointRequestBuilder GraphEndpoint
        {
            get => new Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphEndpoint.GraphEndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphServicePrincipal.GraphServicePrincipalRequestBuilder GraphServicePrincipal
        {
            get => new Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphServicePrincipal.GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphUser.GraphUserRequestBuilder GraphUser
        {
            get => new Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.GraphUser.GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of device entities.</summary>
        public Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.Ref.RefRequestBuilder Ref
        {
            get => new Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/devices/{device%2Did}/registeredUsers/{directoryObject%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Devices.Item.RegisteredUsers.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/devices/{device%2Did}/registeredUsers/{directoryObject%2Did}", rawUrl)
        {
        }
    }
}
