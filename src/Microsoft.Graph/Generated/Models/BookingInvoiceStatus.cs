using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum BookingInvoiceStatus {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "reviewing")]
        Reviewing,
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "paid")]
        Paid,
        [EnumMember(Value = "corrective")]
        Corrective,
    }
}
