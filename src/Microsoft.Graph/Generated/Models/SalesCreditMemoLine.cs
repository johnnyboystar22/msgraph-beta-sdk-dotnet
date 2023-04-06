using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SalesCreditMemoLine : Entity, IParsable {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Account? Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account?>("account"); }
            set { BackingStore?.Set("account", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Account Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account>("account"); }
            set { BackingStore?.Set("account", value); }
        }
#endif
        /// <summary>The accountId property</summary>
        public Guid? AccountId {
            get { return BackingStore?.Get<Guid?>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
        /// <summary>The amountExcludingTax property</summary>
        public decimal? AmountExcludingTax {
            get { return BackingStore?.Get<decimal?>("amountExcludingTax"); }
            set { BackingStore?.Set("amountExcludingTax", value); }
        }
        /// <summary>The amountIncludingTax property</summary>
        public decimal? AmountIncludingTax {
            get { return BackingStore?.Get<decimal?>("amountIncludingTax"); }
            set { BackingStore?.Set("amountIncludingTax", value); }
        }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>("discountAmount"); }
            set { BackingStore?.Set("discountAmount", value); }
        }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax {
            get { return BackingStore?.Get<bool?>("discountAppliedBeforeTax"); }
            set { BackingStore?.Set("discountAppliedBeforeTax", value); }
        }
        /// <summary>The discountPercent property</summary>
        public decimal? DiscountPercent {
            get { return BackingStore?.Get<decimal?>("discountPercent"); }
            set { BackingStore?.Set("discountPercent", value); }
        }
        /// <summary>The documentId property</summary>
        public Guid? DocumentId {
            get { return BackingStore?.Get<Guid?>("documentId"); }
            set { BackingStore?.Set("documentId", value); }
        }
        /// <summary>The invoiceDiscountAllocation property</summary>
        public decimal? InvoiceDiscountAllocation {
            get { return BackingStore?.Get<decimal?>("invoiceDiscountAllocation"); }
            set { BackingStore?.Set("invoiceDiscountAllocation", value); }
        }
        /// <summary>The item property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Item? Item {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Item?>("item"); }
            set { BackingStore?.Set("item", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Item Item {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Item>("item"); }
            set { BackingStore?.Set("item", value); }
        }
#endif
        /// <summary>The itemId property</summary>
        public Guid? ItemId {
            get { return BackingStore?.Get<Guid?>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
        /// <summary>The lineType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LineType {
            get { return BackingStore?.Get<string?>("lineType"); }
            set { BackingStore?.Set("lineType", value); }
        }
#nullable restore
#else
        public string LineType {
            get { return BackingStore?.Get<string>("lineType"); }
            set { BackingStore?.Set("lineType", value); }
        }
#endif
        /// <summary>The netAmount property</summary>
        public decimal? NetAmount {
            get { return BackingStore?.Get<decimal?>("netAmount"); }
            set { BackingStore?.Set("netAmount", value); }
        }
        /// <summary>The netAmountIncludingTax property</summary>
        public decimal? NetAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>("netAmountIncludingTax"); }
            set { BackingStore?.Set("netAmountIncludingTax", value); }
        }
        /// <summary>The netTaxAmount property</summary>
        public decimal? NetTaxAmount {
            get { return BackingStore?.Get<decimal?>("netTaxAmount"); }
            set { BackingStore?.Set("netTaxAmount", value); }
        }
        /// <summary>The quantity property</summary>
        public decimal? Quantity {
            get { return BackingStore?.Get<decimal?>("quantity"); }
            set { BackingStore?.Set("quantity", value); }
        }
        /// <summary>The sequence property</summary>
        public int? Sequence {
            get { return BackingStore?.Get<int?>("sequence"); }
            set { BackingStore?.Set("sequence", value); }
        }
        /// <summary>The shipmentDate property</summary>
        public Date? ShipmentDate {
            get { return BackingStore?.Get<Date?>("shipmentDate"); }
            set { BackingStore?.Set("shipmentDate", value); }
        }
        /// <summary>The taxCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxCode {
            get { return BackingStore?.Get<string?>("taxCode"); }
            set { BackingStore?.Set("taxCode", value); }
        }
#nullable restore
#else
        public string TaxCode {
            get { return BackingStore?.Get<string>("taxCode"); }
            set { BackingStore?.Set("taxCode", value); }
        }
#endif
        /// <summary>The taxPercent property</summary>
        public decimal? TaxPercent {
            get { return BackingStore?.Get<decimal?>("taxPercent"); }
            set { BackingStore?.Set("taxPercent", value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>("totalTaxAmount"); }
            set { BackingStore?.Set("totalTaxAmount", value); }
        }
        /// <summary>The unitOfMeasureId property</summary>
        public Guid? UnitOfMeasureId {
            get { return BackingStore?.Get<Guid?>("unitOfMeasureId"); }
            set { BackingStore?.Set("unitOfMeasureId", value); }
        }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice {
            get { return BackingStore?.Get<decimal?>("unitPrice"); }
            set { BackingStore?.Set("unitPrice", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SalesCreditMemoLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesCreditMemoLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", n => { AccountId = n.GetGuidValue(); } },
                {"amountExcludingTax", n => { AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", n => { AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", n => { DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", n => { DocumentId = n.GetGuidValue(); } },
                {"invoiceDiscountAllocation", n => { InvoiceDiscountAllocation = n.GetDecimalValue(); } },
                {"item", n => { Item = n.GetObjectValue<Microsoft.Graph.Beta.Models.Item>(Microsoft.Graph.Beta.Models.Item.CreateFromDiscriminatorValue); } },
                {"itemId", n => { ItemId = n.GetGuidValue(); } },
                {"lineType", n => { LineType = n.GetStringValue(); } },
                {"netAmount", n => { NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", n => { NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", n => { NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", n => { Quantity = n.GetDecimalValue(); } },
                {"sequence", n => { Sequence = n.GetIntValue(); } },
                {"shipmentDate", n => { ShipmentDate = n.GetDateValue(); } },
                {"taxCode", n => { TaxCode = n.GetStringValue(); } },
                {"taxPercent", n => { TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitOfMeasureId", n => { UnitOfMeasureId = n.GetGuidValue(); } },
                {"unitPrice", n => { UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Account>("account", Account);
            writer.WriteGuidValue("accountId", AccountId);
            writer.WriteDecimalValue("amountExcludingTax", AmountExcludingTax);
            writer.WriteDecimalValue("amountIncludingTax", AmountIncludingTax);
            writer.WriteStringValue("description", Description);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteGuidValue("documentId", DocumentId);
            writer.WriteDecimalValue("invoiceDiscountAllocation", InvoiceDiscountAllocation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Item>("item", Item);
            writer.WriteGuidValue("itemId", ItemId);
            writer.WriteStringValue("lineType", LineType);
            writer.WriteDecimalValue("netAmount", NetAmount);
            writer.WriteDecimalValue("netAmountIncludingTax", NetAmountIncludingTax);
            writer.WriteDecimalValue("netTaxAmount", NetTaxAmount);
            writer.WriteDecimalValue("quantity", Quantity);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteDateValue("shipmentDate", ShipmentDate);
            writer.WriteStringValue("taxCode", TaxCode);
            writer.WriteDecimalValue("taxPercent", TaxPercent);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteGuidValue("unitOfMeasureId", UnitOfMeasureId);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
