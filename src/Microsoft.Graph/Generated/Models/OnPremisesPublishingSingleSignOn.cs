// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class OnPremisesPublishingSingleSignOn : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The Kerberos Constrained Delegation settings for applications that use Integrated Window Authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.KerberosSignOnSettings? KerberosSignOnSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KerberosSignOnSettings?>("kerberosSignOnSettings"); }
            set { BackingStore?.Set("kerberosSignOnSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.KerberosSignOnSettings KerberosSignOnSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KerberosSignOnSettings>("kerberosSignOnSettings"); }
            set { BackingStore?.Set("kerberosSignOnSettings", value); }
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
        /// <summary>The preferred single-sign on mode for the application. Possible values are: none, onPremisesKerberos, aadHeaderBased,pingHeaderBased, oAuthToken.</summary>
        public Microsoft.Graph.Beta.Models.SingleSignOnMode? SingleSignOnMode
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnMode?>("singleSignOnMode"); }
            set { BackingStore?.Set("singleSignOnMode", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.OnPremisesPublishingSingleSignOn"/> and sets the default values.
        /// </summary>
        public OnPremisesPublishingSingleSignOn()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.OnPremisesPublishingSingleSignOn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.OnPremisesPublishingSingleSignOn CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.OnPremisesPublishingSingleSignOn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "kerberosSignOnSettings", n => { KerberosSignOnSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.KerberosSignOnSettings>(Microsoft.Graph.Beta.Models.KerberosSignOnSettings.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "singleSignOnMode", n => { SingleSignOnMode = n.GetEnumValue<Microsoft.Graph.Beta.Models.SingleSignOnMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.KerberosSignOnSettings>("kerberosSignOnSettings", KerberosSignOnSettings);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SingleSignOnMode>("singleSignOnMode", SingleSignOnMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
