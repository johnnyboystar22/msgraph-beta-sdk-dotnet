// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class BranchSite : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines the maximum allowed Mbps (megabits per second) bandwidth from a branch site. The possible values are:250,500,750,1000.</summary>
        public long? BandwidthCapacity
        {
            get { return BackingStore?.Get<long?>("bandwidthCapacity"); }
            set { BackingStore?.Set("bandwidthCapacity", value); }
        }
        /// <summary>Specifies the connectivity details of all device links associated with a branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration? ConnectivityConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration?>("connectivityConfiguration"); }
            set { BackingStore?.Set("connectivityConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration ConnectivityConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration>("connectivityConfiguration"); }
            set { BackingStore?.Set("connectivityConfiguration", value); }
        }
#endif
        /// <summary>Determines the branch site status. The possible values are: pending, connected, inactive, error.</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.ConnectivityState? ConnectivityState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ConnectivityState?>("connectivityState"); }
            set { BackingStore?.Set("connectivityState", value); }
        }
        /// <summary>The branch site is created in the specified country. DO NOT USE.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country
        {
            get { return BackingStore?.Get<string?>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#nullable restore
#else
        public string Country
        {
            get { return BackingStore?.Get<string>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#endif
        /// <summary>Each unique CPE device associated with a branch is specified. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink>? DeviceLinks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink>?>("deviceLinks"); }
            set { BackingStore?.Set("deviceLinks", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink> DeviceLinks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink>>("deviceLinks"); }
            set { BackingStore?.Set("deviceLinks", value); }
        }
#endif
        /// <summary>Each forwarding profile associated with a branch site is specified. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile>? ForwardingProfiles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile>?>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile> ForwardingProfiles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile>>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#endif
        /// <summary>last modified time.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The region property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.Region? Region
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Region?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
        /// <summary>The branch version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Networkaccess.BranchSite"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Networkaccess.BranchSite CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Networkaccess.BranchSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bandwidthCapacity", n => { BandwidthCapacity = n.GetLongValue(); } },
                { "connectivityConfiguration", n => { ConnectivityConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration>(Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration.CreateFromDiscriminatorValue); } },
                { "connectivityState", n => { ConnectivityState = n.GetEnumValue<Microsoft.Graph.Beta.Models.Networkaccess.ConnectivityState>(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "deviceLinks", n => { DeviceLinks = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink>(Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink.CreateFromDiscriminatorValue)?.ToList(); } },
                { "forwardingProfiles", n => { ForwardingProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile>(Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "region", n => { Region = n.GetEnumValue<Microsoft.Graph.Beta.Models.Networkaccess.Region>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteLongValue("bandwidthCapacity", BandwidthCapacity);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.BranchConnectivityConfiguration>("connectivityConfiguration", ConnectivityConfiguration);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Networkaccess.ConnectivityState>("connectivityState", ConnectivityState);
            writer.WriteStringValue("country", Country);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink>("deviceLinks", DeviceLinks);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Networkaccess.ForwardingProfile>("forwardingProfiles", ForwardingProfiles);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Networkaccess.Region>("region", Region);
            writer.WriteStringValue("version", Version);
        }
    }
}
