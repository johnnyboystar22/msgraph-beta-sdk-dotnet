// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class AnalyzedEmailSenderDetail : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The sender email address in the mail From header, also known as the envelope sender or the P1 sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromAddress
        {
            get { return BackingStore?.Get<string?>("fromAddress"); }
            set { BackingStore?.Set("fromAddress", value); }
        }
#nullable restore
#else
        public string FromAddress
        {
            get { return BackingStore?.Get<string>("fromAddress"); }
            set { BackingStore?.Set("fromAddress", value); }
        }
#endif
        /// <summary>The IPv4 address of the last detected mail server that relayed the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ipv4
        {
            get { return BackingStore?.Get<string?>("ipv4"); }
            set { BackingStore?.Set("ipv4", value); }
        }
#nullable restore
#else
        public string Ipv4
        {
            get { return BackingStore?.Get<string>("ipv4"); }
            set { BackingStore?.Set("ipv4", value); }
        }
#endif
        /// <summary>The sender email address in the From header, which is visible to email recipients on their email clients. Also known as P2 sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailFromAddress
        {
            get { return BackingStore?.Get<string?>("mailFromAddress"); }
            set { BackingStore?.Set("mailFromAddress", value); }
        }
#nullable restore
#else
        public string MailFromAddress
        {
            get { return BackingStore?.Get<string>("mailFromAddress"); }
            set { BackingStore?.Set("mailFromAddress", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.AnalyzedEmailSenderDetail"/> and sets the default values.
        /// </summary>
        public AnalyzedEmailSenderDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.AnalyzedEmailSenderDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.Security.AnalyzedEmailSenderDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.AnalyzedEmailSenderDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fromAddress", n => { FromAddress = n.GetStringValue(); } },
                { "ipv4", n => { Ipv4 = n.GetStringValue(); } },
                { "mailFromAddress", n => { MailFromAddress = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fromAddress", FromAddress);
            writer.WriteStringValue("ipv4", Ipv4);
            writer.WriteStringValue("mailFromAddress", MailFromAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
