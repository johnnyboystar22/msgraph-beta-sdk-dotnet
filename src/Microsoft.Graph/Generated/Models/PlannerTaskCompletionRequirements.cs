// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [Flags]
    #pragma warning disable CS1591
    public enum PlannerTaskCompletionRequirements
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "checklistCompletion")]
        #pragma warning disable CS1591
        ChecklistCompletion = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "formCompletion")]
        #pragma warning disable CS1591
        FormCompletion = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "approvalCompletion")]
        #pragma warning disable CS1591
        ApprovalCompletion = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "completionInHostedApp")]
        #pragma warning disable CS1591
        CompletionInHostedApp = 32,
        #pragma warning restore CS1591
    }
}
