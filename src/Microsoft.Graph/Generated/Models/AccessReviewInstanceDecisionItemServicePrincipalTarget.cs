using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewInstanceDecisionItemServicePrincipalTarget : AccessReviewInstanceDecisionItemTarget, IParsable {
        /// <summary>The appId for the service principal entity being reviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>The display name of the service principal whose access is being reviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalDisplayName {
            get { return BackingStore?.Get<string?>("servicePrincipalDisplayName"); }
            set { BackingStore?.Set("servicePrincipalDisplayName", value); }
        }
#nullable restore
#else
        public string ServicePrincipalDisplayName {
            get { return BackingStore?.Get<string>("servicePrincipalDisplayName"); }
            set { BackingStore?.Set("servicePrincipalDisplayName", value); }
        }
#endif
        /// <summary>The servicePrincipalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalId {
            get { return BackingStore?.Get<string?>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#nullable restore
#else
        public string ServicePrincipalId {
            get { return BackingStore?.Get<string>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AccessReviewInstanceDecisionItemServicePrincipalTarget and sets the default values.
        /// </summary>
        public AccessReviewInstanceDecisionItemServicePrincipalTarget() : base() {
            OdataType = "#microsoft.graph.accessReviewInstanceDecisionItemServicePrincipalTarget";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewInstanceDecisionItemServicePrincipalTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewInstanceDecisionItemServicePrincipalTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"servicePrincipalDisplayName", n => { ServicePrincipalDisplayName = n.GetStringValue(); } },
                {"servicePrincipalId", n => { ServicePrincipalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("servicePrincipalDisplayName", ServicePrincipalDisplayName);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
        }
    }
}
