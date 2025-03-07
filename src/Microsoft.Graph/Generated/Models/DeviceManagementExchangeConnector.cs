// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Entity which represents a connection to an Exchange environment.
    /// </summary>
    public class DeviceManagementExchangeConnector : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The name of the server hosting the Exchange Connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorServerName
        {
            get { return BackingStore?.Get<string?>("connectorServerName"); }
            set { BackingStore?.Set("connectorServerName", value); }
        }
#nullable restore
#else
        public string ConnectorServerName
        {
            get { return BackingStore?.Get<string>("connectorServerName"); }
            set { BackingStore?.Set("connectorServerName", value); }
        }
#endif
        /// <summary>An alias assigned to the Exchange server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeAlias
        {
            get { return BackingStore?.Get<string?>("exchangeAlias"); }
            set { BackingStore?.Set("exchangeAlias", value); }
        }
#nullable restore
#else
        public string ExchangeAlias
        {
            get { return BackingStore?.Get<string>("exchangeAlias"); }
            set { BackingStore?.Set("exchangeAlias", value); }
        }
#endif
        /// <summary>The type of Exchange Connector.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorType? ExchangeConnectorType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorType?>("exchangeConnectorType"); }
            set { BackingStore?.Set("exchangeConnectorType", value); }
        }
        /// <summary>Exchange Organization to the Exchange server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeOrganization
        {
            get { return BackingStore?.Get<string?>("exchangeOrganization"); }
            set { BackingStore?.Set("exchangeOrganization", value); }
        }
#nullable restore
#else
        public string ExchangeOrganization
        {
            get { return BackingStore?.Get<string>("exchangeOrganization"); }
            set { BackingStore?.Set("exchangeOrganization", value); }
        }
#endif
        /// <summary>Last sync time for the Exchange Connector</summary>
        public DateTimeOffset? LastSyncDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Email address used to configure the Service To Service Exchange Connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimarySmtpAddress
        {
            get { return BackingStore?.Get<string?>("primarySmtpAddress"); }
            set { BackingStore?.Set("primarySmtpAddress", value); }
        }
#nullable restore
#else
        public string PrimarySmtpAddress
        {
            get { return BackingStore?.Get<string>("primarySmtpAddress"); }
            set { BackingStore?.Set("primarySmtpAddress", value); }
        }
#endif
        /// <summary>The name of the Exchange server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerName
        {
            get { return BackingStore?.Get<string?>("serverName"); }
            set { BackingStore?.Set("serverName", value); }
        }
#nullable restore
#else
        public string ServerName
        {
            get { return BackingStore?.Get<string>("serverName"); }
            set { BackingStore?.Set("serverName", value); }
        }
#endif
        /// <summary>The current status of the Exchange Connector.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The version of the ExchangeConnectorAgent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "connectorServerName", n => { ConnectorServerName = n.GetStringValue(); } },
                { "exchangeAlias", n => { ExchangeAlias = n.GetStringValue(); } },
                { "exchangeConnectorType", n => { ExchangeConnectorType = n.GetEnumValue<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorType>(); } },
                { "exchangeOrganization", n => { ExchangeOrganization = n.GetStringValue(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "primarySmtpAddress", n => { PrimarySmtpAddress = n.GetStringValue(); } },
                { "serverName", n => { ServerName = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorStatus>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteStringValue("connectorServerName", ConnectorServerName);
            writer.WriteStringValue("exchangeAlias", ExchangeAlias);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorType>("exchangeConnectorType", ExchangeConnectorType);
            writer.WriteStringValue("exchangeOrganization", ExchangeOrganization);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("primarySmtpAddress", PrimarySmtpAddress);
            writer.WriteStringValue("serverName", ServerName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnectorStatus>("status", Status);
            writer.WriteStringValue("version", Version);
        }
    }
}
