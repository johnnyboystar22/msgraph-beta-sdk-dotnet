// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class M365AppsInstallationOptions : Entity, IParsable {
        /// <summary>The appsForMac property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppsInstallationOptionsForMac? AppsForMac {
            get { return BackingStore?.Get<AppsInstallationOptionsForMac?>("appsForMac"); }
            set { BackingStore?.Set("appsForMac", value); }
        }
#nullable restore
#else
        public AppsInstallationOptionsForMac AppsForMac {
            get { return BackingStore?.Get<AppsInstallationOptionsForMac>("appsForMac"); }
            set { BackingStore?.Set("appsForMac", value); }
        }
#endif
        /// <summary>The appsForWindows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppsInstallationOptionsForWindows? AppsForWindows {
            get { return BackingStore?.Get<AppsInstallationOptionsForWindows?>("appsForWindows"); }
            set { BackingStore?.Set("appsForWindows", value); }
        }
#nullable restore
#else
        public AppsInstallationOptionsForWindows AppsForWindows {
            get { return BackingStore?.Get<AppsInstallationOptionsForWindows>("appsForWindows"); }
            set { BackingStore?.Set("appsForWindows", value); }
        }
#endif
        /// <summary>The updateChannel property</summary>
        public AppsUpdateChannelType? UpdateChannel {
            get { return BackingStore?.Get<AppsUpdateChannelType?>("updateChannel"); }
            set { BackingStore?.Set("updateChannel", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="M365AppsInstallationOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new M365AppsInstallationOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new M365AppsInstallationOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appsForMac", n => { AppsForMac = n.GetObjectValue<AppsInstallationOptionsForMac>(AppsInstallationOptionsForMac.CreateFromDiscriminatorValue); } },
                {"appsForWindows", n => { AppsForWindows = n.GetObjectValue<AppsInstallationOptionsForWindows>(AppsInstallationOptionsForWindows.CreateFromDiscriminatorValue); } },
                {"updateChannel", n => { UpdateChannel = n.GetEnumValue<AppsUpdateChannelType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AppsInstallationOptionsForMac>("appsForMac", AppsForMac);
            writer.WriteObjectValue<AppsInstallationOptionsForWindows>("appsForWindows", AppsForWindows);
            writer.WriteEnumValue<AppsUpdateChannelType>("updateChannel", UpdateChannel);
        }
    }
}
