// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Privileged Access Group Assignment Schedule Request.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrivilegedAccessGroupAssignmentScheduleRequestObject>))]
    public partial class PrivilegedAccessGroupAssignmentScheduleRequestObject : PrivilegedAccessScheduleRequestObject
    {
    
        ///<summary>
        /// The PrivilegedAccessGroupAssignmentScheduleRequest constructor
        ///</summary>
        public PrivilegedAccessGroupAssignmentScheduleRequestObject()
        {
            this.ODataType = "microsoft.graph.privilegedAccessGroupAssignmentScheduleRequest";
        }

        /// <summary>
        /// Gets or sets access id.
        /// The identifier of a membership or ownership assignment relationship to the group. Required. The possible values are: owner, member, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("accessId")]
        public PrivilegedAccessGroupRelationships? AccessId { get; set; }
    
        /// <summary>
        /// Gets or sets group id.
        /// The identifier of the group representing the scope of the membership or ownership assignment through PIM for groups. Required.
        /// </summary>
        [JsonPropertyName("groupId")]
        public string GroupId { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// The identifier of the principal whose membership or ownership assignment to the group is managed through PIM for groups. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("principalId")]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets target schedule id.
        /// The identifier of the schedule that's created from the membership or ownership assignment request. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("targetScheduleId")]
        public string TargetScheduleId { get; set; }
    
        /// <summary>
        /// Gets or sets activated using.
        /// When the request activates a membership or ownership assignment in PIM for groups, this object represents the eligibility policy for the group. Otherwise, it is null. Supports $expand.
        /// </summary>
        [JsonPropertyName("activatedUsing")]
        public PrivilegedAccessGroupEligibilitySchedule ActivatedUsing { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// References the group that is the scope of the membership or ownership assignment request through PIM for groups. Supports $expand.
        /// </summary>
        [JsonPropertyName("group")]
        public Group Group { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// References the principal that's in the scope of this membership or ownership assignment request through the group that's governed by PIM. Supports $expand.
        /// </summary>
        [JsonPropertyName("principal")]
        public DirectoryObject Principal { get; set; }
    
        /// <summary>
        /// Gets or sets target schedule.
        /// Schedule created by this request. Supports $expand.
        /// </summary>
        [JsonPropertyName("targetSchedule")]
        public PrivilegedAccessGroupEligibilitySchedule TargetSchedule { get; set; }
    
    }
}

