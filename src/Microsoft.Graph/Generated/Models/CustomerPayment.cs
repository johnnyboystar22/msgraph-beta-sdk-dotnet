using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CustomerPayment : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The amount property</summary>
        public decimal? Amount {
            get { return BackingStore?.Get<decimal?>("amount"); }
            set { BackingStore?.Set("amount", value); }
        }
        /// <summary>The appliesToInvoiceId property</summary>
        public Guid? AppliesToInvoiceId {
            get { return BackingStore?.Get<Guid?>("appliesToInvoiceId"); }
            set { BackingStore?.Set("appliesToInvoiceId", value); }
        }
        /// <summary>The appliesToInvoiceNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppliesToInvoiceNumber {
            get { return BackingStore?.Get<string?>("appliesToInvoiceNumber"); }
            set { BackingStore?.Set("appliesToInvoiceNumber", value); }
        }
#nullable restore
#else
        public string AppliesToInvoiceNumber {
            get { return BackingStore?.Get<string>("appliesToInvoiceNumber"); }
            set { BackingStore?.Set("appliesToInvoiceNumber", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The contactId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactId {
            get { return BackingStore?.Get<string?>("contactId"); }
            set { BackingStore?.Set("contactId", value); }
        }
#nullable restore
#else
        public string ContactId {
            get { return BackingStore?.Get<string>("contactId"); }
            set { BackingStore?.Set("contactId", value); }
        }
#endif
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Customer? Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer?>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Customer Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#endif
        /// <summary>The customerId property</summary>
        public Guid? CustomerId {
            get { return BackingStore?.Get<Guid?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
        /// <summary>The customerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber {
            get { return BackingStore?.Get<string?>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#nullable restore
#else
        public string CustomerNumber {
            get { return BackingStore?.Get<string>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#endif
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
        /// <summary>The documentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentNumber {
            get { return BackingStore?.Get<string?>("documentNumber"); }
            set { BackingStore?.Set("documentNumber", value); }
        }
#nullable restore
#else
        public string DocumentNumber {
            get { return BackingStore?.Get<string>("documentNumber"); }
            set { BackingStore?.Set("documentNumber", value); }
        }
#endif
        /// <summary>The externalDocumentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalDocumentNumber {
            get { return BackingStore?.Get<string?>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
#nullable restore
#else
        public string ExternalDocumentNumber {
            get { return BackingStore?.Get<string>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
#endif
        /// <summary>The id property</summary>
        public Guid? Id {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The journalDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JournalDisplayName {
            get { return BackingStore?.Get<string?>("journalDisplayName"); }
            set { BackingStore?.Set("journalDisplayName", value); }
        }
#nullable restore
#else
        public string JournalDisplayName {
            get { return BackingStore?.Get<string>("journalDisplayName"); }
            set { BackingStore?.Set("journalDisplayName", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The lineNumber property</summary>
        public int? LineNumber {
            get { return BackingStore?.Get<int?>("lineNumber"); }
            set { BackingStore?.Set("lineNumber", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The postingDate property</summary>
        public Date? PostingDate {
            get { return BackingStore?.Get<Date?>("postingDate"); }
            set { BackingStore?.Set("postingDate", value); }
        }
        /// <summary>
        /// Instantiates a new customerPayment and sets the default values.
        /// </summary>
        public CustomerPayment() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomerPayment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerPayment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDecimalValue(); } },
                {"appliesToInvoiceId", n => { AppliesToInvoiceId = n.GetGuidValue(); } },
                {"appliesToInvoiceNumber", n => { AppliesToInvoiceNumber = n.GetStringValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"contactId", n => { ContactId = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetGuidValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentNumber", n => { DocumentNumber = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"journalDisplayName", n => { JournalDisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lineNumber", n => { LineNumber = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postingDate", n => { PostingDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDecimalValue("amount", Amount);
            writer.WriteGuidValue("appliesToInvoiceId", AppliesToInvoiceId);
            writer.WriteStringValue("appliesToInvoiceNumber", AppliesToInvoiceNumber);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("contactId", ContactId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Customer>("customer", Customer);
            writer.WriteGuidValue("customerId", CustomerId);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("documentNumber", DocumentNumber);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("journalDisplayName", JournalDisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("lineNumber", LineNumber);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateValue("postingDate", PostingDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
