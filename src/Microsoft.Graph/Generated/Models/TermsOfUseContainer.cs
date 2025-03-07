// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class TermsOfUseContainer : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the current status of a user&apos;s response to a company&apos;s customizable terms of use agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AgreementAcceptance>? AgreementAcceptances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgreementAcceptance>?>("agreementAcceptances"); }
            set { BackingStore?.Set("agreementAcceptances", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AgreementAcceptance> AgreementAcceptances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgreementAcceptance>>("agreementAcceptances"); }
            set { BackingStore?.Set("agreementAcceptances", value); }
        }
#endif
        /// <summary>Represents a tenant&apos;s customizable terms of use agreement that&apos;s created and managed with Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Agreement>? Agreements
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Agreement>?>("agreements"); }
            set { BackingStore?.Set("agreements", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Agreement> Agreements
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Agreement>>("agreements"); }
            set { BackingStore?.Set("agreements", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TermsOfUseContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.TermsOfUseContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.TermsOfUseContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "agreementAcceptances", n => { AgreementAcceptances = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgreementAcceptance>(Microsoft.Graph.Beta.Models.AgreementAcceptance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "agreements", n => { Agreements = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Agreement>(Microsoft.Graph.Beta.Models.Agreement.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Agreement>("agreements", Agreements);
        }
    }
}
