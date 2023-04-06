using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class InvokeUserFlowListener : AuthenticationListener, IParsable {
        /// <summary>The user flow that is invoked when this action executes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public B2xIdentityUserFlow? UserFlow {
            get { return BackingStore?.Get<B2xIdentityUserFlow?>("userFlow"); }
            set { BackingStore?.Set("userFlow", value); }
        }
#nullable restore
#else
        public B2xIdentityUserFlow UserFlow {
            get { return BackingStore?.Get<B2xIdentityUserFlow>("userFlow"); }
            set { BackingStore?.Set("userFlow", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new InvokeUserFlowListener and sets the default values.
        /// </summary>
        public InvokeUserFlowListener() : base() {
            OdataType = "#microsoft.graph.invokeUserFlowListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InvokeUserFlowListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvokeUserFlowListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userFlow", n => { UserFlow = n.GetObjectValue<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<B2xIdentityUserFlow>("userFlow", UserFlow);
        }
    }
}
