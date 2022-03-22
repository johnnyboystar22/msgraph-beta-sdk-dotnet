using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignmentPolicy : Entity, IParsable {
        /// <summary>The access package with this policy. Read-only. Nullable. Supports $expand.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageCatalog AccessPackageCatalog { get; set; }
        /// <summary>Identifier of the access package.</summary>
        public string AccessPackageId { get; set; }
        /// <summary>Who must review, and how often, the assignments to the access package from this policy. This property is null if reviews are not required.</summary>
        public AssignmentReviewSettings AccessReviewSettings { get; set; }
        /// <summary>Indicates whether a user can extend the access package assignment duration after approval.</summary>
        public bool? CanExtend { get; set; }
        /// <summary>Read-only.</summary>
        public string CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
        public List<CustomExtensionHandler> CustomExtensionHandlers { get; set; }
        /// <summary>The description of the policy.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the policy. Supports $filter (eq).</summary>
        public string DisplayName { get; set; }
        /// <summary>The number of days in which assignments from this policy last until they are expired.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Read-only.</summary>
        public string ModifiedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Questions that are posed to the  requestor.</summary>
        public List<AccessPackageQuestion> Questions { get; set; }
        /// <summary>Who must approve requests for access package in this policy.</summary>
        public ApprovalSettings RequestApprovalSettings { get; set; }
        /// <summary>Who can request this access package from this policy.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RequestorSettings RequestorSettings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignmentPolicy).AccessPackage = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackage>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackage.CreateFromDiscriminatorValue); } },
                {"accessPackageCatalog", (o,n) => { (o as AccessPackageAssignmentPolicy).AccessPackageCatalog = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageCatalog>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"accessPackageId", (o,n) => { (o as AccessPackageAssignmentPolicy).AccessPackageId = n.GetStringValue(); } },
                {"accessReviewSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).AccessReviewSettings = n.GetObjectValue<AssignmentReviewSettings>(AssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                {"canExtend", (o,n) => { (o as AccessPackageAssignmentPolicy).CanExtend = n.GetBoolValue(); } },
                {"createdBy", (o,n) => { (o as AccessPackageAssignmentPolicy).CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionHandlers", (o,n) => { (o as AccessPackageAssignmentPolicy).CustomExtensionHandlers = n.GetCollectionOfObjectValues<CustomExtensionHandler>(CustomExtensionHandler.CreateFromDiscriminatorValue).ToList(); } },
                {"description", (o,n) => { (o as AccessPackageAssignmentPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageAssignmentPolicy).DisplayName = n.GetStringValue(); } },
                {"durationInDays", (o,n) => { (o as AccessPackageAssignmentPolicy).DurationInDays = n.GetIntValue(); } },
                {"expirationDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedBy", (o,n) => { (o as AccessPackageAssignmentPolicy).ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"questions", (o,n) => { (o as AccessPackageAssignmentPolicy).Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"requestApprovalSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).RequestApprovalSettings = n.GetObjectValue<ApprovalSettings>(ApprovalSettings.CreateFromDiscriminatorValue); } },
                {"requestorSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).RequestorSettings = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.RequestorSettings>(MicrosoftGraphSdk.Models.Microsoft.Graph.RequestorSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageCatalog>("accessPackageCatalog", AccessPackageCatalog);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
            writer.WriteObjectValue<AssignmentReviewSettings>("accessReviewSettings", AccessReviewSettings);
            writer.WriteBoolValue("canExtend", CanExtend);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandler>("customExtensionHandlers", CustomExtensionHandlers);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<ApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.RequestorSettings>("requestorSettings", RequestorSettings);
        }
    }
}
