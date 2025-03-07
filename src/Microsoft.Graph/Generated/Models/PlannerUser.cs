// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PlannerUser : Microsoft.Graph.Beta.Models.PlannerDelta, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The all property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerDelta>? All
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerDelta>?>("all"); }
            set { BackingStore?.Set("all", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerDelta> All
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerDelta>>("all"); }
            set { BackingStore?.Set("all", value); }
        }
#endif
        /// <summary>A collection that contains the references to the plans that the user marked as favorites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection? FavoritePlanReferences
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection?>("favoritePlanReferences"); }
            set { BackingStore?.Set("favoritePlanReferences", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection FavoritePlanReferences
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection>("favoritePlanReferences"); }
            set { BackingStore?.Set("favoritePlanReferences", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerPlan>? FavoritePlans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>?>("favoritePlans"); }
            set { BackingStore?.Set("favoritePlans", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerPlan> FavoritePlans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>>("favoritePlans"); }
            set { BackingStore?.Set("favoritePlans", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns the plannerTasks to be shown in the My Day view of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerTask>? MyDayTasks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerTask>?>("myDayTasks"); }
            set { BackingStore?.Set("myDayTasks", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerTask> MyDayTasks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerTask>>("myDayTasks"); }
            set { BackingStore?.Set("myDayTasks", value); }
        }
#endif
        /// <summary>The plans property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerPlan>? Plans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>?>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerPlan> Plans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
#endif
        /// <summary>A collection that contains references to the plans that the user recently viewed in apps that support recent plans.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection? RecentPlanReferences
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection?>("recentPlanReferences"); }
            set { BackingStore?.Set("recentPlanReferences", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection RecentPlanReferences
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection>("recentPlanReferences"); }
            set { BackingStore?.Set("recentPlanReferences", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns the plannerPlans that the user recently viewed in apps that support recent plans.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerPlan>? RecentPlans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>?>("recentPlans"); }
            set { BackingStore?.Set("recentPlans", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerPlan> RecentPlans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>>("recentPlans"); }
            set { BackingStore?.Set("recentPlans", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns the plannerPlans contained by the plannerRosters the user is a member.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerPlan>? RosterPlans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>?>("rosterPlans"); }
            set { BackingStore?.Set("rosterPlans", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerPlan> RosterPlans
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlan>>("rosterPlans"); }
            set { BackingStore?.Set("rosterPlans", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerTask>? Tasks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerTask>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerTask> Tasks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PlannerUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.PlannerUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PlannerUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "all", n => { All = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerDelta>(Microsoft.Graph.Beta.Models.PlannerDelta.CreateFromDiscriminatorValue)?.ToList(); } },
                { "favoritePlanReferences", n => { FavoritePlanReferences = n.GetObjectValue<Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection>(Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection.CreateFromDiscriminatorValue); } },
                { "favoritePlans", n => { FavoritePlans = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>(Microsoft.Graph.Beta.Models.PlannerPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "myDayTasks", n => { MyDayTasks = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerTask>(Microsoft.Graph.Beta.Models.PlannerTask.CreateFromDiscriminatorValue)?.ToList(); } },
                { "plans", n => { Plans = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>(Microsoft.Graph.Beta.Models.PlannerPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "recentPlanReferences", n => { RecentPlanReferences = n.GetObjectValue<Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection>(Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection.CreateFromDiscriminatorValue); } },
                { "recentPlans", n => { RecentPlans = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>(Microsoft.Graph.Beta.Models.PlannerPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "rosterPlans", n => { RosterPlans = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>(Microsoft.Graph.Beta.Models.PlannerPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerTask>(Microsoft.Graph.Beta.Models.PlannerTask.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerDelta>("all", All);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PlannerFavoritePlanReferenceCollection>("favoritePlanReferences", FavoritePlanReferences);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>("favoritePlans", FavoritePlans);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerTask>("myDayTasks", MyDayTasks);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>("plans", Plans);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PlannerRecentPlanReferenceCollection>("recentPlanReferences", RecentPlanReferences);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>("recentPlans", RecentPlans);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlan>("rosterPlans", RosterPlans);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerTask>("tasks", Tasks);
        }
    }
}
