using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties and inherited properties for MacOS Volume-Purchased Program (VPP) Apps.
    /// </summary>
    public class MacOsVppApp : MobileApp, IParsable {
        /// <summary>The store URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppStoreUrl {
            get { return BackingStore?.Get<string?>("appStoreUrl"); }
            set { BackingStore?.Set("appStoreUrl", value); }
        }
#nullable restore
#else
        public string AppStoreUrl {
            get { return BackingStore?.Get<string>("appStoreUrl"); }
            set { BackingStore?.Set("appStoreUrl", value); }
        }
#endif
        /// <summary>The licenses assigned to this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOsVppAppAssignedLicense>? AssignedLicenses {
            get { return BackingStore?.Get<List<MacOsVppAppAssignedLicense>?>("assignedLicenses"); }
            set { BackingStore?.Set("assignedLicenses", value); }
        }
#nullable restore
#else
        public List<MacOsVppAppAssignedLicense> AssignedLicenses {
            get { return BackingStore?.Get<List<MacOsVppAppAssignedLicense>>("assignedLicenses"); }
            set { BackingStore?.Set("assignedLicenses", value); }
        }
#endif
        /// <summary>The Identity Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleId {
            get { return BackingStore?.Get<string?>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#nullable restore
#else
        public string BundleId {
            get { return BackingStore?.Get<string>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#endif
        /// <summary>The supported License Type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VppLicensingType? LicensingType {
            get { return BackingStore?.Get<VppLicensingType?>("licensingType"); }
            set { BackingStore?.Set("licensingType", value); }
        }
#nullable restore
#else
        public VppLicensingType LicensingType {
            get { return BackingStore?.Get<VppLicensingType>("licensingType"); }
            set { BackingStore?.Set("licensingType", value); }
        }
#endif
        /// <summary>The VPP application release date and time.</summary>
        public DateTimeOffset? ReleaseDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("releaseDateTime"); }
            set { BackingStore?.Set("releaseDateTime", value); }
        }
        /// <summary>Results of revoke license actions on this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOsVppAppRevokeLicensesActionResult>? RevokeLicenseActionResults {
            get { return BackingStore?.Get<List<MacOsVppAppRevokeLicensesActionResult>?>("revokeLicenseActionResults"); }
            set { BackingStore?.Set("revokeLicenseActionResults", value); }
        }
#nullable restore
#else
        public List<MacOsVppAppRevokeLicensesActionResult> RevokeLicenseActionResults {
            get { return BackingStore?.Get<List<MacOsVppAppRevokeLicensesActionResult>>("revokeLicenseActionResults"); }
            set { BackingStore?.Set("revokeLicenseActionResults", value); }
        }
#endif
        /// <summary>The total number of VPP licenses.</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>("totalLicenseCount"); }
            set { BackingStore?.Set("totalLicenseCount", value); }
        }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
        public Microsoft.Graph.Beta.Models.VppTokenAccountType? VppTokenAccountType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VppTokenAccountType?>("vppTokenAccountType"); }
            set { BackingStore?.Set("vppTokenAccountType", value); }
        }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenAppleId {
            get { return BackingStore?.Get<string?>("vppTokenAppleId"); }
            set { BackingStore?.Set("vppTokenAppleId", value); }
        }
#nullable restore
#else
        public string VppTokenAppleId {
            get { return BackingStore?.Get<string>("vppTokenAppleId"); }
            set { BackingStore?.Set("vppTokenAppleId", value); }
        }
#endif
        /// <summary>Identifier of the VPP token associated with this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenId {
            get { return BackingStore?.Get<string?>("vppTokenId"); }
            set { BackingStore?.Set("vppTokenId", value); }
        }
#nullable restore
#else
        public string VppTokenId {
            get { return BackingStore?.Get<string>("vppTokenId"); }
            set { BackingStore?.Set("vppTokenId", value); }
        }
#endif
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenOrganizationName {
            get { return BackingStore?.Get<string?>("vppTokenOrganizationName"); }
            set { BackingStore?.Set("vppTokenOrganizationName", value); }
        }
#nullable restore
#else
        public string VppTokenOrganizationName {
            get { return BackingStore?.Get<string>("vppTokenOrganizationName"); }
            set { BackingStore?.Set("vppTokenOrganizationName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new macOsVppApp and sets the default values.
        /// </summary>
        public MacOsVppApp() : base() {
            OdataType = "#microsoft.graph.macOsVppApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOsVppApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOsVppApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<MacOsVppAppAssignedLicense>(MacOsVppAppAssignedLicense.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"licensingType", n => { LicensingType = n.GetObjectValue<VppLicensingType>(VppLicensingType.CreateFromDiscriminatorValue); } },
                {"releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                {"revokeLicenseActionResults", n => { RevokeLicenseActionResults = n.GetCollectionOfObjectValues<MacOsVppAppRevokeLicensesActionResult>(MacOsVppAppRevokeLicensesActionResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
                {"vppTokenAppleId", n => { VppTokenAppleId = n.GetStringValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
                {"vppTokenOrganizationName", n => { VppTokenOrganizationName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteCollectionOfObjectValues<MacOsVppAppAssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteObjectValue<VppLicensingType>("licensingType", LicensingType);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteCollectionOfObjectValues<MacOsVppAppRevokeLicensesActionResult>("revokeLicenseActionResults", RevokeLicenseActionResults);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
            writer.WriteStringValue("vppTokenAppleId", VppTokenAppleId);
            writer.WriteStringValue("vppTokenId", VppTokenId);
            writer.WriteStringValue("vppTokenOrganizationName", VppTokenOrganizationName);
        }
    }
}
