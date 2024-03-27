// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessWhatIfPolicy : ConditionalAccessPolicy, IParsable 
    {
        /// <summary>The policyApplies property</summary>
        public bool? PolicyApplies {
            get { return BackingStore?.Get<bool?>("policyApplies"); }
            set { BackingStore?.Set("policyApplies", value); }
        }
        /// <summary>The reasons property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessWhatIfReasons?>? Reasons {
            get { return BackingStore?.Get<List<ConditionalAccessWhatIfReasons?>?>("reasons"); }
            set { BackingStore?.Set("reasons", value); }
        }
#nullable restore
#else
        public List<ConditionalAccessWhatIfReasons?> Reasons {
            get { return BackingStore?.Get<List<ConditionalAccessWhatIfReasons?>>("reasons"); }
            set { BackingStore?.Set("reasons", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConditionalAccessWhatIfPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConditionalAccessWhatIfPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessWhatIfPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"policyApplies", n => { PolicyApplies = n.GetBoolValue(); } },
                {"reasons", n => { Reasons = n.GetCollectionOfEnumValues<ConditionalAccessWhatIfReasons>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("policyApplies", PolicyApplies);
            writer.WriteCollectionOfEnumValues<ConditionalAccessWhatIfReasons>("reasons", Reasons);
        }
    }
}
