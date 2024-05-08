// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class CloudPcOnPremisesConnectionStatusDetail : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The end time of the connection health check. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>All checks that are done on the connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcOnPremisesConnectionHealthCheck>? HealthChecks {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnectionHealthCheck>?>("healthChecks"); }
            set { BackingStore?.Set("healthChecks", value); }
        }
#nullable restore
#else
        public List<CloudPcOnPremisesConnectionHealthCheck> HealthChecks {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnectionHealthCheck>>("healthChecks"); }
            set { BackingStore?.Set("healthChecks", value); }
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
        /// <summary>The start time of the connection health check. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="CloudPcOnPremisesConnectionStatusDetail"/> and sets the default values.
        /// </summary>
        public CloudPcOnPremisesConnectionStatusDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcOnPremisesConnectionStatusDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcOnPremisesConnectionStatusDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOnPremisesConnectionStatusDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"healthChecks", n => { HealthChecks = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnectionHealthCheck>(CloudPcOnPremisesConnectionHealthCheck.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<CloudPcOnPremisesConnectionHealthCheck>("healthChecks", HealthChecks);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
