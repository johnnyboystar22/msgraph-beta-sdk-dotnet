// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class WorkbookRangeBorder : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>HTML color code representing the color of the border line, of the form #RRGGBB (for example &apos;FFA500&apos;) or as a named HTML color (for example &apos;orange&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color
        {
            get { return BackingStore?.Get<string?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#nullable restore
#else
        public string Color
        {
            get { return BackingStore?.Get<string>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#endif
        /// <summary>Constant value that indicates the specific side of the border. Possible values are: EdgeTop, EdgeBottom, EdgeLeft, EdgeRight, InsideVertical, InsideHorizontal, DiagonalDown, DiagonalUp. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SideIndex
        {
            get { return BackingStore?.Get<string?>("sideIndex"); }
            set { BackingStore?.Set("sideIndex", value); }
        }
#nullable restore
#else
        public string SideIndex
        {
            get { return BackingStore?.Get<string>("sideIndex"); }
            set { BackingStore?.Set("sideIndex", value); }
        }
#endif
        /// <summary>One of the constants of line style specifying the line style for the border. Possible values are: None, Continuous, Dash, DashDot, DashDotDot, Dot, Double, SlantDashDot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Style
        {
            get { return BackingStore?.Get<string?>("style"); }
            set { BackingStore?.Set("style", value); }
        }
#nullable restore
#else
        public string Style
        {
            get { return BackingStore?.Get<string>("style"); }
            set { BackingStore?.Set("style", value); }
        }
#endif
        /// <summary>Specifies the weight of the border around a range. Possible values are: Hairline, Thin, Medium, Thick.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Weight
        {
            get { return BackingStore?.Get<string?>("weight"); }
            set { BackingStore?.Set("weight", value); }
        }
#nullable restore
#else
        public string Weight
        {
            get { return BackingStore?.Get<string>("weight"); }
            set { BackingStore?.Set("weight", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WorkbookRangeBorder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WorkbookRangeBorder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WorkbookRangeBorder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "color", n => { Color = n.GetStringValue(); } },
                { "sideIndex", n => { SideIndex = n.GetStringValue(); } },
                { "style", n => { Style = n.GetStringValue(); } },
                { "weight", n => { Weight = n.GetStringValue(); } },
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
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("sideIndex", SideIndex);
            writer.WriteStringValue("style", Style);
            writer.WriteStringValue("weight", Weight);
        }
    }
}
