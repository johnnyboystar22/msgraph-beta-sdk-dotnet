// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ScheduleInformation : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free, 1= tentative, 2= busy, 3= out of office, 4= working elsewhere.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailabilityView
        {
            get { return BackingStore?.Get<string?>("availabilityView"); }
            set { BackingStore?.Set("availabilityView", value); }
        }
#nullable restore
#else
        public string AvailabilityView
        {
            get { return BackingStore?.Get<string>("availabilityView"); }
            set { BackingStore?.Set("availabilityView", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Error information from attempting to get the availability of the user, distribution list, or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.FreeBusyError? Error
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FreeBusyError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.FreeBusyError Error
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FreeBusyError>("error"); }
            set { BackingStore?.Set("error", value); }
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
        /// <summary>An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScheduleId
        {
            get { return BackingStore?.Get<string?>("scheduleId"); }
            set { BackingStore?.Set("scheduleId", value); }
        }
#nullable restore
#else
        public string ScheduleId
        {
            get { return BackingStore?.Get<string>("scheduleId"); }
            set { BackingStore?.Set("scheduleId", value); }
        }
#endif
        /// <summary>Contains the items that describe the availability of the user or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ScheduleItem>? ScheduleItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ScheduleItem>?>("scheduleItems"); }
            set { BackingStore?.Set("scheduleItems", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ScheduleItem> ScheduleItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ScheduleItem>>("scheduleItems"); }
            set { BackingStore?.Set("scheduleItems", value); }
        }
#endif
        /// <summary>The days of the week and hours in a specific time zone that the user works. These are set as part of the user&apos;s mailboxSettings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WorkingHours? WorkingHours
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkingHours?>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WorkingHours WorkingHours
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ScheduleInformation"/> and sets the default values.
        /// </summary>
        public ScheduleInformation()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ScheduleInformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.ScheduleInformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ScheduleInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "availabilityView", n => { AvailabilityView = n.GetStringValue(); } },
                { "error", n => { Error = n.GetObjectValue<Microsoft.Graph.Beta.Models.FreeBusyError>(Microsoft.Graph.Beta.Models.FreeBusyError.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "scheduleId", n => { ScheduleId = n.GetStringValue(); } },
                { "scheduleItems", n => { ScheduleItems = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ScheduleItem>(Microsoft.Graph.Beta.Models.ScheduleItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "workingHours", n => { WorkingHours = n.GetObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>(Microsoft.Graph.Beta.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availabilityView", AvailabilityView);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.FreeBusyError>("error", Error);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("scheduleId", ScheduleId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ScheduleItem>("scheduleItems", ScheduleItems);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
