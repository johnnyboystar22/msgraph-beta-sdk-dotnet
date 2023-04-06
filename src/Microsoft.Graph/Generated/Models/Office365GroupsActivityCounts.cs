using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Office365GroupsActivityCounts : Entity, IParsable {
        /// <summary>The number of emails received by Group mailboxes.</summary>
        public long? ExchangeEmailsReceived {
            get { return BackingStore?.Get<long?>("exchangeEmailsReceived"); }
            set { BackingStore?.Set("exchangeEmailsReceived", value); }
        }
        /// <summary>The date on which a number of emails were sent to a group mailbox or a number of messages were posted, read, or liked in a Yammer group</summary>
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
        /// <summary>The number of channel messages in Teams team.</summary>
        public long? TeamsChannelMessages {
            get { return BackingStore?.Get<long?>("teamsChannelMessages"); }
            set { BackingStore?.Set("teamsChannelMessages", value); }
        }
        /// <summary>The number of meetings organized in Teams team.</summary>
        public long? TeamsMeetingsOrganized {
            get { return BackingStore?.Get<long?>("teamsMeetingsOrganized"); }
            set { BackingStore?.Set("teamsMeetingsOrganized", value); }
        }
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public long? YammerMessagesLiked {
            get { return BackingStore?.Get<long?>("yammerMessagesLiked"); }
            set { BackingStore?.Set("yammerMessagesLiked", value); }
        }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public long? YammerMessagesPosted {
            get { return BackingStore?.Get<long?>("yammerMessagesPosted"); }
            set { BackingStore?.Set("yammerMessagesPosted", value); }
        }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public long? YammerMessagesRead {
            get { return BackingStore?.Get<long?>("yammerMessagesRead"); }
            set { BackingStore?.Set("yammerMessagesRead", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Office365GroupsActivityCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exchangeEmailsReceived", n => { ExchangeEmailsReceived = n.GetLongValue(); } },
                {"reportDate", n => { ReportDate = n.GetDateValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"teamsChannelMessages", n => { TeamsChannelMessages = n.GetLongValue(); } },
                {"teamsMeetingsOrganized", n => { TeamsMeetingsOrganized = n.GetLongValue(); } },
                {"yammerMessagesLiked", n => { YammerMessagesLiked = n.GetLongValue(); } },
                {"yammerMessagesPosted", n => { YammerMessagesPosted = n.GetLongValue(); } },
                {"yammerMessagesRead", n => { YammerMessagesRead = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchangeEmailsReceived", ExchangeEmailsReceived);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("teamsChannelMessages", TeamsChannelMessages);
            writer.WriteLongValue("teamsMeetingsOrganized", TeamsMeetingsOrganized);
            writer.WriteLongValue("yammerMessagesLiked", YammerMessagesLiked);
            writer.WriteLongValue("yammerMessagesPosted", YammerMessagesPosted);
            writer.WriteLongValue("yammerMessagesRead", YammerMessagesRead);
        }
    }
}
