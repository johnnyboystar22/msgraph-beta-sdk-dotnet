// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords
{
    #pragma warning disable CS1591
    public class DirectRoutingLogRow : Microsoft.Graph.Beta.Models.CallRecords.CallLogRow, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Number of the user or bot who received the call (E.164 format, but might include more data).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalleeNumber
        {
            get { return BackingStore?.Get<string?>("calleeNumber"); }
            set { BackingStore?.Set("calleeNumber", value); }
        }
#nullable restore
#else
        public string CalleeNumber
        {
            get { return BackingStore?.Get<string>("calleeNumber"); }
            set { BackingStore?.Set("calleeNumber", value); }
        }
#endif
        /// <summary>In addition to the SIP codes, Microsoft has own subcodes that indicate the specific issue.</summary>
        public int? CallEndSubReason
        {
            get { return BackingStore?.Get<int?>("callEndSubReason"); }
            set { BackingStore?.Set("callEndSubReason", value); }
        }
        /// <summary>Number of the user or bot who made the call (E.164 format, but might include more data).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallerNumber
        {
            get { return BackingStore?.Get<string?>("callerNumber"); }
            set { BackingStore?.Set("callerNumber", value); }
        }
#nullable restore
#else
        public string CallerNumber
        {
            get { return BackingStore?.Get<string>("callerNumber"); }
            set { BackingStore?.Set("callerNumber", value); }
        }
#endif
        /// <summary>Call type and direction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallType
        {
            get { return BackingStore?.Get<string?>("callType"); }
            set { BackingStore?.Set("callType", value); }
        }
#nullable restore
#else
        public string CallType
        {
            get { return BackingStore?.Get<string>("callType"); }
            set { BackingStore?.Set("callType", value); }
        }
#endif
        /// <summary>Identifier (GUID) for the call that you can use when calling Microsoft Support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>Duration of the call in seconds.</summary>
        public int? Duration
        {
            get { return BackingStore?.Get<int?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>Only exists for successful (fully established) calls. The time when the call ended.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Only exists for failed (not fully established) calls.</summary>
        public DateTimeOffset? FailureDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("failureDateTime"); }
            set { BackingStore?.Set("failureDateTime", value); }
        }
        /// <summary>The final response code with which the call ended (RFC 3261).</summary>
        public int? FinalSipCode
        {
            get { return BackingStore?.Get<int?>("finalSipCode"); }
            set { BackingStore?.Set("finalSipCode", value); }
        }
        /// <summary>Description of the SIP code and Microsoft subcode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FinalSipCodePhrase
        {
            get { return BackingStore?.Get<string?>("finalSipCodePhrase"); }
            set { BackingStore?.Set("finalSipCodePhrase", value); }
        }
#nullable restore
#else
        public string FinalSipCodePhrase
        {
            get { return BackingStore?.Get<string>("finalSipCodePhrase"); }
            set { BackingStore?.Set("finalSipCodePhrase", value); }
        }
#endif
        /// <summary>The date and time when the initial invite was sent.</summary>
        public DateTimeOffset? InviteDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("inviteDateTime"); }
            set { BackingStore?.Set("inviteDateTime", value); }
        }
        /// <summary>Indicates if the trunk was enabled for media bypass or not.</summary>
        public bool? MediaBypassEnabled
        {
            get { return BackingStore?.Get<bool?>("mediaBypassEnabled"); }
            set { BackingStore?.Set("mediaBypassEnabled", value); }
        }
        /// <summary>The data center used for media path in non-bypass call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaPathLocation
        {
            get { return BackingStore?.Get<string?>("mediaPathLocation"); }
            set { BackingStore?.Set("mediaPathLocation", value); }
        }
#nullable restore
#else
        public string MediaPathLocation
        {
            get { return BackingStore?.Get<string>("mediaPathLocation"); }
            set { BackingStore?.Set("mediaPathLocation", value); }
        }
#endif
        /// <summary>The data center used for signaling for both bypass and non-bypass calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignalingLocation
        {
            get { return BackingStore?.Get<string?>("signalingLocation"); }
            set { BackingStore?.Set("signalingLocation", value); }
        }
#nullable restore
#else
        public string SignalingLocation
        {
            get { return BackingStore?.Get<string>("signalingLocation"); }
            set { BackingStore?.Set("signalingLocation", value); }
        }
#endif
        /// <summary>Call start time.For failed and unanswered calls, this value can be equal to invite or failure time.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Success or attempt.</summary>
        public bool? SuccessfulCall
        {
            get { return BackingStore?.Get<bool?>("successfulCall"); }
            set { BackingStore?.Set("successfulCall", value); }
        }
        /// <summary>Correlation ID of the call to the transferor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransferorCorrelationId
        {
            get { return BackingStore?.Get<string?>("transferorCorrelationId"); }
            set { BackingStore?.Set("transferorCorrelationId", value); }
        }
#nullable restore
#else
        public string TransferorCorrelationId
        {
            get { return BackingStore?.Get<string>("transferorCorrelationId"); }
            set { BackingStore?.Set("transferorCorrelationId", value); }
        }
#endif
        /// <summary>Fully qualified domain name of the session border controller.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrunkFullyQualifiedDomainName
        {
            get { return BackingStore?.Get<string?>("trunkFullyQualifiedDomainName"); }
            set { BackingStore?.Set("trunkFullyQualifiedDomainName", value); }
        }
#nullable restore
#else
        public string TrunkFullyQualifiedDomainName
        {
            get { return BackingStore?.Get<string>("trunkFullyQualifiedDomainName"); }
            set { BackingStore?.Set("trunkFullyQualifiedDomainName", value); }
        }
#endif
        /// <summary>Country/region code of the user. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserCountryCode
        {
            get { return BackingStore?.Get<string?>("userCountryCode"); }
            set { BackingStore?.Set("userCountryCode", value); }
        }
#nullable restore
#else
        public string UserCountryCode
        {
            get { return BackingStore?.Get<string>("userCountryCode"); }
            set { BackingStore?.Set("userCountryCode", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CallRecords.DirectRoutingLogRow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.CallRecords.DirectRoutingLogRow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CallRecords.DirectRoutingLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callEndSubReason", n => { CallEndSubReason = n.GetIntValue(); } },
                { "callType", n => { CallType = n.GetStringValue(); } },
                { "calleeNumber", n => { CalleeNumber = n.GetStringValue(); } },
                { "callerNumber", n => { CallerNumber = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "duration", n => { Duration = n.GetIntValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "failureDateTime", n => { FailureDateTime = n.GetDateTimeOffsetValue(); } },
                { "finalSipCode", n => { FinalSipCode = n.GetIntValue(); } },
                { "finalSipCodePhrase", n => { FinalSipCodePhrase = n.GetStringValue(); } },
                { "inviteDateTime", n => { InviteDateTime = n.GetDateTimeOffsetValue(); } },
                { "mediaBypassEnabled", n => { MediaBypassEnabled = n.GetBoolValue(); } },
                { "mediaPathLocation", n => { MediaPathLocation = n.GetStringValue(); } },
                { "signalingLocation", n => { SignalingLocation = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "successfulCall", n => { SuccessfulCall = n.GetBoolValue(); } },
                { "transferorCorrelationId", n => { TransferorCorrelationId = n.GetStringValue(); } },
                { "trunkFullyQualifiedDomainName", n => { TrunkFullyQualifiedDomainName = n.GetStringValue(); } },
                { "userCountryCode", n => { UserCountryCode = n.GetStringValue(); } },
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
            writer.WriteStringValue("calleeNumber", CalleeNumber);
            writer.WriteIntValue("callEndSubReason", CallEndSubReason);
            writer.WriteStringValue("callerNumber", CallerNumber);
            writer.WriteStringValue("callType", CallType);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteIntValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("failureDateTime", FailureDateTime);
            writer.WriteIntValue("finalSipCode", FinalSipCode);
            writer.WriteStringValue("finalSipCodePhrase", FinalSipCodePhrase);
            writer.WriteDateTimeOffsetValue("inviteDateTime", InviteDateTime);
            writer.WriteBoolValue("mediaBypassEnabled", MediaBypassEnabled);
            writer.WriteStringValue("mediaPathLocation", MediaPathLocation);
            writer.WriteStringValue("signalingLocation", SignalingLocation);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteBoolValue("successfulCall", SuccessfulCall);
            writer.WriteStringValue("transferorCorrelationId", TransferorCorrelationId);
            writer.WriteStringValue("trunkFullyQualifiedDomainName", TrunkFullyQualifiedDomainName);
            writer.WriteStringValue("userCountryCode", UserCountryCode);
        }
    }
}
