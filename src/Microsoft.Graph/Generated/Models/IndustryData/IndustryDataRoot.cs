using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class IndustryDataRoot : Entity, IParsable {
        /// <summary>Set of connectors for importing data from source systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataConnector>? DataConnectors {
            get { return BackingStore?.Get<List<IndustryDataConnector>?>("dataConnectors"); }
            set { BackingStore?.Set("dataConnectors", value); }
        }
#nullable restore
#else
        public List<IndustryDataConnector> DataConnectors {
            get { return BackingStore?.Get<List<IndustryDataConnector>>("dataConnectors"); }
            set { BackingStore?.Set("dataConnectors", value); }
        }
#endif
        /// <summary>Set of data import flow activities to bring data into the canonical store via a connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InboundFlow>? InboundFlows {
            get { return BackingStore?.Get<List<InboundFlow>?>("inboundFlows"); }
            set { BackingStore?.Set("inboundFlows", value); }
        }
#nullable restore
#else
        public List<InboundFlow> InboundFlows {
            get { return BackingStore?.Get<List<InboundFlow>>("inboundFlows"); }
            set { BackingStore?.Set("inboundFlows", value); }
        }
#endif
        /// <summary>Set of ephemeral operations that the system runs currently. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.LongRunningOperation>? Operations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LongRunningOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.LongRunningOperation> Operations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LongRunningOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Set of user modifiable system picker types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ReferenceDefinition>? ReferenceDefinitions {
            get { return BackingStore?.Get<List<ReferenceDefinition>?>("referenceDefinitions"); }
            set { BackingStore?.Set("referenceDefinitions", value); }
        }
#nullable restore
#else
        public List<ReferenceDefinition> ReferenceDefinitions {
            get { return BackingStore?.Get<List<ReferenceDefinition>>("referenceDefinitions"); }
            set { BackingStore?.Set("referenceDefinitions", value); }
        }
#endif
        /// <summary>Set of groups of individual roles that makes role-based admin simpler.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleGroup>? RoleGroups {
            get { return BackingStore?.Get<List<RoleGroup>?>("roleGroups"); }
            set { BackingStore?.Set("roleGroups", value); }
        }
#nullable restore
#else
        public List<RoleGroup> RoleGroups {
            get { return BackingStore?.Get<List<RoleGroup>>("roleGroups"); }
            set { BackingStore?.Set("roleGroups", value); }
        }
#endif
        /// <summary>Set of ephemeral runs which present the point-in-time that diagnostic state of activities performed by the system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataRun>? Runs {
            get { return BackingStore?.Get<List<IndustryDataRun>?>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
#nullable restore
#else
        public List<IndustryDataRun> Runs {
            get { return BackingStore?.Get<List<IndustryDataRun>>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
#endif
        /// <summary>Set of source definitions that represents real-world external systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SourceSystemDefinition>? SourceSystems {
            get { return BackingStore?.Get<List<SourceSystemDefinition>?>("sourceSystems"); }
            set { BackingStore?.Set("sourceSystems", value); }
        }
#nullable restore
#else
        public List<SourceSystemDefinition> SourceSystems {
            get { return BackingStore?.Get<List<SourceSystemDefinition>>("sourceSystems"); }
            set { BackingStore?.Set("sourceSystems", value); }
        }
#endif
        /// <summary>Set of years represented in the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<YearTimePeriodDefinition>? Years {
            get { return BackingStore?.Get<List<YearTimePeriodDefinition>?>("years"); }
            set { BackingStore?.Set("years", value); }
        }
#nullable restore
#else
        public List<YearTimePeriodDefinition> Years {
            get { return BackingStore?.Get<List<YearTimePeriodDefinition>>("years"); }
            set { BackingStore?.Set("years", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IndustryDataRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IndustryDataRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataConnectors", n => { DataConnectors = n.GetCollectionOfObjectValues<IndustryDataConnector>(IndustryDataConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"inboundFlows", n => { InboundFlows = n.GetCollectionOfObjectValues<InboundFlow>(InboundFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LongRunningOperation>(Microsoft.Graph.Beta.Models.LongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"referenceDefinitions", n => { ReferenceDefinitions = n.GetCollectionOfObjectValues<ReferenceDefinition>(ReferenceDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleGroups", n => { RoleGroups = n.GetCollectionOfObjectValues<RoleGroup>(RoleGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"runs", n => { Runs = n.GetCollectionOfObjectValues<IndustryDataRun>(IndustryDataRun.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sourceSystems", n => { SourceSystems = n.GetCollectionOfObjectValues<SourceSystemDefinition>(SourceSystemDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"years", n => { Years = n.GetCollectionOfObjectValues<YearTimePeriodDefinition>(YearTimePeriodDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IndustryDataConnector>("dataConnectors", DataConnectors);
            writer.WriteCollectionOfObjectValues<InboundFlow>("inboundFlows", InboundFlows);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ReferenceDefinition>("referenceDefinitions", ReferenceDefinitions);
            writer.WriteCollectionOfObjectValues<RoleGroup>("roleGroups", RoleGroups);
            writer.WriteCollectionOfObjectValues<IndustryDataRun>("runs", Runs);
            writer.WriteCollectionOfObjectValues<SourceSystemDefinition>("sourceSystems", SourceSystems);
            writer.WriteCollectionOfObjectValues<YearTimePeriodDefinition>("years", Years);
        }
    }
}
