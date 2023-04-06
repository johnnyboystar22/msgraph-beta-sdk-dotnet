using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for the file format of a report</summary>
    public enum DeviceManagementReportFileFormat {
        /// <summary>CSV Format</summary>
        [EnumMember(Value = "csv")]
        Csv,
        /// <summary>PDF Format (Deprecate later)</summary>
        [EnumMember(Value = "pdf")]
        Pdf,
        /// <summary>JSON Format</summary>
        [EnumMember(Value = "json")]
        Json,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
