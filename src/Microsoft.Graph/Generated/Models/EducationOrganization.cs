// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EducationOrganization : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Organization description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Organization display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Where this user was created from. Possible values are: sis, lms, or manual.</summary>
        public Microsoft.Graph.Beta.Models.EducationExternalSource? ExternalSource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EducationExternalSource?>("externalSource"); }
            set { BackingStore?.Set("externalSource", value); }
        }
        /// <summary>The externalSourceDetail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalSourceDetail
        {
            get { return BackingStore?.Get<string?>("externalSourceDetail"); }
            set { BackingStore?.Set("externalSourceDetail", value); }
        }
#nullable restore
#else
        public string ExternalSourceDetail
        {
            get { return BackingStore?.Get<string>("externalSourceDetail"); }
            set { BackingStore?.Set("externalSourceDetail", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EducationOrganization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.EducationOrganization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.educationSchool" => new Microsoft.Graph.Beta.Models.EducationSchool(),
                _ => new Microsoft.Graph.Beta.Models.EducationOrganization(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "externalSource", n => { ExternalSource = n.GetEnumValue<Microsoft.Graph.Beta.Models.EducationExternalSource>(); } },
                { "externalSourceDetail", n => { ExternalSourceDetail = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.EducationExternalSource>("externalSource", ExternalSource);
            writer.WriteStringValue("externalSourceDetail", ExternalSourceDetail);
        }
    }
}
