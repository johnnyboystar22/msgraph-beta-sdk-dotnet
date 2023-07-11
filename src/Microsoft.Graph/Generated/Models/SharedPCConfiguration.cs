using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the sharedPCConfiguration resource.
    /// </summary>
    public class SharedPCConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specifies how accounts are managed on a shared PC. Only applies when disableAccountManager is false.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharedPCAccountManagerPolicy? AccountManagerPolicy {
            get { return BackingStore?.Get<SharedPCAccountManagerPolicy?>("accountManagerPolicy"); }
            set { BackingStore?.Set("accountManagerPolicy", value); }
        }
#nullable restore
#else
        public SharedPCAccountManagerPolicy AccountManagerPolicy {
            get { return BackingStore?.Get<SharedPCAccountManagerPolicy>("accountManagerPolicy"); }
            set { BackingStore?.Set("accountManagerPolicy", value); }
        }
#endif
        /// <summary>Type of accounts that are allowed to share the PC.</summary>
        public SharedPCAllowedAccountType? AllowedAccounts {
            get { return BackingStore?.Get<SharedPCAllowedAccountType?>("allowedAccounts"); }
            set { BackingStore?.Set("allowedAccounts", value); }
        }
        /// <summary>Specifies whether local storage is allowed on a shared PC.</summary>
        public bool? AllowLocalStorage {
            get { return BackingStore?.Get<bool?>("allowLocalStorage"); }
            set { BackingStore?.Set("allowLocalStorage", value); }
        }
        /// <summary>Disables the account manager for shared PC mode.</summary>
        public bool? DisableAccountManager {
            get { return BackingStore?.Get<bool?>("disableAccountManager"); }
            set { BackingStore?.Set("disableAccountManager", value); }
        }
        /// <summary>Specifies whether the default shared PC education environment policies should be disabled. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true.</summary>
        public bool? DisableEduPolicies {
            get { return BackingStore?.Get<bool?>("disableEduPolicies"); }
            set { BackingStore?.Set("disableEduPolicies", value); }
        }
        /// <summary>Specifies whether the default shared PC power policies should be disabled.</summary>
        public bool? DisablePowerPolicies {
            get { return BackingStore?.Get<bool?>("disablePowerPolicies"); }
            set { BackingStore?.Set("disablePowerPolicies", value); }
        }
        /// <summary>Disables the requirement to sign in whenever the device wakes up from sleep mode.</summary>
        public bool? DisableSignInOnResume {
            get { return BackingStore?.Get<bool?>("disableSignInOnResume"); }
            set { BackingStore?.Set("disableSignInOnResume", value); }
        }
        /// <summary>Enables shared PC mode and applies the shared pc policies.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? FastFirstSignIn {
            get { return BackingStore?.Get<Enablement?>("fastFirstSignIn"); }
            set { BackingStore?.Set("fastFirstSignIn", value); }
        }
        /// <summary>Specifies the time in seconds that a device must sit idle before the PC goes to sleep. Setting this value to 0 prevents the sleep timeout from occurring.</summary>
        public int? IdleTimeBeforeSleepInSeconds {
            get { return BackingStore?.Get<int?>("idleTimeBeforeSleepInSeconds"); }
            set { BackingStore?.Set("idleTimeBeforeSleepInSeconds", value); }
        }
        /// <summary>Specifies the display text for the account shown on the sign-in screen which launches the app specified by SetKioskAppUserModelId. Only applies when KioskAppUserModelId is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskAppDisplayName {
            get { return BackingStore?.Get<string?>("kioskAppDisplayName"); }
            set { BackingStore?.Set("kioskAppDisplayName", value); }
        }
#nullable restore
#else
        public string KioskAppDisplayName {
            get { return BackingStore?.Get<string>("kioskAppDisplayName"); }
            set { BackingStore?.Set("kioskAppDisplayName", value); }
        }
#endif
        /// <summary>Specifies the application user model ID of the app to use with assigned access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskAppUserModelId {
            get { return BackingStore?.Get<string?>("kioskAppUserModelId"); }
            set { BackingStore?.Set("kioskAppUserModelId", value); }
        }
#nullable restore
#else
        public string KioskAppUserModelId {
            get { return BackingStore?.Get<string>("kioskAppUserModelId"); }
            set { BackingStore?.Set("kioskAppUserModelId", value); }
        }
#endif
        /// <summary>Possible values of a property</summary>
        public Enablement? LocalStorage {
            get { return BackingStore?.Get<Enablement?>("localStorage"); }
            set { BackingStore?.Set("localStorage", value); }
        }
        /// <summary>Specifies the daily start time of maintenance hour.</summary>
        public Time? MaintenanceStartTime {
            get { return BackingStore?.Get<Time?>("maintenanceStartTime"); }
            set { BackingStore?.Set("maintenanceStartTime", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SetAccountManager {
            get { return BackingStore?.Get<Enablement?>("setAccountManager"); }
            set { BackingStore?.Set("setAccountManager", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SetEduPolicies {
            get { return BackingStore?.Get<Enablement?>("setEduPolicies"); }
            set { BackingStore?.Set("setEduPolicies", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SetPowerPolicies {
            get { return BackingStore?.Get<Enablement?>("setPowerPolicies"); }
            set { BackingStore?.Set("setPowerPolicies", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SignInOnResume {
            get { return BackingStore?.Get<Enablement?>("signInOnResume"); }
            set { BackingStore?.Set("signInOnResume", value); }
        }
        /// <summary>
        /// Instantiates a new sharedPCConfiguration and sets the default values.
        /// </summary>
        public SharedPCConfiguration() : base() {
            OdataType = "#microsoft.graph.sharedPCConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedPCConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedPCConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountManagerPolicy", n => { AccountManagerPolicy = n.GetObjectValue<SharedPCAccountManagerPolicy>(SharedPCAccountManagerPolicy.CreateFromDiscriminatorValue); } },
                {"allowedAccounts", n => { AllowedAccounts = n.GetEnumValue<SharedPCAllowedAccountType>(); } },
                {"allowLocalStorage", n => { AllowLocalStorage = n.GetBoolValue(); } },
                {"disableAccountManager", n => { DisableAccountManager = n.GetBoolValue(); } },
                {"disableEduPolicies", n => { DisableEduPolicies = n.GetBoolValue(); } },
                {"disablePowerPolicies", n => { DisablePowerPolicies = n.GetBoolValue(); } },
                {"disableSignInOnResume", n => { DisableSignInOnResume = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"fastFirstSignIn", n => { FastFirstSignIn = n.GetEnumValue<Enablement>(); } },
                {"idleTimeBeforeSleepInSeconds", n => { IdleTimeBeforeSleepInSeconds = n.GetIntValue(); } },
                {"kioskAppDisplayName", n => { KioskAppDisplayName = n.GetStringValue(); } },
                {"kioskAppUserModelId", n => { KioskAppUserModelId = n.GetStringValue(); } },
                {"localStorage", n => { LocalStorage = n.GetEnumValue<Enablement>(); } },
                {"maintenanceStartTime", n => { MaintenanceStartTime = n.GetTimeValue(); } },
                {"setAccountManager", n => { SetAccountManager = n.GetEnumValue<Enablement>(); } },
                {"setEduPolicies", n => { SetEduPolicies = n.GetEnumValue<Enablement>(); } },
                {"setPowerPolicies", n => { SetPowerPolicies = n.GetEnumValue<Enablement>(); } },
                {"signInOnResume", n => { SignInOnResume = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SharedPCAccountManagerPolicy>("accountManagerPolicy", AccountManagerPolicy);
            writer.WriteEnumValue<SharedPCAllowedAccountType>("allowedAccounts", AllowedAccounts);
            writer.WriteBoolValue("allowLocalStorage", AllowLocalStorage);
            writer.WriteBoolValue("disableAccountManager", DisableAccountManager);
            writer.WriteBoolValue("disableEduPolicies", DisableEduPolicies);
            writer.WriteBoolValue("disablePowerPolicies", DisablePowerPolicies);
            writer.WriteBoolValue("disableSignInOnResume", DisableSignInOnResume);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<Enablement>("fastFirstSignIn", FastFirstSignIn);
            writer.WriteIntValue("idleTimeBeforeSleepInSeconds", IdleTimeBeforeSleepInSeconds);
            writer.WriteStringValue("kioskAppDisplayName", KioskAppDisplayName);
            writer.WriteStringValue("kioskAppUserModelId", KioskAppUserModelId);
            writer.WriteEnumValue<Enablement>("localStorage", LocalStorage);
            writer.WriteTimeValue("maintenanceStartTime", MaintenanceStartTime);
            writer.WriteEnumValue<Enablement>("setAccountManager", SetAccountManager);
            writer.WriteEnumValue<Enablement>("setEduPolicies", SetEduPolicies);
            writer.WriteEnumValue<Enablement>("setPowerPolicies", SetPowerPolicies);
            writer.WriteEnumValue<Enablement>("signInOnResume", SignInOnResume);
        }
    }
}
