// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device Management Export Job.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementExportJob>))]
    public partial class DeviceManagementExportJob : Entity
    {
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Time that the exported report expires. This property is read-only.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets filter.
        /// Filters applied on the report
        /// </summary>
        [JsonPropertyName("filter")]
        public string Filter { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Format of the exported report. Possible values are: csv, pdf, json, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("format")]
        public DeviceManagementReportFileFormat? Format { get; set; }
    
        /// <summary>
        /// Gets or sets localization type.
        /// Configures how the requested export job is localized. Possible values are: localizedValuesAsAdditionalColumn, replaceLocalizableValues.
        /// </summary>
        [JsonPropertyName("localizationType")]
        public DeviceManagementExportJobLocalizationType? LocalizationType { get; set; }
    
        /// <summary>
        /// Gets or sets report name.
        /// Name of the report
        /// </summary>
        [JsonPropertyName("reportName")]
        public string ReportName { get; set; }
    
        /// <summary>
        /// Gets or sets request date time.
        /// Time that the exported report was requested. This property is read-only.
        /// </summary>
        [JsonPropertyName("requestDateTime")]
        public DateTimeOffset? RequestDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets select.
        /// Columns selected from the report
        /// </summary>
        [JsonPropertyName("select")]
        public IEnumerable<string> Select { get; set; }
    
        /// <summary>
        /// Gets or sets snapshot id.
        /// A snapshot is an identifiable subset of the dataset represented by the ReportName. A sessionId or CachedReportConfiguration id can be used here. If a sessionId is specified, Filter, Select, and OrderBy are applied to the data represented by the sessionId. Filter, Select, and OrderBy cannot be specified together with a CachedReportConfiguration id.
        /// </summary>
        [JsonPropertyName("snapshotId")]
        public string SnapshotId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the export job. This property is read-only. Possible values are: unknown, notStarted, inProgress, completed, failed.
        /// </summary>
        [JsonPropertyName("status")]
        public DeviceManagementReportStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// Temporary location of the exported report. This property is read-only.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    }
}

