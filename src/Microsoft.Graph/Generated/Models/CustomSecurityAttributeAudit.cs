// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CustomSecurityAttributeAudit : Entity, IParsable {
        /// <summary>The activityDateTime property</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>The activityDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityDisplayName {
            get { return BackingStore?.Get<string?>("activityDisplayName"); }
            set { BackingStore?.Set("activityDisplayName", value); }
        }
#nullable restore
#else
        public string ActivityDisplayName {
            get { return BackingStore?.Get<string>("activityDisplayName"); }
            set { BackingStore?.Set("activityDisplayName", value); }
        }
#endif
        /// <summary>The additionalDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>?>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#nullable restore
#else
        public List<KeyValue> AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#endif
        /// <summary>The category property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>The correlationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The initiatedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuditActivityInitiator? InitiatedBy {
            get { return BackingStore?.Get<AuditActivityInitiator?>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#nullable restore
#else
        public AuditActivityInitiator InitiatedBy {
            get { return BackingStore?.Get<AuditActivityInitiator>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#endif
        /// <summary>The loggedByService property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoggedByService {
            get { return BackingStore?.Get<string?>("loggedByService"); }
            set { BackingStore?.Set("loggedByService", value); }
        }
#nullable restore
#else
        public string LoggedByService {
            get { return BackingStore?.Get<string>("loggedByService"); }
            set { BackingStore?.Set("loggedByService", value); }
        }
#endif
        /// <summary>The operationType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperationType {
            get { return BackingStore?.Get<string?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
#nullable restore
#else
        public string OperationType {
            get { return BackingStore?.Get<string>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
#endif
        /// <summary>The result property</summary>
        public OperationResult? Result {
            get { return BackingStore?.Get<OperationResult?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>The resultReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultReason {
            get { return BackingStore?.Get<string?>("resultReason"); }
            set { BackingStore?.Set("resultReason", value); }
        }
#nullable restore
#else
        public string ResultReason {
            get { return BackingStore?.Get<string>("resultReason"); }
            set { BackingStore?.Set("resultReason", value); }
        }
#endif
        /// <summary>The targetResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetResource>? TargetResources {
            get { return BackingStore?.Get<List<TargetResource>?>("targetResources"); }
            set { BackingStore?.Set("targetResources", value); }
        }
#nullable restore
#else
        public List<TargetResource> TargetResources {
            get { return BackingStore?.Get<List<TargetResource>>("targetResources"); }
            set { BackingStore?.Set("targetResources", value); }
        }
#endif
        /// <summary>The userAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent {
            get { return BackingStore?.Get<string?>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
#nullable restore
#else
        public string UserAgent {
            get { return BackingStore?.Get<string>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomSecurityAttributeAudit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomSecurityAttributeAudit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomSecurityAttributeAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityDisplayName", n => { ActivityDisplayName = n.GetStringValue(); } },
                {"additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<AuditActivityInitiator>(AuditActivityInitiator.CreateFromDiscriminatorValue); } },
                {"loggedByService", n => { LoggedByService = n.GetStringValue(); } },
                {"operationType", n => { OperationType = n.GetStringValue(); } },
                {"result", n => { Result = n.GetEnumValue<OperationResult>(); } },
                {"resultReason", n => { ResultReason = n.GetStringValue(); } },
                {"targetResources", n => { TargetResources = n.GetCollectionOfObjectValues<TargetResource>(TargetResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userAgent", n => { UserAgent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityDisplayName", ActivityDisplayName);
            writer.WriteCollectionOfObjectValues<KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteObjectValue<AuditActivityInitiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("loggedByService", LoggedByService);
            writer.WriteStringValue("operationType", OperationType);
            writer.WriteEnumValue<OperationResult>("result", Result);
            writer.WriteStringValue("resultReason", ResultReason);
            writer.WriteCollectionOfObjectValues<TargetResource>("targetResources", TargetResources);
            writer.WriteStringValue("userAgent", UserAgent);
        }
    }
}
