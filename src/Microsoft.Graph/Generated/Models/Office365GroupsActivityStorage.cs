using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Office365GroupsActivityStorage : Entity, IParsable {
        /// <summary>The storage used in group mailbox.</summary>
        public long? MailboxStorageUsedInBytes {
            get { return BackingStore?.Get<long?>("mailboxStorageUsedInBytes"); }
            set { BackingStore?.Set("mailboxStorageUsedInBytes", value); }
        }
        /// <summary>The snapshot date for Exchange and SharePoint used storage.</summary>
        public Date? ReportDate {
            get { return BackingStore?.Get<Date?>("reportDate"); }
            set { BackingStore?.Set("reportDate", value); }
        }
        /// <summary>The number of days the report covers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportPeriod {
            get { return BackingStore?.Get<string?>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#nullable restore
#else
        public string ReportPeriod {
            get { return BackingStore?.Get<string>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#endif
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate {
            get { return BackingStore?.Get<Date?>("reportRefreshDate"); }
            set { BackingStore?.Set("reportRefreshDate", value); }
        }
        /// <summary>The storage used in SharePoint document library.</summary>
        public long? SiteStorageUsedInBytes {
            get { return BackingStore?.Get<long?>("siteStorageUsedInBytes"); }
            set { BackingStore?.Set("siteStorageUsedInBytes", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Office365GroupsActivityStorage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityStorage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mailboxStorageUsedInBytes", n => { MailboxStorageUsedInBytes = n.GetLongValue(); } },
                {"reportDate", n => { ReportDate = n.GetDateValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"siteStorageUsedInBytes", n => { SiteStorageUsedInBytes = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("mailboxStorageUsedInBytes", MailboxStorageUsedInBytes);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("siteStorageUsedInBytes", SiteStorageUsedInBytes);
        }
    }
}
