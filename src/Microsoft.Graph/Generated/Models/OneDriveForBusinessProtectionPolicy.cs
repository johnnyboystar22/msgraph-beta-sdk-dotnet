// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class OneDriveForBusinessProtectionPolicy : Microsoft.Graph.Beta.Models.ProtectionPolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains the details of the Onedrive for Business protection rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DriveProtectionRule>? DriveInclusionRules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DriveProtectionRule>?>("driveInclusionRules"); }
            set { BackingStore?.Set("driveInclusionRules", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DriveProtectionRule> DriveInclusionRules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DriveProtectionRule>>("driveInclusionRules"); }
            set { BackingStore?.Set("driveInclusionRules", value); }
        }
#endif
        /// <summary>Contains the protection units associated with a  OneDrive for Business protection policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DriveProtectionUnit>? DriveProtectionUnits
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DriveProtectionUnit>?>("driveProtectionUnits"); }
            set { BackingStore?.Set("driveProtectionUnits", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DriveProtectionUnit> DriveProtectionUnits
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DriveProtectionUnit>>("driveProtectionUnits"); }
            set { BackingStore?.Set("driveProtectionUnits", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.OneDriveForBusinessProtectionPolicy"/> and sets the default values.
        /// </summary>
        public OneDriveForBusinessProtectionPolicy() : base()
        {
            OdataType = "#microsoft.graph.oneDriveForBusinessProtectionPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.OneDriveForBusinessProtectionPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.OneDriveForBusinessProtectionPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.OneDriveForBusinessProtectionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "driveInclusionRules", n => { DriveInclusionRules = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DriveProtectionRule>(Microsoft.Graph.Beta.Models.DriveProtectionRule.CreateFromDiscriminatorValue)?.ToList(); } },
                { "driveProtectionUnits", n => { DriveProtectionUnits = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DriveProtectionUnit>(Microsoft.Graph.Beta.Models.DriveProtectionUnit.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DriveProtectionRule>("driveInclusionRules", DriveInclusionRules);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DriveProtectionUnit>("driveProtectionUnits", DriveProtectionUnits);
        }
    }
}
