// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class SoftwareUpdateStatusSummary : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Number of compliant devices.</summary>
        public int? CompliantDeviceCount
        {
            get { return BackingStore?.Get<int?>("compliantDeviceCount"); }
            set { BackingStore?.Set("compliantDeviceCount", value); }
        }
        /// <summary>Number of compliant users.</summary>
        public int? CompliantUserCount
        {
            get { return BackingStore?.Get<int?>("compliantUserCount"); }
            set { BackingStore?.Set("compliantUserCount", value); }
        }
        /// <summary>Number of conflict devices.</summary>
        public int? ConflictDeviceCount
        {
            get { return BackingStore?.Get<int?>("conflictDeviceCount"); }
            set { BackingStore?.Set("conflictDeviceCount", value); }
        }
        /// <summary>Number of conflict users.</summary>
        public int? ConflictUserCount
        {
            get { return BackingStore?.Get<int?>("conflictUserCount"); }
            set { BackingStore?.Set("conflictUserCount", value); }
        }
        /// <summary>The name of the policy.</summary>
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
        /// <summary>Number of devices had error.</summary>
        public int? ErrorDeviceCount
        {
            get { return BackingStore?.Get<int?>("errorDeviceCount"); }
            set { BackingStore?.Set("errorDeviceCount", value); }
        }
        /// <summary>Number of users had error.</summary>
        public int? ErrorUserCount
        {
            get { return BackingStore?.Get<int?>("errorUserCount"); }
            set { BackingStore?.Set("errorUserCount", value); }
        }
        /// <summary>Number of non compliant devices.</summary>
        public int? NonCompliantDeviceCount
        {
            get { return BackingStore?.Get<int?>("nonCompliantDeviceCount"); }
            set { BackingStore?.Set("nonCompliantDeviceCount", value); }
        }
        /// <summary>Number of non compliant users.</summary>
        public int? NonCompliantUserCount
        {
            get { return BackingStore?.Get<int?>("nonCompliantUserCount"); }
            set { BackingStore?.Set("nonCompliantUserCount", value); }
        }
        /// <summary>Number of not applicable devices.</summary>
        public int? NotApplicableDeviceCount
        {
            get { return BackingStore?.Get<int?>("notApplicableDeviceCount"); }
            set { BackingStore?.Set("notApplicableDeviceCount", value); }
        }
        /// <summary>Number of not applicable users.</summary>
        public int? NotApplicableUserCount
        {
            get { return BackingStore?.Get<int?>("notApplicableUserCount"); }
            set { BackingStore?.Set("notApplicableUserCount", value); }
        }
        /// <summary>Number of remediated devices.</summary>
        public int? RemediatedDeviceCount
        {
            get { return BackingStore?.Get<int?>("remediatedDeviceCount"); }
            set { BackingStore?.Set("remediatedDeviceCount", value); }
        }
        /// <summary>Number of remediated users.</summary>
        public int? RemediatedUserCount
        {
            get { return BackingStore?.Get<int?>("remediatedUserCount"); }
            set { BackingStore?.Set("remediatedUserCount", value); }
        }
        /// <summary>Number of unknown devices.</summary>
        public int? UnknownDeviceCount
        {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>Number of unknown users.</summary>
        public int? UnknownUserCount
        {
            get { return BackingStore?.Get<int?>("unknownUserCount"); }
            set { BackingStore?.Set("unknownUserCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                { "compliantUserCount", n => { CompliantUserCount = n.GetIntValue(); } },
                { "conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                { "conflictUserCount", n => { ConflictUserCount = n.GetIntValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                { "errorUserCount", n => { ErrorUserCount = n.GetIntValue(); } },
                { "nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                { "nonCompliantUserCount", n => { NonCompliantUserCount = n.GetIntValue(); } },
                { "notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                { "notApplicableUserCount", n => { NotApplicableUserCount = n.GetIntValue(); } },
                { "remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                { "remediatedUserCount", n => { RemediatedUserCount = n.GetIntValue(); } },
                { "unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
                { "unknownUserCount", n => { UnknownUserCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("compliantUserCount", CompliantUserCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("conflictUserCount", ConflictUserCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("nonCompliantUserCount", NonCompliantUserCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notApplicableUserCount", NotApplicableUserCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("remediatedUserCount", RemediatedUserCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteIntValue("unknownUserCount", UnknownUserCount);
        }
    }
}
