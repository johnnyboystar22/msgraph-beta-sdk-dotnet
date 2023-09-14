// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AccessReviewInstanceRequestBuilder.
    /// </summary>
    public partial class AccessReviewInstanceRequestBuilder : EntityRequestBuilder, IAccessReviewInstanceRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessReviewInstanceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewInstanceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAccessReviewInstanceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAccessReviewInstanceRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewInstanceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ContactedReviewers.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceContactedReviewersCollectionRequestBuilder"/>.</returns>
        public IAccessReviewInstanceContactedReviewersCollectionRequestBuilder ContactedReviewers
        {
            get
            {
                return new AccessReviewInstanceContactedReviewersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("contactedReviewers"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Decisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceDecisionsCollectionRequestBuilder"/>.</returns>
        public IAccessReviewInstanceDecisionsCollectionRequestBuilder Decisions
        {
            get
            {
                return new AccessReviewInstanceDecisionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("decisions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Definition.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewScheduleDefinitionWithReferenceRequestBuilder"/>.</returns>
        public IAccessReviewScheduleDefinitionWithReferenceRequestBuilder Definition
        {
            get
            {
                return new AccessReviewScheduleDefinitionWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("definition"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Stages.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceStagesCollectionRequestBuilder"/>.</returns>
        public IAccessReviewInstanceStagesCollectionRequestBuilder Stages
        {
            get
            {
                return new AccessReviewInstanceStagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("stages"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for AccessReviewInstanceStop.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceStopRequestBuilder"/>.</returns>
        public IAccessReviewInstanceStopRequestBuilder Stop()
        {
            return new AccessReviewInstanceStopRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.stop"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceAcceptRecommendations.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceAcceptRecommendationsRequestBuilder"/>.</returns>
        public IAccessReviewInstanceAcceptRecommendationsRequestBuilder AcceptRecommendations()
        {
            return new AccessReviewInstanceAcceptRecommendationsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.acceptRecommendations"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceApplyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceApplyDecisionsRequestBuilder"/>.</returns>
        public IAccessReviewInstanceApplyDecisionsRequestBuilder ApplyDecisions()
        {
            return new AccessReviewInstanceApplyDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyDecisions"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceBatchRecordDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceBatchRecordDecisionsRequestBuilder"/>.</returns>
        public IAccessReviewInstanceBatchRecordDecisionsRequestBuilder BatchRecordDecisions(
            string decision = null,
            string justification = null,
            string principalId = null,
            string resourceId = null)
        {
            return new AccessReviewInstanceBatchRecordDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.batchRecordDecisions"),
                this.Client,
                decision,
                justification,
                principalId,
                resourceId);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceResetDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceResetDecisionsRequestBuilder"/>.</returns>
        public IAccessReviewInstanceResetDecisionsRequestBuilder ResetDecisions()
        {
            return new AccessReviewInstanceResetDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.resetDecisions"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceSendReminder.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceSendReminderRequestBuilder"/>.</returns>
        public IAccessReviewInstanceSendReminderRequestBuilder SendReminder()
        {
            return new AccessReviewInstanceSendReminderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sendReminder"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceStopApplyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceStopApplyDecisionsRequestBuilder"/>.</returns>
        public IAccessReviewInstanceStopApplyDecisionsRequestBuilder StopApplyDecisions()
        {
            return new AccessReviewInstanceStopApplyDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.stopApplyDecisions"),
                this.Client);
        }
    
    }
}
