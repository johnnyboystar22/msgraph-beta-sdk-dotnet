using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Training : Entity, IParsable {
        /// <summary>The availabilityStatus property</summary>
        public TrainingAvailabilityStatus? AvailabilityStatus {
            get { return BackingStore?.Get<TrainingAvailabilityStatus?>("availabilityStatus"); }
            set { BackingStore?.Set("availabilityStatus", value); }
        }
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? CreatedBy {
            get { return BackingStore?.Get<EmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public EmailIdentity CreatedBy {
            get { return BackingStore?.Get<EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
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
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The durationInMinutes property</summary>
        public int? DurationInMinutes {
            get { return BackingStore?.Get<int?>("durationInMinutes"); }
            set { BackingStore?.Set("durationInMinutes", value); }
        }
        /// <summary>The hasEvaluation property</summary>
        public bool? HasEvaluation {
            get { return BackingStore?.Get<bool?>("hasEvaluation"); }
            set { BackingStore?.Set("hasEvaluation", value); }
        }
        /// <summary>The languageDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TrainingLanguageDetail>? LanguageDetails {
            get { return BackingStore?.Get<List<TrainingLanguageDetail>?>("languageDetails"); }
            set { BackingStore?.Set("languageDetails", value); }
        }
#nullable restore
#else
        public List<TrainingLanguageDetail> LanguageDetails {
            get { return BackingStore?.Get<List<TrainingLanguageDetail>>("languageDetails"); }
            set { BackingStore?.Set("languageDetails", value); }
        }
#endif
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? LastModifiedBy {
            get { return BackingStore?.Get<EmailIdentity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public EmailIdentity LastModifiedBy {
            get { return BackingStore?.Get<EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The source property</summary>
        public SimulationContentSource? Source {
            get { return BackingStore?.Get<SimulationContentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The supportedLocales property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedLocales {
            get { return BackingStore?.Get<List<string>?>("supportedLocales"); }
            set { BackingStore?.Set("supportedLocales", value); }
        }
#nullable restore
#else
        public List<string> SupportedLocales {
            get { return BackingStore?.Get<List<string>>("supportedLocales"); }
            set { BackingStore?.Set("supportedLocales", value); }
        }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The type property</summary>
        public TrainingType? Type {
            get { return BackingStore?.Get<TrainingType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Training CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Training();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availabilityStatus", n => { AvailabilityStatus = n.GetEnumValue<TrainingAvailabilityStatus>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"durationInMinutes", n => { DurationInMinutes = n.GetIntValue(); } },
                {"hasEvaluation", n => { HasEvaluation = n.GetBoolValue(); } },
                {"languageDetails", n => { LanguageDetails = n.GetCollectionOfObjectValues<TrainingLanguageDetail>(TrainingLanguageDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"source", n => { Source = n.GetEnumValue<SimulationContentSource>(); } },
                {"supportedLocales", n => { SupportedLocales = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"type", n => { Type = n.GetEnumValue<TrainingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TrainingAvailabilityStatus>("availabilityStatus", AvailabilityStatus);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInMinutes", DurationInMinutes);
            writer.WriteBoolValue("hasEvaluation", HasEvaluation);
            writer.WriteCollectionOfObjectValues<TrainingLanguageDetail>("languageDetails", LanguageDetails);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<SimulationContentSource>("source", Source);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedLocales", SupportedLocales);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<TrainingType>("type", Type);
        }
    }
}
