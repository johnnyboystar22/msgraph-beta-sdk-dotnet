using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResourceRole : Entity, IParsable {
        /// <summary>The accessPackageResource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageResource? AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource?>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
#endif
        /// <summary>A description for the resource role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the resource role such as the role defined by the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginId {
            get { return BackingStore?.Get<string?>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
#nullable restore
#else
        public string OriginId {
            get { return BackingStore?.Get<string>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
#endif
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginSystem {
            get { return BackingStore?.Get<string?>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
#nullable restore
#else
        public string OriginSystem {
            get { return BackingStore?.Get<string>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResourceRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResource", n => { AccessPackageResource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
        }
    }
}
