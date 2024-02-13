// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ServiceLevelAgreementRoot : Entity, IParsable {
        /// <summary>Collects the Microsoft Entra SLA attainment for each month for a Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AzureADAuthentication? AzureADAuthentication {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AzureADAuthentication?>("azureADAuthentication"); }
            set { BackingStore?.Set("azureADAuthentication", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AzureADAuthentication AzureADAuthentication {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AzureADAuthentication>("azureADAuthentication"); }
            set { BackingStore?.Set("azureADAuthentication", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ServiceLevelAgreementRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceLevelAgreementRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceLevelAgreementRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureADAuthentication", n => { AzureADAuthentication = n.GetObjectValue<Microsoft.Graph.Beta.Models.AzureADAuthentication>(Microsoft.Graph.Beta.Models.AzureADAuthentication.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AzureADAuthentication>("azureADAuthentication", AzureADAuthentication);
        }
    }
}
