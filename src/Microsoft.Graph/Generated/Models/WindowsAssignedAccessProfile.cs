using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Assigned Access profile for Windows.
    /// </summary>
    public class WindowsAssignedAccessProfile : Entity, IParsable {
        /// <summary>These are the only Windows Store Apps that will be available to launch from the Start menu.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AppUserModelIds {
            get { return BackingStore?.Get<List<string>?>("appUserModelIds"); }
            set { BackingStore?.Set("appUserModelIds", value); }
        }
#nullable restore
#else
        public List<string> AppUserModelIds {
            get { return BackingStore?.Get<List<string>>("appUserModelIds"); }
            set { BackingStore?.Set("appUserModelIds", value); }
        }
#endif
        /// <summary>These are the paths of the Desktop Apps that will be available on the Start menu and the only apps the user will be able to launch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DesktopAppPaths {
            get { return BackingStore?.Get<List<string>?>("desktopAppPaths"); }
            set { BackingStore?.Set("desktopAppPaths", value); }
        }
#nullable restore
#else
        public List<string> DesktopAppPaths {
            get { return BackingStore?.Get<List<string>>("desktopAppPaths"); }
            set { BackingStore?.Set("desktopAppPaths", value); }
        }
#endif
        /// <summary>This is a friendly name used to identify a group of applications, the layout of these apps on the start menu and the users to whom this kiosk configuration is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileName {
            get { return BackingStore?.Get<string?>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#nullable restore
#else
        public string ProfileName {
            get { return BackingStore?.Get<string>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#endif
        /// <summary>This setting allows the admin to specify whether the Task Bar is shown or not.</summary>
        public bool? ShowTaskBar {
            get { return BackingStore?.Get<bool?>("showTaskBar"); }
            set { BackingStore?.Set("showTaskBar", value); }
        }
        /// <summary>Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]?>("startMenuLayoutXml"); }
            set { BackingStore?.Set("startMenuLayoutXml", value); }
        }
#nullable restore
#else
        public byte[] StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]>("startMenuLayoutXml"); }
            set { BackingStore?.Set("startMenuLayoutXml", value); }
        }
#endif
        /// <summary>The user accounts that will be locked to this kiosk configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserAccounts {
            get { return BackingStore?.Get<List<string>?>("userAccounts"); }
            set { BackingStore?.Set("userAccounts", value); }
        }
#nullable restore
#else
        public List<string> UserAccounts {
            get { return BackingStore?.Get<List<string>>("userAccounts"); }
            set { BackingStore?.Set("userAccounts", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsAssignedAccessProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAssignedAccessProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appUserModelIds", n => { AppUserModelIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"desktopAppPaths", n => { DesktopAppPaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"profileName", n => { ProfileName = n.GetStringValue(); } },
                {"showTaskBar", n => { ShowTaskBar = n.GetBoolValue(); } },
                {"startMenuLayoutXml", n => { StartMenuLayoutXml = n.GetByteArrayValue(); } },
                {"userAccounts", n => { UserAccounts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("appUserModelIds", AppUserModelIds);
            writer.WriteCollectionOfPrimitiveValues<string>("desktopAppPaths", DesktopAppPaths);
            writer.WriteStringValue("profileName", ProfileName);
            writer.WriteBoolValue("showTaskBar", ShowTaskBar);
            writer.WriteByteArrayValue("startMenuLayoutXml", StartMenuLayoutXml);
            writer.WriteCollectionOfPrimitiveValues<string>("userAccounts", UserAccounts);
        }
    }
}
