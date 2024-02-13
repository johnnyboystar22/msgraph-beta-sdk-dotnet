// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OrganizationSettings : Entity, IParsable {
        /// <summary>Contains the properties that are configured by an administrator as a tenant-level privacy control whether to identify duplicate contacts among a user&apos;s contacts list and suggest the user to merge those contacts to have a cleaner contacts list. List contactInsights returns the settings to display or return contact insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InsightsSettings? ContactInsights {
            get { return BackingStore?.Get<InsightsSettings?>("contactInsights"); }
            set { BackingStore?.Set("contactInsights", value); }
        }
#nullable restore
#else
        public InsightsSettings ContactInsights {
            get { return BackingStore?.Get<InsightsSettings>("contactInsights"); }
            set { BackingStore?.Set("contactInsights", value); }
        }
#endif
        /// <summary>Contains the properties that are configured by an administrator for the visibility of Microsoft Graph-derived insights, between a user and other items in Microsoft 365, such as documents or sites. List itemInsights returns the settings to display or return item insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InsightsSettings? ItemInsights {
            get { return BackingStore?.Get<InsightsSettings?>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
#nullable restore
#else
        public InsightsSettings ItemInsights {
            get { return BackingStore?.Get<InsightsSettings>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
#endif
        /// <summary>The microsoftApplicationDataAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MicrosoftApplicationDataAccessSettings? MicrosoftApplicationDataAccess {
            get { return BackingStore?.Get<MicrosoftApplicationDataAccessSettings?>("microsoftApplicationDataAccess"); }
            set { BackingStore?.Set("microsoftApplicationDataAccess", value); }
        }
#nullable restore
#else
        public MicrosoftApplicationDataAccessSettings MicrosoftApplicationDataAccess {
            get { return BackingStore?.Get<MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess"); }
            set { BackingStore?.Set("microsoftApplicationDataAccess", value); }
        }
#endif
        /// <summary>Contains the properties that are configured by an administrator for the visibility of a list of people relevant and working with a user in Microsoft 365. List peopleInsights returns the settings to display or return people insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InsightsSettings? PeopleInsights {
            get { return BackingStore?.Get<InsightsSettings?>("peopleInsights"); }
            set { BackingStore?.Set("peopleInsights", value); }
        }
#nullable restore
#else
        public InsightsSettings PeopleInsights {
            get { return BackingStore?.Get<InsightsSettings>("peopleInsights"); }
            set { BackingStore?.Set("peopleInsights", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OrganizationSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OrganizationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contactInsights", n => { ContactInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"itemInsights", n => { ItemInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"microsoftApplicationDataAccess", n => { MicrosoftApplicationDataAccess = n.GetObjectValue<MicrosoftApplicationDataAccessSettings>(MicrosoftApplicationDataAccessSettings.CreateFromDiscriminatorValue); } },
                {"peopleInsights", n => { PeopleInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<InsightsSettings>("contactInsights", ContactInsights);
            writer.WriteObjectValue<InsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess", MicrosoftApplicationDataAccess);
            writer.WriteObjectValue<InsightsSettings>("peopleInsights", PeopleInsights);
        }
    }
}
