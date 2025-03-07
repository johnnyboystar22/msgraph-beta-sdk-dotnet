// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UnifiedRoleManagementPolicyAuthenticationContextRule : Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The value of the authentication context claim.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClaimValue
        {
            get { return BackingStore?.Get<string?>("claimValue"); }
            set { BackingStore?.Set("claimValue", value); }
        }
#nullable restore
#else
        public string ClaimValue
        {
            get { return BackingStore?.Get<string>("claimValue"); }
            set { BackingStore?.Set("claimValue", value); }
        }
#endif
        /// <summary>Whether this rule is enabled.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyAuthenticationContextRule"/> and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyAuthenticationContextRule() : base()
        {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyAuthenticationContextRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyAuthenticationContextRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyAuthenticationContextRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyAuthenticationContextRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "claimValue", n => { ClaimValue = n.GetStringValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
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
            writer.WriteStringValue("claimValue", ClaimValue);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
