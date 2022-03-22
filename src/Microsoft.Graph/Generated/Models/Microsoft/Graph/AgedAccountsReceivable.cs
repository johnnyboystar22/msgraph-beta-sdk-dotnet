using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AgedAccountsReceivable : Entity, IParsable {
        public Date? AgedAsOfDate { get; set; }
        public decimal? BalanceDue { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrentAmount { get; set; }
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public decimal? Period1Amount { get; set; }
        public decimal? Period2Amount { get; set; }
        public decimal? Period3Amount { get; set; }
        public string PeriodLengthFilter { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AgedAccountsReceivable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgedAccountsReceivable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agedAsOfDate", (o,n) => { (o as AgedAccountsReceivable).AgedAsOfDate = n.GetDateValue(); } },
                {"balanceDue", (o,n) => { (o as AgedAccountsReceivable).BalanceDue = n.GetDecimalValue(); } },
                {"currencyCode", (o,n) => { (o as AgedAccountsReceivable).CurrencyCode = n.GetStringValue(); } },
                {"currentAmount", (o,n) => { (o as AgedAccountsReceivable).CurrentAmount = n.GetDecimalValue(); } },
                {"customerNumber", (o,n) => { (o as AgedAccountsReceivable).CustomerNumber = n.GetStringValue(); } },
                {"name", (o,n) => { (o as AgedAccountsReceivable).Name = n.GetStringValue(); } },
                {"period1Amount", (o,n) => { (o as AgedAccountsReceivable).Period1Amount = n.GetDecimalValue(); } },
                {"period2Amount", (o,n) => { (o as AgedAccountsReceivable).Period2Amount = n.GetDecimalValue(); } },
                {"period3Amount", (o,n) => { (o as AgedAccountsReceivable).Period3Amount = n.GetDecimalValue(); } },
                {"periodLengthFilter", (o,n) => { (o as AgedAccountsReceivable).PeriodLengthFilter = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("agedAsOfDate", AgedAsOfDate);
            writer.WriteDecimalValue("balanceDue", BalanceDue);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDecimalValue("currentAmount", CurrentAmount);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteStringValue("name", Name);
            writer.WriteDecimalValue("period1Amount", Period1Amount);
            writer.WriteDecimalValue("period2Amount", Period2Amount);
            writer.WriteDecimalValue("period3Amount", Period3Amount);
            writer.WriteStringValue("periodLengthFilter", PeriodLengthFilter);
        }
    }
}
