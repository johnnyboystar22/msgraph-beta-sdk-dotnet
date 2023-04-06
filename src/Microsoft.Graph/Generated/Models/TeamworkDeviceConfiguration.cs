using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDeviceConfiguration : Entity, IParsable {
        /// <summary>The camera configuration. Applicable only for Microsoft Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkCameraConfiguration? CameraConfiguration {
            get { return BackingStore?.Get<TeamworkCameraConfiguration?>("cameraConfiguration"); }
            set { BackingStore?.Set("cameraConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkCameraConfiguration CameraConfiguration {
            get { return BackingStore?.Get<TeamworkCameraConfiguration>("cameraConfiguration"); }
            set { BackingStore?.Set("cameraConfiguration", value); }
        }
#endif
        /// <summary>Identity of the user who created the device configuration document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device configuration document was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The display configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDisplayConfiguration? DisplayConfiguration {
            get { return BackingStore?.Get<TeamworkDisplayConfiguration?>("displayConfiguration"); }
            set { BackingStore?.Set("displayConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkDisplayConfiguration DisplayConfiguration {
            get { return BackingStore?.Get<TeamworkDisplayConfiguration>("displayConfiguration"); }
            set { BackingStore?.Set("displayConfiguration", value); }
        }
#endif
        /// <summary>The hardware configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkHardwareConfiguration? HardwareConfiguration {
            get { return BackingStore?.Get<TeamworkHardwareConfiguration?>("hardwareConfiguration"); }
            set { BackingStore?.Set("hardwareConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkHardwareConfiguration HardwareConfiguration {
            get { return BackingStore?.Get<TeamworkHardwareConfiguration>("hardwareConfiguration"); }
            set { BackingStore?.Set("hardwareConfiguration", value); }
        }
#endif
        /// <summary>Identity of the user who last modified the device configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device configuration was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The microphone configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkMicrophoneConfiguration? MicrophoneConfiguration {
            get { return BackingStore?.Get<TeamworkMicrophoneConfiguration?>("microphoneConfiguration"); }
            set { BackingStore?.Set("microphoneConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkMicrophoneConfiguration MicrophoneConfiguration {
            get { return BackingStore?.Get<TeamworkMicrophoneConfiguration>("microphoneConfiguration"); }
            set { BackingStore?.Set("microphoneConfiguration", value); }
        }
#endif
        /// <summary>Information related to software versions for the device, such as firmware, operating system, Teams client, and admin agent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDeviceSoftwareVersions? SoftwareVersions {
            get { return BackingStore?.Get<TeamworkDeviceSoftwareVersions?>("softwareVersions"); }
            set { BackingStore?.Set("softwareVersions", value); }
        }
#nullable restore
#else
        public TeamworkDeviceSoftwareVersions SoftwareVersions {
            get { return BackingStore?.Get<TeamworkDeviceSoftwareVersions>("softwareVersions"); }
            set { BackingStore?.Set("softwareVersions", value); }
        }
#endif
        /// <summary>The speaker configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkSpeakerConfiguration? SpeakerConfiguration {
            get { return BackingStore?.Get<TeamworkSpeakerConfiguration?>("speakerConfiguration"); }
            set { BackingStore?.Set("speakerConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkSpeakerConfiguration SpeakerConfiguration {
            get { return BackingStore?.Get<TeamworkSpeakerConfiguration>("speakerConfiguration"); }
            set { BackingStore?.Set("speakerConfiguration", value); }
        }
#endif
        /// <summary>The system configuration. Not applicable for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkSystemConfiguration? SystemConfiguration {
            get { return BackingStore?.Get<TeamworkSystemConfiguration?>("systemConfiguration"); }
            set { BackingStore?.Set("systemConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkSystemConfiguration SystemConfiguration {
            get { return BackingStore?.Get<TeamworkSystemConfiguration>("systemConfiguration"); }
            set { BackingStore?.Set("systemConfiguration", value); }
        }
#endif
        /// <summary>The Teams client configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkTeamsClientConfiguration? TeamsClientConfiguration {
            get { return BackingStore?.Get<TeamworkTeamsClientConfiguration?>("teamsClientConfiguration"); }
            set { BackingStore?.Set("teamsClientConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkTeamsClientConfiguration TeamsClientConfiguration {
            get { return BackingStore?.Get<TeamworkTeamsClientConfiguration>("teamsClientConfiguration"); }
            set { BackingStore?.Set("teamsClientConfiguration", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamworkDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cameraConfiguration", n => { CameraConfiguration = n.GetObjectValue<TeamworkCameraConfiguration>(TeamworkCameraConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayConfiguration", n => { DisplayConfiguration = n.GetObjectValue<TeamworkDisplayConfiguration>(TeamworkDisplayConfiguration.CreateFromDiscriminatorValue); } },
                {"hardwareConfiguration", n => { HardwareConfiguration = n.GetObjectValue<TeamworkHardwareConfiguration>(TeamworkHardwareConfiguration.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"microphoneConfiguration", n => { MicrophoneConfiguration = n.GetObjectValue<TeamworkMicrophoneConfiguration>(TeamworkMicrophoneConfiguration.CreateFromDiscriminatorValue); } },
                {"softwareVersions", n => { SoftwareVersions = n.GetObjectValue<TeamworkDeviceSoftwareVersions>(TeamworkDeviceSoftwareVersions.CreateFromDiscriminatorValue); } },
                {"speakerConfiguration", n => { SpeakerConfiguration = n.GetObjectValue<TeamworkSpeakerConfiguration>(TeamworkSpeakerConfiguration.CreateFromDiscriminatorValue); } },
                {"systemConfiguration", n => { SystemConfiguration = n.GetObjectValue<TeamworkSystemConfiguration>(TeamworkSystemConfiguration.CreateFromDiscriminatorValue); } },
                {"teamsClientConfiguration", n => { TeamsClientConfiguration = n.GetObjectValue<TeamworkTeamsClientConfiguration>(TeamworkTeamsClientConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkCameraConfiguration>("cameraConfiguration", CameraConfiguration);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<TeamworkDisplayConfiguration>("displayConfiguration", DisplayConfiguration);
            writer.WriteObjectValue<TeamworkHardwareConfiguration>("hardwareConfiguration", HardwareConfiguration);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<TeamworkMicrophoneConfiguration>("microphoneConfiguration", MicrophoneConfiguration);
            writer.WriteObjectValue<TeamworkDeviceSoftwareVersions>("softwareVersions", SoftwareVersions);
            writer.WriteObjectValue<TeamworkSpeakerConfiguration>("speakerConfiguration", SpeakerConfiguration);
            writer.WriteObjectValue<TeamworkSystemConfiguration>("systemConfiguration", SystemConfiguration);
            writer.WriteObjectValue<TeamworkTeamsClientConfiguration>("teamsClientConfiguration", TeamsClientConfiguration);
        }
    }
}
