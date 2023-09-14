// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Sales Credit Memo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SalesCreditMemo>))]
    public partial class SalesCreditMemo
    {
    
        /// <summary>
        /// Gets or sets billing postal address.
        /// </summary>
        [JsonPropertyName("billingPostalAddress")]
        public PostalAddressType BillingPostalAddress { get; set; }
    
        /// <summary>
        /// Gets or sets bill to customer id.
        /// </summary>
        [JsonPropertyName("billToCustomerId")]
        public Guid? BillToCustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets bill to customer number.
        /// </summary>
        [JsonPropertyName("billToCustomerNumber")]
        public string BillToCustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets bill to name.
        /// </summary>
        [JsonPropertyName("billToName")]
        public string BillToName { get; set; }
    
        /// <summary>
        /// Gets or sets credit memo date.
        /// </summary>
        [JsonPropertyName("creditMemoDate")]
        public Date CreditMemoDate { get; set; }
    
        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or sets currency id.
        /// </summary>
        [JsonPropertyName("currencyId")]
        public Guid? CurrencyId { get; set; }
    
        /// <summary>
        /// Gets or sets customer id.
        /// </summary>
        [JsonPropertyName("customerId")]
        public Guid? CustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets customer name.
        /// </summary>
        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Gets or sets customer number.
        /// </summary>
        [JsonPropertyName("customerNumber")]
        public string CustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets discount amount.
        /// </summary>
        [JsonPropertyName("discountAmount")]
        public Decimal? DiscountAmount { get; set; }
    
        /// <summary>
        /// Gets or sets discount applied before tax.
        /// </summary>
        [JsonPropertyName("discountAppliedBeforeTax")]
        public bool? DiscountAppliedBeforeTax { get; set; }
    
        /// <summary>
        /// Gets or sets due date.
        /// </summary>
        [JsonPropertyName("dueDate")]
        public Date DueDate { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets external document number.
        /// </summary>
        [JsonPropertyName("externalDocumentNumber")]
        public string ExternalDocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }
    
        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [JsonPropertyName("invoiceId")]
        public Guid? InvoiceId { get; set; }
    
        /// <summary>
        /// Gets or sets invoice number.
        /// </summary>
        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or sets payment terms id.
        /// </summary>
        [JsonPropertyName("paymentTermsId")]
        public Guid? PaymentTermsId { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets prices include tax.
        /// </summary>
        [JsonPropertyName("pricesIncludeTax")]
        public bool? PricesIncludeTax { get; set; }
    
        /// <summary>
        /// Gets or sets salesperson.
        /// </summary>
        [JsonPropertyName("salesperson")]
        public string Salesperson { get; set; }
    
        /// <summary>
        /// Gets or sets selling postal address.
        /// </summary>
        [JsonPropertyName("sellingPostalAddress")]
        public PostalAddressType SellingPostalAddress { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets total amount excluding tax.
        /// </summary>
        [JsonPropertyName("totalAmountExcludingTax")]
        public Decimal? TotalAmountExcludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets total amount including tax.
        /// </summary>
        [JsonPropertyName("totalAmountIncludingTax")]
        public Decimal? TotalAmountIncludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets total tax amount.
        /// </summary>
        [JsonPropertyName("totalTaxAmount")]
        public Decimal? TotalTaxAmount { get; set; }
    
        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }
    
        /// <summary>
        /// Gets or sets customer.
        /// </summary>
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    
        /// <summary>
        /// Gets or sets payment term.
        /// </summary>
        [JsonPropertyName("paymentTerm")]
        public PaymentTerm PaymentTerm { get; set; }
    
        /// <summary>
        /// Gets or sets sales credit memo lines.
        /// </summary>
        [JsonPropertyName("salesCreditMemoLines")]
        public ISalesCreditMemoSalesCreditMemoLinesCollectionPage SalesCreditMemoLines { get; set; }

        /// <summary>
        /// Gets or sets salesCreditMemoLinesNextLink.
        /// </summary>
        [JsonPropertyName("salesCreditMemoLines@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SalesCreditMemoLinesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

