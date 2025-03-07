// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.PrivilegedSignupStatus.CompleteSetup
{
    #pragma warning disable CS1591
    public class CompleteSetupPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The tenantSetupInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TenantSetupInfo? TenantSetupInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantSetupInfo?>("tenantSetupInfo"); }
            set { BackingStore?.Set("tenantSetupInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TenantSetupInfo TenantSetupInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantSetupInfo>("tenantSetupInfo"); }
            set { BackingStore?.Set("tenantSetupInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.PrivilegedSignupStatus.CompleteSetup.CompleteSetupPostRequestBody"/> and sets the default values.
        /// </summary>
        public CompleteSetupPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.PrivilegedSignupStatus.CompleteSetup.CompleteSetupPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.PrivilegedSignupStatus.CompleteSetup.CompleteSetupPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.PrivilegedSignupStatus.CompleteSetup.CompleteSetupPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "tenantSetupInfo", n => { TenantSetupInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantSetupInfo>(Microsoft.Graph.Beta.Models.TenantSetupInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantSetupInfo>("tenantSetupInfo", TenantSetupInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
