// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesAddMembersById
{
    #pragma warning disable CS1591
    public class AddMembersByIdPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The ids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ids
        {
            get { return BackingStore?.Get<List<string>?>("ids"); }
            set { BackingStore?.Set("ids", value); }
        }
#nullable restore
#else
        public List<string> Ids
        {
            get { return BackingStore?.Get<List<string>>("ids"); }
            set { BackingStore?.Set("ids", value); }
        }
#endif
        /// <summary>The memberEntityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberEntityType
        {
            get { return BackingStore?.Get<string?>("memberEntityType"); }
            set { BackingStore?.Set("memberEntityType", value); }
        }
#nullable restore
#else
        public string MemberEntityType
        {
            get { return BackingStore?.Get<string>("memberEntityType"); }
            set { BackingStore?.Set("memberEntityType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesAddMembersById.AddMembersByIdPostRequestBody"/> and sets the default values.
        /// </summary>
        public AddMembersByIdPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesAddMembersById.AddMembersByIdPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesAddMembersById.AddMembersByIdPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesAddMembersById.AddMembersByIdPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ids", n => { Ids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "memberEntityType", n => { MemberEntityType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
            writer.WriteStringValue("memberEntityType", MemberEntityType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
