using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class AccessPackageResourceScope : Entity, IParsable {
        /// <summary>The accessPackageResource property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
        /// <summary>The description of the scope.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name of the scope.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.</summary>
        public bool? IsRootScope {
            get { return BackingStore?.Get<bool?>("isRootScope"); }
            set { BackingStore?.Set("isRootScope", value); }
        }
        /// <summary>The unique identifier for the scope in the resource as defined in the origin system.</summary>
        public string OriginId {
            get { return BackingStore?.Get<string>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
        /// <summary>The origin system for the scope.</summary>
        public string OriginSystem {
            get { return BackingStore?.Get<string>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
        /// <summary>The origin system for the role, if different.</summary>
        public string RoleOriginId {
            get { return BackingStore?.Get<string>("roleOriginId"); }
            set { BackingStore?.Set("roleOriginId", value); }
        }
        /// <summary>A resource locator for the scope.</summary>
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageResourceScope and sets the default values.
        /// </summary>
        public AccessPackageResourceScope() : base() {
            OdataType = "#microsoft.graph.accessPackageResourceScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResourceScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResource", n => { AccessPackageResource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isRootScope", n => { IsRootScope = n.GetBoolValue(); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
                {"roleOriginId", n => { RoleOriginId = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isRootScope", IsRootScope);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("roleOriginId", RoleOriginId);
            writer.WriteStringValue("url", Url);
        }
    }
}
