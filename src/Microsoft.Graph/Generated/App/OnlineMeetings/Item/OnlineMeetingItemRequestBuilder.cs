// <auto-generated/>
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.AlternativeRecording;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.AttendanceReports;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.AttendeeReport;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.BroadcastRecording;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.GetVirtualAppointmentJoinWebUrl;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.MeetingAttendanceReport;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.Recording;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.Recordings;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.Registration;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.SendVirtualAppointmentReminderSms;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.SendVirtualAppointmentSms;
using Microsoft.Graph.Beta.App.OnlineMeetings.Item.Transcripts;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.App.OnlineMeetings.Item {
    /// <summary>
    /// Provides operations to manage the onlineMeetings property of the microsoft.graph.commsApplication entity.
    /// </summary>
    public class OnlineMeetingItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the media for the commsApplication entity.</summary>
        public AlternativeRecordingRequestBuilder AlternativeRecording
        {
            get => new AlternativeRecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attendanceReports property of the microsoft.graph.onlineMeetingBase entity.</summary>
        public AttendanceReportsRequestBuilder AttendanceReports
        {
            get => new AttendanceReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the commsApplication entity.</summary>
        public AttendeeReportRequestBuilder AttendeeReport
        {
            get => new AttendeeReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the commsApplication entity.</summary>
        public BroadcastRecordingRequestBuilder BroadcastRecording
        {
            get => new BroadcastRecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getVirtualAppointmentJoinWebUrl method.</summary>
        public GetVirtualAppointmentJoinWebUrlRequestBuilder GetVirtualAppointmentJoinWebUrl
        {
            get => new GetVirtualAppointmentJoinWebUrlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the meetingAttendanceReport property of the microsoft.graph.onlineMeeting entity.</summary>
        public MeetingAttendanceReportRequestBuilder MeetingAttendanceReport
        {
            get => new MeetingAttendanceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the commsApplication entity.</summary>
        public RecordingRequestBuilder Recording
        {
            get => new RecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recordings property of the microsoft.graph.onlineMeeting entity.</summary>
        public RecordingsRequestBuilder Recordings
        {
            get => new RecordingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the registration property of the microsoft.graph.onlineMeeting entity.</summary>
        public RegistrationRequestBuilder Registration
        {
            get => new RegistrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendVirtualAppointmentReminderSms method.</summary>
        public SendVirtualAppointmentReminderSmsRequestBuilder SendVirtualAppointmentReminderSms
        {
            get => new SendVirtualAppointmentReminderSmsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendVirtualAppointmentSms method.</summary>
        public SendVirtualAppointmentSmsRequestBuilder SendVirtualAppointmentSms
        {
            get => new SendVirtualAppointmentSmsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transcripts property of the microsoft.graph.onlineMeeting entity.</summary>
        public TranscriptsRequestBuilder Transcripts
        {
            get => new TranscriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="OnlineMeetingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnlineMeetingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/onlineMeetings/{onlineMeeting%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="OnlineMeetingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnlineMeetingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/onlineMeetings/{onlineMeeting%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property onlineMeetings for app
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get onlineMeetings from app
        /// </summary>
        /// <returns>A <see cref="OnlineMeeting"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OnlineMeeting?> GetAsync(Action<RequestConfiguration<OnlineMeetingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<OnlineMeeting> GetAsync(Action<RequestConfiguration<OnlineMeetingItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OnlineMeeting>(requestInfo, OnlineMeeting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property onlineMeetings in app
        /// </summary>
        /// <returns>A <see cref="OnlineMeeting"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OnlineMeeting?> PatchAsync(OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<OnlineMeeting> PatchAsync(OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OnlineMeeting>(requestInfo, OnlineMeeting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property onlineMeetings for app
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get onlineMeetings from app
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OnlineMeetingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OnlineMeetingItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property onlineMeetings in app
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="OnlineMeetingItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OnlineMeetingItemRequestBuilder WithUrl(string rawUrl)
        {
            return new OnlineMeetingItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OnlineMeetingItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Get onlineMeetings from app
        /// </summary>
        public class OnlineMeetingItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OnlineMeetingItemRequestBuilderGetRequestConfiguration : RequestConfiguration<OnlineMeetingItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OnlineMeetingItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
