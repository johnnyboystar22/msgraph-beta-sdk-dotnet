using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventWebinar : VirtualEvent, IParsable {
        /// <summary>The audience property</summary>
        public MeetingAudience? Audience {
            get { return BackingStore?.Get<MeetingAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
        /// <summary>The coOrganizers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommunicationsUserIdentity>? CoOrganizers {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>?>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#nullable restore
#else
        public List<CommunicationsUserIdentity> CoOrganizers {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#endif
        /// <summary>The registration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VirtualEventRegistration? Registration {
            get { return BackingStore?.Get<VirtualEventRegistration?>("registration"); }
            set { BackingStore?.Set("registration", value); }
        }
#nullable restore
#else
        public VirtualEventRegistration Registration {
            get { return BackingStore?.Get<VirtualEventRegistration>("registration"); }
            set { BackingStore?.Set("registration", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventWebinar CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventWebinar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audience", n => { Audience = n.GetEnumValue<MeetingAudience>(); } },
                {"coOrganizers", n => { CoOrganizers = n.GetCollectionOfObjectValues<CommunicationsUserIdentity>(CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registration", n => { Registration = n.GetObjectValue<VirtualEventRegistration>(VirtualEventRegistration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MeetingAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<CommunicationsUserIdentity>("coOrganizers", CoOrganizers);
            writer.WriteObjectValue<VirtualEventRegistration>("registration", Registration);
        }
    }
}
