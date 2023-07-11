using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class BranchSite : Entity, IParsable {
        /// <summary>Determines the maximum allowed Mbps (megabits per second) bandwidth from a branch site. The possible values are:250,500,750,1000.</summary>
        public long? BandwidthCapacity {
            get { return BackingStore?.Get<long?>("bandwidthCapacity"); }
            set { BackingStore?.Set("bandwidthCapacity", value); }
        }
        /// <summary>Determines the branch site status. The possible values are: pending, connected, inactive, error.</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.ConnectivityState? ConnectivityState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ConnectivityState?>("connectivityState"); }
            set { BackingStore?.Set("connectivityState", value); }
        }
        /// <summary>The branch site is created in the specified country.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country {
            get { return BackingStore?.Get<string?>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#nullable restore
#else
        public string Country {
            get { return BackingStore?.Get<string>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#endif
        /// <summary>Each unique CPE device associated with a branch is specified. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceLink>? DeviceLinks {
            get { return BackingStore?.Get<List<DeviceLink>?>("deviceLinks"); }
            set { BackingStore?.Set("deviceLinks", value); }
        }
#nullable restore
#else
        public List<DeviceLink> DeviceLinks {
            get { return BackingStore?.Get<List<DeviceLink>>("deviceLinks"); }
            set { BackingStore?.Set("deviceLinks", value); }
        }
#endif
        /// <summary>Each forwarding profile associated with a branch site is specified. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ForwardingProfile>? ForwardingProfiles {
            get { return BackingStore?.Get<List<ForwardingProfile>?>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#nullable restore
#else
        public List<ForwardingProfile> ForwardingProfiles {
            get { return BackingStore?.Get<List<ForwardingProfile>>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#endif
        /// <summary>last modified time.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The region property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.Region? Region {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Region?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
        /// <summary>The branch version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BranchSite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BranchSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bandwidthCapacity", n => { BandwidthCapacity = n.GetLongValue(); } },
                {"connectivityState", n => { ConnectivityState = n.GetEnumValue<ConnectivityState>(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"deviceLinks", n => { DeviceLinks = n.GetCollectionOfObjectValues<DeviceLink>(DeviceLink.CreateFromDiscriminatorValue)?.ToList(); } },
                {"forwardingProfiles", n => { ForwardingProfiles = n.GetCollectionOfObjectValues<ForwardingProfile>(ForwardingProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"region", n => { Region = n.GetEnumValue<Region>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("bandwidthCapacity", BandwidthCapacity);
            writer.WriteEnumValue<ConnectivityState>("connectivityState", ConnectivityState);
            writer.WriteStringValue("country", Country);
            writer.WriteCollectionOfObjectValues<DeviceLink>("deviceLinks", DeviceLinks);
            writer.WriteCollectionOfObjectValues<ForwardingProfile>("forwardingProfiles", ForwardingProfiles);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<Region>("region", Region);
            writer.WriteStringValue("version", Version);
        }
    }
}
