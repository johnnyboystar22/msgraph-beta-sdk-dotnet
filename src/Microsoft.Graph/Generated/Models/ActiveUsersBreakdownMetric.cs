// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ActiveUsersBreakdownMetric : Entity, IParsable {
        /// <summary>The ID of the Microsoft Entra application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Name of the application users authenticated to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName {
            get { return BackingStore?.Get<string?>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#nullable restore
#else
        public string AppName {
            get { return BackingStore?.Get<string>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#endif
        /// <summary>The total number of users who made at least one authentication request within the specified time period.</summary>
        public long? Count {
            get { return BackingStore?.Get<long?>("count"); }
            set { BackingStore?.Set("count", value); }
        }
        /// <summary>The date of the insight.</summary>
        public Date? FactDate {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The platform for the device that the customers used. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os {
            get { return BackingStore?.Get<string?>("os"); }
            set { BackingStore?.Set("os", value); }
        }
#nullable restore
#else
        public string Os {
            get { return BackingStore?.Get<string>("os"); }
            set { BackingStore?.Set("os", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActiveUsersBreakdownMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ActiveUsersBreakdownMetric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActiveUsersBreakdownMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"count", n => { Count = n.GetLongValue(); } },
                {"factDate", n => { FactDate = n.GetDateValue(); } },
                {"os", n => { Os = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("appName", AppName);
            writer.WriteLongValue("count", Count);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteStringValue("os", Os);
        }
    }
}
