using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementReports : Entity, IParsable {
        /// <summary>Entity representing the configuration of a cached report</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementCachedReportConfiguration>? CachedReportConfigurations {
            get { return BackingStore?.Get<List<DeviceManagementCachedReportConfiguration>?>("cachedReportConfigurations"); }
            set { BackingStore?.Set("cachedReportConfigurations", value); }
        }
#nullable restore
#else
        public List<DeviceManagementCachedReportConfiguration> CachedReportConfigurations {
            get { return BackingStore?.Get<List<DeviceManagementCachedReportConfiguration>>("cachedReportConfigurations"); }
            set { BackingStore?.Set("cachedReportConfigurations", value); }
        }
#endif
        /// <summary>Entity representing a job to export a report</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementExportJob>? ExportJobs {
            get { return BackingStore?.Get<List<DeviceManagementExportJob>?>("exportJobs"); }
            set { BackingStore?.Set("exportJobs", value); }
        }
#nullable restore
#else
        public List<DeviceManagementExportJob> ExportJobs {
            get { return BackingStore?.Get<List<DeviceManagementExportJob>>("exportJobs"); }
            set { BackingStore?.Set("exportJobs", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementReports CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementReports();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cachedReportConfigurations", n => { CachedReportConfigurations = n.GetCollectionOfObjectValues<DeviceManagementCachedReportConfiguration>(DeviceManagementCachedReportConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exportJobs", n => { ExportJobs = n.GetCollectionOfObjectValues<DeviceManagementExportJob>(DeviceManagementExportJob.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementCachedReportConfiguration>("cachedReportConfigurations", CachedReportConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceManagementExportJob>("exportJobs", ExportJobs);
        }
    }
}
