// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class EdiscoveryFile : Microsoft.Graph.Beta.Models.Security.FileObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Custodians associated with the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian? Custodian
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian?>("custodian"); }
            set { BackingStore?.Set("custodian", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian Custodian
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>("custodian"); }
            set { BackingStore?.Set("custodian", value); }
        }
#endif
        /// <summary>Tags associated with the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>? Tags
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag> Tags
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.EdiscoveryFile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.EdiscoveryFile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.EdiscoveryFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "custodian", n => { Custodian = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>(Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>(Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>("custodian", Custodian);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>("tags", Tags);
        }
    }
}
