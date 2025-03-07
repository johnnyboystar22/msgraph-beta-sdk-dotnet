// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    #pragma warning disable CS1591
    public class IndustryDataRoot : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Set of connectors for importing data from source systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector>? DataConnectors
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector>?>("dataConnectors"); }
            set { BackingStore?.Set("dataConnectors", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector> DataConnectors
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector>>("dataConnectors"); }
            set { BackingStore?.Set("dataConnectors", value); }
        }
#endif
        /// <summary>Set of data import flow activities to bring data into the canonical store via a connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.InboundFlow>? InboundFlows
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.InboundFlow>?>("inboundFlows"); }
            set { BackingStore?.Set("inboundFlows", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.InboundFlow> InboundFlows
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.InboundFlow>>("inboundFlows"); }
            set { BackingStore?.Set("inboundFlows", value); }
        }
#endif
        /// <summary>Set of ephemeral operations that the system runs currently. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.LongRunningOperation>? Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LongRunningOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.LongRunningOperation> Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LongRunningOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The outboundProvisioningFlowSets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet>? OutboundProvisioningFlowSets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet>?>("outboundProvisioningFlowSets"); }
            set { BackingStore?.Set("outboundProvisioningFlowSets", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet> OutboundProvisioningFlowSets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet>>("outboundProvisioningFlowSets"); }
            set { BackingStore?.Set("outboundProvisioningFlowSets", value); }
        }
#endif
        /// <summary>Set of user modifiable system picker types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition>? ReferenceDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition>?>("referenceDefinitions"); }
            set { BackingStore?.Set("referenceDefinitions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition> ReferenceDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition>>("referenceDefinitions"); }
            set { BackingStore?.Set("referenceDefinitions", value); }
        }
#endif
        /// <summary>Set of groups of individual roles that makes role-based admin simpler.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>? RoleGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>?>("roleGroups"); }
            set { BackingStore?.Set("roleGroups", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup> RoleGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>>("roleGroups"); }
            set { BackingStore?.Set("roleGroups", value); }
        }
#endif
        /// <summary>Set of ephemeral runs which present the point-in-time that diagnostic state of activities performed by the system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun>? Runs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun>?>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun> Runs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun>>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
#endif
        /// <summary>Set of source definitions that represents real-world external systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition>? SourceSystems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition>?>("sourceSystems"); }
            set { BackingStore?.Set("sourceSystems", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition> SourceSystems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition>>("sourceSystems"); }
            set { BackingStore?.Set("sourceSystems", value); }
        }
#endif
        /// <summary>Set of years represented in the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition>? Years
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition>?>("years"); }
            set { BackingStore?.Set("years", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition> Years
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition>>("years"); }
            set { BackingStore?.Set("years", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dataConnectors", n => { DataConnectors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                { "inboundFlows", n => { InboundFlows = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.InboundFlow>(Microsoft.Graph.Beta.Models.IndustryData.InboundFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LongRunningOperation>(Microsoft.Graph.Beta.Models.LongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "outboundProvisioningFlowSets", n => { OutboundProvisioningFlowSets = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet>(Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet.CreateFromDiscriminatorValue)?.ToList(); } },
                { "referenceDefinitions", n => { ReferenceDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition>(Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleGroups", n => { RoleGroups = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>(Microsoft.Graph.Beta.Models.IndustryData.RoleGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                { "runs", n => { Runs = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sourceSystems", n => { SourceSystems = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition>(Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "years", n => { Years = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition>(Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector>("dataConnectors", DataConnectors);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.InboundFlow>("inboundFlows", InboundFlows);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.OutboundProvisioningFlowSet>("outboundProvisioningFlowSets", OutboundProvisioningFlowSets);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.ReferenceDefinition>("referenceDefinitions", ReferenceDefinitions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>("roleGroups", RoleGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRun>("runs", Runs);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.SourceSystemDefinition>("sourceSystems", SourceSystems);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition>("years", Years);
        }
    }
}
