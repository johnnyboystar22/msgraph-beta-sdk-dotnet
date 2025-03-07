// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains PowerShell script properties to detect a Win32 App
    /// </summary>
    public class Win32LobAppPowerShellScriptRequirement : Microsoft.Graph.Beta.Models.Win32LobAppRequirement, IParsable
    {
        /// <summary>Contains all supported Powershell Script output detection type.</summary>
        public Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptDetectionType? DetectionType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptDetectionType?>("detectionType"); }
            set { BackingStore?.Set("detectionType", value); }
        }
        /// <summary>The unique display name for this rule</summary>
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
        /// <summary>A value indicating whether signature check is enforced</summary>
        public bool? EnforceSignatureCheck
        {
            get { return BackingStore?.Get<bool?>("enforceSignatureCheck"); }
            set { BackingStore?.Set("enforceSignatureCheck", value); }
        }
        /// <summary>A value indicating whether this script should run as 32-bit</summary>
        public bool? RunAs32Bit
        {
            get { return BackingStore?.Get<bool?>("runAs32Bit"); }
            set { BackingStore?.Set("runAs32Bit", value); }
        }
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public Microsoft.Graph.Beta.Models.RunAsAccountType? RunAsAccount
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RunAsAccountType?>("runAsAccount"); }
            set { BackingStore?.Set("runAsAccount", value); }
        }
        /// <summary>The base64 encoded script content to detect Win32 Line of Business (LoB) app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScriptContent
        {
            get { return BackingStore?.Get<string?>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#nullable restore
#else
        public string ScriptContent
        {
            get { return BackingStore?.Get<string>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptRequirement"/> and sets the default values.
        /// </summary>
        public Win32LobAppPowerShellScriptRequirement() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppPowerShellScriptRequirement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptRequirement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptRequirement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptRequirement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "detectionType", n => { DetectionType = n.GetEnumValue<Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptDetectionType>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                { "runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                { "runAsAccount", n => { RunAsAccount = n.GetEnumValue<Microsoft.Graph.Beta.Models.RunAsAccountType>(); } },
                { "scriptContent", n => { ScriptContent = n.GetStringValue(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Win32LobAppPowerShellScriptDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteStringValue("scriptContent", ScriptContent);
        }
    }
}
