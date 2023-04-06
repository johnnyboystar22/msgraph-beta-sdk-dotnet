using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationMethodsPolicyMigrationState {
        [EnumMember(Value = "preMigration")]
        PreMigration,
        [EnumMember(Value = "migrationInProgress")]
        MigrationInProgress,
        [EnumMember(Value = "migrationComplete")]
        MigrationComplete,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
