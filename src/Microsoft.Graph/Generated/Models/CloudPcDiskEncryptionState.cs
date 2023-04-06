using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcDiskEncryptionState {
        [EnumMember(Value = "notAvailable")]
        NotAvailable,
        [EnumMember(Value = "notEncrypted")]
        NotEncrypted,
        [EnumMember(Value = "encryptedUsingPlatformManagedKey")]
        EncryptedUsingPlatformManagedKey,
        [EnumMember(Value = "encryptedUsingCustomerManagedKey")]
        EncryptedUsingCustomerManagedKey,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
