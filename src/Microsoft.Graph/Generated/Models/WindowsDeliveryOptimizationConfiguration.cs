using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows Delivery Optimization configuration
    /// </summary>
    public class WindowsDeliveryOptimizationConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specifies number of seconds to delay an HTTP source in a background download that is allowed to use peer-to-peer. Valid values 0 to 4294967295</summary>
        public long? BackgroundDownloadFromHttpDelayInSeconds {
            get { return BackingStore?.Get<long?>("backgroundDownloadFromHttpDelayInSeconds"); }
            set { BackingStore?.Set("backgroundDownloadFromHttpDelayInSeconds", value); }
        }
        /// <summary>Specifies foreground and background bandwidth usage using percentages, absolutes, or hours.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeliveryOptimizationBandwidth? BandwidthMode {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidth?>("bandwidthMode"); }
            set { BackingStore?.Set("bandwidthMode", value); }
        }
#nullable restore
#else
        public DeliveryOptimizationBandwidth BandwidthMode {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidth>("bandwidthMode"); }
            set { BackingStore?.Set("bandwidthMode", value); }
        }
#endif
        /// <summary>Specifies number of seconds to delay a fall back from cache servers to an HTTP source for a background download. Valid values 0 to 2592000.</summary>
        public int? CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds {
            get { return BackingStore?.Get<int?>("cacheServerBackgroundDownloadFallbackToHttpDelayInSeconds"); }
            set { BackingStore?.Set("cacheServerBackgroundDownloadFallbackToHttpDelayInSeconds", value); }
        }
        /// <summary>Specifies number of seconds to delay a fall back from cache servers to an HTTP source for a foreground download. Valid values 0 to 2592000.​</summary>
        public int? CacheServerForegroundDownloadFallbackToHttpDelayInSeconds {
            get { return BackingStore?.Get<int?>("cacheServerForegroundDownloadFallbackToHttpDelayInSeconds"); }
            set { BackingStore?.Set("cacheServerForegroundDownloadFallbackToHttpDelayInSeconds", value); }
        }
        /// <summary>Specifies cache servers host names.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CacheServerHostNames {
            get { return BackingStore?.Get<List<string>?>("cacheServerHostNames"); }
            set { BackingStore?.Set("cacheServerHostNames", value); }
        }
#nullable restore
#else
        public List<string> CacheServerHostNames {
            get { return BackingStore?.Get<List<string>>("cacheServerHostNames"); }
            set { BackingStore?.Set("cacheServerHostNames", value); }
        }
#endif
        /// <summary>Delivery optimization mode for peer distribution</summary>
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode {
            get { return BackingStore?.Get<WindowsDeliveryOptimizationMode?>("deliveryOptimizationMode"); }
            set { BackingStore?.Set("deliveryOptimizationMode", value); }
        }
        /// <summary>Specifies number of seconds to delay an HTTP source in a foreground download that is allowed to use peer-to-peer (0-86400). Valid values 0 to 86400</summary>
        public long? ForegroundDownloadFromHttpDelayInSeconds {
            get { return BackingStore?.Get<long?>("foregroundDownloadFromHttpDelayInSeconds"); }
            set { BackingStore?.Set("foregroundDownloadFromHttpDelayInSeconds", value); }
        }
        /// <summary>Specifies to restrict peer selection to a specfic source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeliveryOptimizationGroupIdSource? GroupIdSource {
            get { return BackingStore?.Get<DeliveryOptimizationGroupIdSource?>("groupIdSource"); }
            set { BackingStore?.Set("groupIdSource", value); }
        }
#nullable restore
#else
        public DeliveryOptimizationGroupIdSource GroupIdSource {
            get { return BackingStore?.Get<DeliveryOptimizationGroupIdSource>("groupIdSource"); }
            set { BackingStore?.Set("groupIdSource", value); }
        }
#endif
        /// <summary>Specifies the maximum time in days that each file is held in the Delivery Optimization cache after downloading successfully (0-3650). Valid values 0 to 3650</summary>
        public int? MaximumCacheAgeInDays {
            get { return BackingStore?.Get<int?>("maximumCacheAgeInDays"); }
            set { BackingStore?.Set("maximumCacheAgeInDays", value); }
        }
        /// <summary>Specifies the maximum cache size that Delivery Optimization either as a percentage or in GB.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeliveryOptimizationMaxCacheSize? MaximumCacheSize {
            get { return BackingStore?.Get<DeliveryOptimizationMaxCacheSize?>("maximumCacheSize"); }
            set { BackingStore?.Set("maximumCacheSize", value); }
        }
#nullable restore
#else
        public DeliveryOptimizationMaxCacheSize MaximumCacheSize {
            get { return BackingStore?.Get<DeliveryOptimizationMaxCacheSize>("maximumCacheSize"); }
            set { BackingStore?.Set("maximumCacheSize", value); }
        }
#endif
        /// <summary>Specifies the minimum battery percentage to allow the device to upload data (0-100). Valid values 0 to 100</summary>
        public int? MinimumBatteryPercentageAllowedToUpload {
            get { return BackingStore?.Get<int?>("minimumBatteryPercentageAllowedToUpload"); }
            set { BackingStore?.Set("minimumBatteryPercentageAllowedToUpload", value); }
        }
        /// <summary>Specifies the minimum disk size in GB to use Peer Caching (1-100000). Valid values 1 to 100000</summary>
        public int? MinimumDiskSizeAllowedToPeerInGigabytes {
            get { return BackingStore?.Get<int?>("minimumDiskSizeAllowedToPeerInGigabytes"); }
            set { BackingStore?.Set("minimumDiskSizeAllowedToPeerInGigabytes", value); }
        }
        /// <summary>Specifies the minimum content file size in MB enabled to use Peer Caching (1-100000). Valid values 1 to 100000</summary>
        public int? MinimumFileSizeToCacheInMegabytes {
            get { return BackingStore?.Get<int?>("minimumFileSizeToCacheInMegabytes"); }
            set { BackingStore?.Set("minimumFileSizeToCacheInMegabytes", value); }
        }
        /// <summary>Specifies the minimum RAM size in GB to use Peer Caching (1-100000). Valid values 1 to 100000</summary>
        public int? MinimumRamAllowedToPeerInGigabytes {
            get { return BackingStore?.Get<int?>("minimumRamAllowedToPeerInGigabytes"); }
            set { BackingStore?.Set("minimumRamAllowedToPeerInGigabytes", value); }
        }
        /// <summary>Specifies the drive that Delivery Optimization should use for its cache.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifyCacheLocation {
            get { return BackingStore?.Get<string?>("modifyCacheLocation"); }
            set { BackingStore?.Set("modifyCacheLocation", value); }
        }
#nullable restore
#else
        public string ModifyCacheLocation {
            get { return BackingStore?.Get<string>("modifyCacheLocation"); }
            set { BackingStore?.Set("modifyCacheLocation", value); }
        }
#endif
        /// <summary>Values to restrict peer selection by.</summary>
        public DeliveryOptimizationRestrictPeerSelectionByOptions? RestrictPeerSelectionBy {
            get { return BackingStore?.Get<DeliveryOptimizationRestrictPeerSelectionByOptions?>("restrictPeerSelectionBy"); }
            set { BackingStore?.Set("restrictPeerSelectionBy", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? VpnPeerCaching {
            get { return BackingStore?.Get<Enablement?>("vpnPeerCaching"); }
            set { BackingStore?.Set("vpnPeerCaching", value); }
        }
        /// <summary>
        /// Instantiates a new windowsDeliveryOptimizationConfiguration and sets the default values.
        /// </summary>
        public WindowsDeliveryOptimizationConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsDeliveryOptimizationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDeliveryOptimizationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDeliveryOptimizationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"backgroundDownloadFromHttpDelayInSeconds", n => { BackgroundDownloadFromHttpDelayInSeconds = n.GetLongValue(); } },
                {"bandwidthMode", n => { BandwidthMode = n.GetObjectValue<DeliveryOptimizationBandwidth>(DeliveryOptimizationBandwidth.CreateFromDiscriminatorValue); } },
                {"cacheServerBackgroundDownloadFallbackToHttpDelayInSeconds", n => { CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds = n.GetIntValue(); } },
                {"cacheServerForegroundDownloadFallbackToHttpDelayInSeconds", n => { CacheServerForegroundDownloadFallbackToHttpDelayInSeconds = n.GetIntValue(); } },
                {"cacheServerHostNames", n => { CacheServerHostNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deliveryOptimizationMode", n => { DeliveryOptimizationMode = n.GetEnumValue<WindowsDeliveryOptimizationMode>(); } },
                {"foregroundDownloadFromHttpDelayInSeconds", n => { ForegroundDownloadFromHttpDelayInSeconds = n.GetLongValue(); } },
                {"groupIdSource", n => { GroupIdSource = n.GetObjectValue<DeliveryOptimizationGroupIdSource>(DeliveryOptimizationGroupIdSource.CreateFromDiscriminatorValue); } },
                {"maximumCacheAgeInDays", n => { MaximumCacheAgeInDays = n.GetIntValue(); } },
                {"maximumCacheSize", n => { MaximumCacheSize = n.GetObjectValue<DeliveryOptimizationMaxCacheSize>(DeliveryOptimizationMaxCacheSize.CreateFromDiscriminatorValue); } },
                {"minimumBatteryPercentageAllowedToUpload", n => { MinimumBatteryPercentageAllowedToUpload = n.GetIntValue(); } },
                {"minimumDiskSizeAllowedToPeerInGigabytes", n => { MinimumDiskSizeAllowedToPeerInGigabytes = n.GetIntValue(); } },
                {"minimumFileSizeToCacheInMegabytes", n => { MinimumFileSizeToCacheInMegabytes = n.GetIntValue(); } },
                {"minimumRamAllowedToPeerInGigabytes", n => { MinimumRamAllowedToPeerInGigabytes = n.GetIntValue(); } },
                {"modifyCacheLocation", n => { ModifyCacheLocation = n.GetStringValue(); } },
                {"restrictPeerSelectionBy", n => { RestrictPeerSelectionBy = n.GetEnumValue<DeliveryOptimizationRestrictPeerSelectionByOptions>(); } },
                {"vpnPeerCaching", n => { VpnPeerCaching = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("backgroundDownloadFromHttpDelayInSeconds", BackgroundDownloadFromHttpDelayInSeconds);
            writer.WriteObjectValue<DeliveryOptimizationBandwidth>("bandwidthMode", BandwidthMode);
            writer.WriteIntValue("cacheServerBackgroundDownloadFallbackToHttpDelayInSeconds", CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds);
            writer.WriteIntValue("cacheServerForegroundDownloadFallbackToHttpDelayInSeconds", CacheServerForegroundDownloadFallbackToHttpDelayInSeconds);
            writer.WriteCollectionOfPrimitiveValues<string>("cacheServerHostNames", CacheServerHostNames);
            writer.WriteEnumValue<WindowsDeliveryOptimizationMode>("deliveryOptimizationMode", DeliveryOptimizationMode);
            writer.WriteLongValue("foregroundDownloadFromHttpDelayInSeconds", ForegroundDownloadFromHttpDelayInSeconds);
            writer.WriteObjectValue<DeliveryOptimizationGroupIdSource>("groupIdSource", GroupIdSource);
            writer.WriteIntValue("maximumCacheAgeInDays", MaximumCacheAgeInDays);
            writer.WriteObjectValue<DeliveryOptimizationMaxCacheSize>("maximumCacheSize", MaximumCacheSize);
            writer.WriteIntValue("minimumBatteryPercentageAllowedToUpload", MinimumBatteryPercentageAllowedToUpload);
            writer.WriteIntValue("minimumDiskSizeAllowedToPeerInGigabytes", MinimumDiskSizeAllowedToPeerInGigabytes);
            writer.WriteIntValue("minimumFileSizeToCacheInMegabytes", MinimumFileSizeToCacheInMegabytes);
            writer.WriteIntValue("minimumRamAllowedToPeerInGigabytes", MinimumRamAllowedToPeerInGigabytes);
            writer.WriteStringValue("modifyCacheLocation", ModifyCacheLocation);
            writer.WriteEnumValue<DeliveryOptimizationRestrictPeerSelectionByOptions>("restrictPeerSelectionBy", RestrictPeerSelectionBy);
            writer.WriteEnumValue<Enablement>("vpnPeerCaching", VpnPeerCaching);
        }
    }
}
