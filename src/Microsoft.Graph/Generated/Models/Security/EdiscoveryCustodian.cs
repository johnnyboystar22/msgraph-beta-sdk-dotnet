// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class EdiscoveryCustodian : Microsoft.Graph.Beta.Models.Security.DataSourceContainer, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time the custodian acknowledged a hold notification.</summary>
        public DateTimeOffset? AcknowledgedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("acknowledgedDateTime"); }
            set { BackingStore?.Set("acknowledgedDateTime", value); }
        }
        /// <summary>Email address of the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>Operation entity that represents the latest indexing for the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation? LastIndexOperation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation?>("lastIndexOperation"); }
            set { BackingStore?.Set("lastIndexOperation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation LastIndexOperation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation>("lastIndexOperation"); }
            set { BackingStore?.Set("lastIndexOperation", value); }
        }
#endif
        /// <summary>Data source entity for SharePoint sites associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.SiteSource>? SiteSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.SiteSource>?>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.SiteSource> SiteSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.SiteSource>>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#endif
        /// <summary>Data source entity for groups associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource>? UnifiedGroupSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource>?>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource> UnifiedGroupSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource>>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#endif
        /// <summary>Data source entity for a custodian. This is the container for a custodian&apos;s mailbox and OneDrive for Business site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.UserSource>? UserSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.UserSource>?>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.UserSource> UserSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.UserSource>>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian"/> and sets the default values.
        /// </summary>
        public EdiscoveryCustodian() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoveryCustodian";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acknowledgedDateTime", n => { AcknowledgedDateTime = n.GetDateTimeOffsetValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "lastIndexOperation", n => { LastIndexOperation = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation>(Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation.CreateFromDiscriminatorValue); } },
                { "siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.SiteSource>(Microsoft.Graph.Beta.Models.Security.SiteSource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource>(Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userSources", n => { UserSources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.UserSource>(Microsoft.Graph.Beta.Models.Security.UserSource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("acknowledgedDateTime", AcknowledgedDateTime);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryIndexOperation>("lastIndexOperation", LastIndexOperation);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.UserSource>("userSources", UserSources);
        }
    }
}
