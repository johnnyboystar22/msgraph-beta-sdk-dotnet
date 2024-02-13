// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AdminMicrosoft365Apps : Entity, IParsable {
        /// <summary>A container for tenant-level settings for Microsoft 365 applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public M365AppsInstallationOptions? InstallationOptions {
            get { return BackingStore?.Get<M365AppsInstallationOptions?>("installationOptions"); }
            set { BackingStore?.Set("installationOptions", value); }
        }
#nullable restore
#else
        public M365AppsInstallationOptions InstallationOptions {
            get { return BackingStore?.Get<M365AppsInstallationOptions>("installationOptions"); }
            set { BackingStore?.Set("installationOptions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AdminMicrosoft365Apps"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AdminMicrosoft365Apps CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdminMicrosoft365Apps();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"installationOptions", n => { InstallationOptions = n.GetObjectValue<M365AppsInstallationOptions>(M365AppsInstallationOptions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<M365AppsInstallationOptions>("installationOptions", InstallationOptions);
        }
    }
}
