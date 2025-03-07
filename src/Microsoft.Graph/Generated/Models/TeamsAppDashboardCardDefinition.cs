// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class TeamsAppDashboardCardDefinition : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configuration for the source of the card content. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource? ContentSource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource?>("contentSource"); }
            set { BackingStore?.Set("contentSource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource ContentSource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource>("contentSource"); }
            set { BackingStore?.Set("contentSource", value); }
        }
#endif
        /// <summary>The size of the card. The possible values are: medium, large, unknownFutureValue. Required.</summary>
        public Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSize? DefaultSize
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSize?>("defaultSize"); }
            set { BackingStore?.Set("defaultSize", value); }
        }
        /// <summary>The description for the card. Required.</summary>
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
        /// <summary>The name of the card. Required.</summary>
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
        /// <summary>Configuration for the display of the icon in the card picker. If neither this nor any of its properties (iconUrl and officeUIFabricIconName) are specified, the color icon of the app is used. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon? Icon
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon?>("icon"); }
            set { BackingStore?.Set("icon", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon Icon
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon>("icon"); }
            set { BackingStore?.Set("icon", value); }
        }
#endif
        /// <summary>ID for the group in the card picker. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PickerGroupId
        {
            get { return BackingStore?.Get<string?>("pickerGroupId"); }
            set { BackingStore?.Set("pickerGroupId", value); }
        }
#nullable restore
#else
        public string PickerGroupId
        {
            get { return BackingStore?.Get<string>("pickerGroupId"); }
            set { BackingStore?.Set("pickerGroupId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TeamsAppDashboardCardDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.TeamsAppDashboardCardDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.TeamsAppDashboardCardDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contentSource", n => { ContentSource = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource>(Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource.CreateFromDiscriminatorValue); } },
                { "defaultSize", n => { DefaultSize = n.GetEnumValue<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSize>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "icon", n => { Icon = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon>(Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon.CreateFromDiscriminatorValue); } },
                { "pickerGroupId", n => { PickerGroupId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource>("contentSource", ContentSource);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSize>("defaultSize", DefaultSize);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDashboardCardIcon>("icon", Icon);
            writer.WriteStringValue("pickerGroupId", PickerGroupId);
        }
    }
}
