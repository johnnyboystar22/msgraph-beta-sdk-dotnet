// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class RegistryKeyState : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A Windows registry hive : HKEYCURRENTCONFIG HKEYCURRENTUSER HKEYLOCALMACHINE/SAM HKEYLOCALMACHINE/Security HKEYLOCALMACHINE/Software HKEYLOCALMACHINE/System HKEY_USERS/.Default. Possible values are: unknown, currentConfig, currentUser, localMachineSam, localMachineSecurity, localMachineSoftware, localMachineSystem, usersDefault.</summary>
        public Microsoft.Graph.Beta.Models.RegistryHive? Hive
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RegistryHive?>("hive"); }
            set { BackingStore?.Set("hive", value); }
        }
        /// <summary>Current (i.e. changed) registry key (excludes HIVE).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key
        {
            get { return BackingStore?.Get<string?>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#nullable restore
#else
        public string Key
        {
            get { return BackingStore?.Get<string>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Previous (i.e. before changed) registry key (excludes HIVE).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldKey
        {
            get { return BackingStore?.Get<string?>("oldKey"); }
            set { BackingStore?.Set("oldKey", value); }
        }
#nullable restore
#else
        public string OldKey
        {
            get { return BackingStore?.Get<string>("oldKey"); }
            set { BackingStore?.Set("oldKey", value); }
        }
#endif
        /// <summary>Previous (i.e. before changed) registry key value data (contents).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldValueData
        {
            get { return BackingStore?.Get<string?>("oldValueData"); }
            set { BackingStore?.Set("oldValueData", value); }
        }
#nullable restore
#else
        public string OldValueData
        {
            get { return BackingStore?.Get<string>("oldValueData"); }
            set { BackingStore?.Set("oldValueData", value); }
        }
#endif
        /// <summary>Previous (i.e. before changed) registry key value name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldValueName
        {
            get { return BackingStore?.Get<string?>("oldValueName"); }
            set { BackingStore?.Set("oldValueName", value); }
        }
#nullable restore
#else
        public string OldValueName
        {
            get { return BackingStore?.Get<string>("oldValueName"); }
            set { BackingStore?.Set("oldValueName", value); }
        }
#endif
        /// <summary>Operation that changed the registry key name and/or value. Possible values are: unknown, create, modify, delete.</summary>
        public Microsoft.Graph.Beta.Models.RegistryOperation? Operation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RegistryOperation?>("operation"); }
            set { BackingStore?.Set("operation", value); }
        }
        /// <summary>Process ID (PID) of the process that modified the registry key (process details will appear in the alert &apos;processes&apos; collection).</summary>
        public int? ProcessId
        {
            get { return BackingStore?.Get<int?>("processId"); }
            set { BackingStore?.Set("processId", value); }
        }
        /// <summary>Current (i.e. changed) registry key value data (contents).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueData
        {
            get { return BackingStore?.Get<string?>("valueData"); }
            set { BackingStore?.Set("valueData", value); }
        }
#nullable restore
#else
        public string ValueData
        {
            get { return BackingStore?.Get<string>("valueData"); }
            set { BackingStore?.Set("valueData", value); }
        }
#endif
        /// <summary>Current (i.e. changed) registry key value name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueName
        {
            get { return BackingStore?.Get<string?>("valueName"); }
            set { BackingStore?.Set("valueName", value); }
        }
#nullable restore
#else
        public string ValueName
        {
            get { return BackingStore?.Get<string>("valueName"); }
            set { BackingStore?.Set("valueName", value); }
        }
#endif
        /// <summary>Registry key value type REGBINARY REGDWORD REGDWORDLITTLEENDIAN REGDWORDBIGENDIANREGEXPANDSZ REGLINK REGMULTISZ REGNONE REGQWORD REGQWORDLITTLEENDIAN REG_SZ Possible values are: unknown, binary, dword, dwordLittleEndian, dwordBigEndian, expandSz, link, multiSz, none, qword, qwordlittleEndian, sz.</summary>
        public Microsoft.Graph.Beta.Models.RegistryValueType? ValueType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RegistryValueType?>("valueType"); }
            set { BackingStore?.Set("valueType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.RegistryKeyState"/> and sets the default values.
        /// </summary>
        public RegistryKeyState()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.RegistryKeyState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.RegistryKeyState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.RegistryKeyState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hive", n => { Hive = n.GetEnumValue<Microsoft.Graph.Beta.Models.RegistryHive>(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "oldKey", n => { OldKey = n.GetStringValue(); } },
                { "oldValueData", n => { OldValueData = n.GetStringValue(); } },
                { "oldValueName", n => { OldValueName = n.GetStringValue(); } },
                { "operation", n => { Operation = n.GetEnumValue<Microsoft.Graph.Beta.Models.RegistryOperation>(); } },
                { "processId", n => { ProcessId = n.GetIntValue(); } },
                { "valueData", n => { ValueData = n.GetStringValue(); } },
                { "valueName", n => { ValueName = n.GetStringValue(); } },
                { "valueType", n => { ValueType = n.GetEnumValue<Microsoft.Graph.Beta.Models.RegistryValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.RegistryHive>("hive", Hive);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("oldKey", OldKey);
            writer.WriteStringValue("oldValueData", OldValueData);
            writer.WriteStringValue("oldValueName", OldValueName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.RegistryOperation>("operation", Operation);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteStringValue("valueData", ValueData);
            writer.WriteStringValue("valueName", ValueName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.RegistryValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
