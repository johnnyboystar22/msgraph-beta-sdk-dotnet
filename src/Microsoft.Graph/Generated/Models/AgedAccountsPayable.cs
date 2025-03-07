// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AgedAccountsPayable : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The agedAsOfDate property</summary>
        public Date? AgedAsOfDate
        {
            get { return BackingStore?.Get<Date?>("agedAsOfDate"); }
            set { BackingStore?.Set("agedAsOfDate", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The balanceDue property</summary>
        public decimal? BalanceDue
        {
            get { return BackingStore?.Get<decimal?>("balanceDue"); }
            set { BackingStore?.Set("balanceDue", value); }
        }
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode
        {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode
        {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>The currentAmount property</summary>
        public decimal? CurrentAmount
        {
            get { return BackingStore?.Get<decimal?>("currentAmount"); }
            set { BackingStore?.Set("currentAmount", value); }
        }
        /// <summary>The id property</summary>
        public Guid? Id
        {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The name property</summary>
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
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The period1Amount property</summary>
        public decimal? Period1Amount
        {
            get { return BackingStore?.Get<decimal?>("period1Amount"); }
            set { BackingStore?.Set("period1Amount", value); }
        }
        /// <summary>The period2Amount property</summary>
        public decimal? Period2Amount
        {
            get { return BackingStore?.Get<decimal?>("period2Amount"); }
            set { BackingStore?.Set("period2Amount", value); }
        }
        /// <summary>The period3Amount property</summary>
        public decimal? Period3Amount
        {
            get { return BackingStore?.Get<decimal?>("period3Amount"); }
            set { BackingStore?.Set("period3Amount", value); }
        }
        /// <summary>The periodLengthFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PeriodLengthFilter
        {
            get { return BackingStore?.Get<string?>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
#nullable restore
#else
        public string PeriodLengthFilter
        {
            get { return BackingStore?.Get<string>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
#endif
        /// <summary>The vendorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorId
        {
            get { return BackingStore?.Get<string?>("vendorId"); }
            set { BackingStore?.Set("vendorId", value); }
        }
#nullable restore
#else
        public string VendorId
        {
            get { return BackingStore?.Get<string>("vendorId"); }
            set { BackingStore?.Set("vendorId", value); }
        }
#endif
        /// <summary>The vendorNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorNumber
        {
            get { return BackingStore?.Get<string?>("vendorNumber"); }
            set { BackingStore?.Set("vendorNumber", value); }
        }
#nullable restore
#else
        public string VendorNumber
        {
            get { return BackingStore?.Get<string>("vendorNumber"); }
            set { BackingStore?.Set("vendorNumber", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AgedAccountsPayable"/> and sets the default values.
        /// </summary>
        public AgedAccountsPayable()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AgedAccountsPayable"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.AgedAccountsPayable CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AgedAccountsPayable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "agedAsOfDate", n => { AgedAsOfDate = n.GetDateValue(); } },
                { "balanceDue", n => { BalanceDue = n.GetDecimalValue(); } },
                { "currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                { "currentAmount", n => { CurrentAmount = n.GetDecimalValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "period1Amount", n => { Period1Amount = n.GetDecimalValue(); } },
                { "period2Amount", n => { Period2Amount = n.GetDecimalValue(); } },
                { "period3Amount", n => { Period3Amount = n.GetDecimalValue(); } },
                { "periodLengthFilter", n => { PeriodLengthFilter = n.GetStringValue(); } },
                { "vendorId", n => { VendorId = n.GetStringValue(); } },
                { "vendorNumber", n => { VendorNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("agedAsOfDate", AgedAsOfDate);
            writer.WriteDecimalValue("balanceDue", BalanceDue);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDecimalValue("currentAmount", CurrentAmount);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDecimalValue("period1Amount", Period1Amount);
            writer.WriteDecimalValue("period2Amount", Period2Amount);
            writer.WriteDecimalValue("period3Amount", Period3Amount);
            writer.WriteStringValue("periodLengthFilter", PeriodLengthFilter);
            writer.WriteStringValue("vendorId", VendorId);
            writer.WriteStringValue("vendorNumber", VendorNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
