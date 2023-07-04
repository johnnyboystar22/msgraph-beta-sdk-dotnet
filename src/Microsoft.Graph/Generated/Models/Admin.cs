using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Admin : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appsAndServices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminAppsAndServices? AppsAndServices {
            get { return BackingStore?.Get<AdminAppsAndServices?>("appsAndServices"); }
            set { BackingStore?.Set("appsAndServices", value); }
        }
#nullable restore
#else
        public AdminAppsAndServices AppsAndServices {
            get { return BackingStore?.Get<AdminAppsAndServices>("appsAndServices"); }
            set { BackingStore?.Set("appsAndServices", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The dynamics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminDynamics? Dynamics {
            get { return BackingStore?.Get<AdminDynamics?>("dynamics"); }
            set { BackingStore?.Set("dynamics", value); }
        }
#nullable restore
#else
        public AdminDynamics Dynamics {
            get { return BackingStore?.Get<AdminDynamics>("dynamics"); }
            set { BackingStore?.Set("dynamics", value); }
        }
#endif
        /// <summary>A container for Microsoft Edge resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Edge? Edge {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Edge?>("edge"); }
            set { BackingStore?.Set("edge", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Edge Edge {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Edge>("edge"); }
            set { BackingStore?.Set("edge", value); }
        }
#endif
        /// <summary>The forms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminForms? Forms {
            get { return BackingStore?.Get<AdminForms?>("forms"); }
            set { BackingStore?.Set("forms", value); }
        }
#nullable restore
#else
        public AdminForms Forms {
            get { return BackingStore?.Get<AdminForms>("forms"); }
            set { BackingStore?.Set("forms", value); }
        }
#endif
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
        /// <summary>A container for administrative resources to manage reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminReportSettings? ReportSettings {
            get { return BackingStore?.Get<AdminReportSettings?>("reportSettings"); }
            set { BackingStore?.Set("reportSettings", value); }
        }
#nullable restore
#else
        public AdminReportSettings ReportSettings {
            get { return BackingStore?.Get<AdminReportSettings>("reportSettings"); }
            set { BackingStore?.Set("reportSettings", value); }
        }
#endif
        /// <summary>A container for service communications resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ServiceAnnouncement? ServiceAnnouncement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceAnnouncement?>("serviceAnnouncement"); }
            set { BackingStore?.Set("serviceAnnouncement", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ServiceAnnouncement ServiceAnnouncement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement"); }
            set { BackingStore?.Set("serviceAnnouncement", value); }
        }
#endif
        /// <summary>The sharepoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Sharepoint? Sharepoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Sharepoint?>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Sharepoint Sharepoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Sharepoint>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#endif
        /// <summary>The todo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminTodo? Todo {
            get { return BackingStore?.Get<AdminTodo?>("todo"); }
            set { BackingStore?.Set("todo", value); }
        }
#nullable restore
#else
        public AdminTodo Todo {
            get { return BackingStore?.Get<AdminTodo>("todo"); }
            set { BackingStore?.Set("todo", value); }
        }
#endif
        /// <summary>A container for all Windows administrator functionalities. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminWindows? Windows {
            get { return BackingStore?.Get<AdminWindows?>("windows"); }
            set { BackingStore?.Set("windows", value); }
        }
#nullable restore
#else
        public AdminWindows Windows {
            get { return BackingStore?.Get<AdminWindows>("windows"); }
            set { BackingStore?.Set("windows", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Admin and sets the default values.
        /// </summary>
        public Admin() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Admin CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Admin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appsAndServices", n => { AppsAndServices = n.GetObjectValue<AdminAppsAndServices>(AdminAppsAndServices.CreateFromDiscriminatorValue); } },
                {"dynamics", n => { Dynamics = n.GetObjectValue<AdminDynamics>(AdminDynamics.CreateFromDiscriminatorValue); } },
                {"edge", n => { Edge = n.GetObjectValue<Microsoft.Graph.Beta.Models.Edge>(Microsoft.Graph.Beta.Models.Edge.CreateFromDiscriminatorValue); } },
                {"forms", n => { Forms = n.GetObjectValue<AdminForms>(AdminForms.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reportSettings", n => { ReportSettings = n.GetObjectValue<AdminReportSettings>(AdminReportSettings.CreateFromDiscriminatorValue); } },
                {"serviceAnnouncement", n => { ServiceAnnouncement = n.GetObjectValue<Microsoft.Graph.Beta.Models.ServiceAnnouncement>(Microsoft.Graph.Beta.Models.ServiceAnnouncement.CreateFromDiscriminatorValue); } },
                {"sharepoint", n => { Sharepoint = n.GetObjectValue<Microsoft.Graph.Beta.Models.Sharepoint>(Microsoft.Graph.Beta.Models.Sharepoint.CreateFromDiscriminatorValue); } },
                {"todo", n => { Todo = n.GetObjectValue<AdminTodo>(AdminTodo.CreateFromDiscriminatorValue); } },
                {"windows", n => { Windows = n.GetObjectValue<AdminWindows>(AdminWindows.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AdminAppsAndServices>("appsAndServices", AppsAndServices);
            writer.WriteObjectValue<AdminDynamics>("dynamics", Dynamics);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Edge>("edge", Edge);
            writer.WriteObjectValue<AdminForms>("forms", Forms);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AdminReportSettings>("reportSettings", ReportSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement", ServiceAnnouncement);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Sharepoint>("sharepoint", Sharepoint);
            writer.WriteObjectValue<AdminTodo>("todo", Todo);
            writer.WriteObjectValue<AdminWindows>("windows", Windows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
