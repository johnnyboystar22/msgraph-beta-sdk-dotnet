// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PrinterCapabilities.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrinterCapabilities>))]
    public partial class PrinterCapabilities
    {

        /// <summary>
        /// Gets or sets bottomMargins.
        /// A list of supported bottom margins(in microns) for the printer.
        /// </summary>
        [JsonPropertyName("bottomMargins")]
        public IEnumerable<Int32> BottomMargins { get; set; }
    
        /// <summary>
        /// Gets or sets collation.
        /// True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.
        /// </summary>
        [JsonPropertyName("collation")]
        public bool? Collation { get; set; }
    
        /// <summary>
        /// Gets or sets colorModes.
        /// The color modes supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("colorModes")]
        public IEnumerable<PrintColorMode> ColorModes { get; set; }
    
        /// <summary>
        /// Gets or sets contentTypes.
        /// A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.
        /// </summary>
        [JsonPropertyName("contentTypes")]
        public IEnumerable<string> ContentTypes { get; set; }
    
        /// <summary>
        /// Gets or sets copiesPerJob.
        /// The range of copies per job supported by the printer.
        /// </summary>
        [JsonPropertyName("copiesPerJob")]
        public IntegerRange CopiesPerJob { get; set; }
    
        /// <summary>
        /// Gets or sets dpis.
        /// The list of print resolutions in DPI that are supported by the printer.
        /// </summary>
        [JsonPropertyName("dpis")]
        public IEnumerable<Int32> Dpis { get; set; }
    
        /// <summary>
        /// Gets or sets duplexModes.
        /// The list of duplex modes that are supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("duplexModes")]
        public IEnumerable<PrintDuplexMode> DuplexModes { get; set; }
    
        /// <summary>
        /// Gets or sets feedDirections.
        /// </summary>
        [Obsolete("The feedDirections property is deprecated and will stop returning data on July 31, 2023. Please use the feedOrientations property instead of this.")]
        [JsonPropertyName("feedDirections")]
        public IEnumerable<PrinterFeedDirection> FeedDirections { get; set; }
    
        /// <summary>
        /// Gets or sets feedOrientations.
        /// The list of feed orientations that are supported by the printer.
        /// </summary>
        [JsonPropertyName("feedOrientations")]
        public IEnumerable<PrinterFeedOrientation> FeedOrientations { get; set; }
    
        /// <summary>
        /// Gets or sets finishings.
        /// Finishing processes the printer supports for a printed document.
        /// </summary>
        [JsonPropertyName("finishings")]
        public IEnumerable<PrintFinishing> Finishings { get; set; }
    
        /// <summary>
        /// Gets or sets inputBins.
        /// Supported input bins for the printer.
        /// </summary>
        [JsonPropertyName("inputBins")]
        public IEnumerable<string> InputBins { get; set; }
    
        /// <summary>
        /// Gets or sets isColorPrintingSupported.
        /// True if color printing is supported by the printer; false otherwise. Read-only.
        /// </summary>
        [JsonPropertyName("isColorPrintingSupported")]
        public bool? IsColorPrintingSupported { get; set; }
    
        /// <summary>
        /// Gets or sets isPageRangeSupported.
        /// True if the printer supports printing by page ranges; false otherwise.
        /// </summary>
        [JsonPropertyName("isPageRangeSupported")]
        public bool? IsPageRangeSupported { get; set; }
    
        /// <summary>
        /// Gets or sets leftMargins.
        /// A list of supported left margins(in microns) for the printer.
        /// </summary>
        [JsonPropertyName("leftMargins")]
        public IEnumerable<Int32> LeftMargins { get; set; }
    
        /// <summary>
        /// Gets or sets mediaColors.
        /// The media (i.e., paper) colors supported by the printer.
        /// </summary>
        [JsonPropertyName("mediaColors")]
        public IEnumerable<string> MediaColors { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSizes.
        /// The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.
        /// </summary>
        [JsonPropertyName("mediaSizes")]
        public IEnumerable<string> MediaSizes { get; set; }
    
        /// <summary>
        /// Gets or sets mediaTypes.
        /// The media types supported by the printer.
        /// </summary>
        [JsonPropertyName("mediaTypes")]
        public IEnumerable<string> MediaTypes { get; set; }
    
        /// <summary>
        /// Gets or sets multipageLayouts.
        /// The presentation directions supported by the printer. Supported values are described in the following table.
        /// </summary>
        [JsonPropertyName("multipageLayouts")]
        public IEnumerable<PrintMultipageLayout> MultipageLayouts { get; set; }
    
        /// <summary>
        /// Gets or sets orientations.
        /// The print orientations supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("orientations")]
        public IEnumerable<PrintOrientation> Orientations { get; set; }
    
        /// <summary>
        /// Gets or sets outputBins.
        /// The printer's supported output bins (trays).
        /// </summary>
        [JsonPropertyName("outputBins")]
        public IEnumerable<string> OutputBins { get; set; }
    
        /// <summary>
        /// Gets or sets pagesPerSheet.
        /// Supported number of Input Pages to impose upon a single Impression.
        /// </summary>
        [JsonPropertyName("pagesPerSheet")]
        public IEnumerable<Int32> PagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets qualities.
        /// The print qualities supported by the printer.
        /// </summary>
        [JsonPropertyName("qualities")]
        public IEnumerable<PrintQuality> Qualities { get; set; }
    
        /// <summary>
        /// Gets or sets rightMargins.
        /// A list of supported right margins(in microns) for the printer.
        /// </summary>
        [JsonPropertyName("rightMargins")]
        public IEnumerable<Int32> RightMargins { get; set; }
    
        /// <summary>
        /// Gets or sets scalings.
        /// Supported print scalings.
        /// </summary>
        [JsonPropertyName("scalings")]
        public IEnumerable<PrintScaling> Scalings { get; set; }
    
        /// <summary>
        /// Gets or sets supportedColorConfigurations.
        /// </summary>
        [Obsolete("The supportedColorConfigurations property is deprecated and will stop returning data on July 31, 2023. Please use the colorModes property instead of this.")]
        [JsonPropertyName("supportedColorConfigurations")]
        public IEnumerable<PrintColorConfiguration> SupportedColorConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets supportedCopiesPerJob.
        /// </summary>
        [Obsolete("The supportedCopiesPerJob property is deprecated and will stop returning data on July 31, 2023. Please use the copiesPerJob property instead of this.")]
        [JsonPropertyName("supportedCopiesPerJob")]
        public IntegerRange SupportedCopiesPerJob { get; set; }
    
        /// <summary>
        /// Gets or sets supportedDocumentMimeTypes.
        /// </summary>
        [Obsolete("The supportedDocumentMimeTypes property is deprecated and will stop returning data on July 31, 2023. Please use the contentTypes property instead of this.")]
        [JsonPropertyName("supportedDocumentMimeTypes")]
        public IEnumerable<string> SupportedDocumentMimeTypes { get; set; }
    
        /// <summary>
        /// Gets or sets supportedDuplexConfigurations.
        /// </summary>
        [Obsolete("The supportedDuplexConfigurations property is deprecated and will stop returning data on July 31, 2023. Please use the duplexModes property instead of this.")]
        [JsonPropertyName("supportedDuplexConfigurations")]
        public IEnumerable<PrintDuplexConfiguration> SupportedDuplexConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets supportedFinishings.
        /// </summary>
        [Obsolete("The supportedFinishings property is deprecated and will stop returning data on July 31, 2023. Please use the finishings property instead of this.")]
        [JsonPropertyName("supportedFinishings")]
        public IEnumerable<PrintFinishing> SupportedFinishings { get; set; }
    
        /// <summary>
        /// Gets or sets supportedMediaColors.
        /// </summary>
        [Obsolete("The supportedMediaColors property is deprecated and will stop returning data on July 31, 2023. Please use the mediaColors property instead of this.")]
        [JsonPropertyName("supportedMediaColors")]
        public IEnumerable<string> SupportedMediaColors { get; set; }
    
        /// <summary>
        /// Gets or sets supportedMediaSizes.
        /// </summary>
        [Obsolete("The supportedMediaSizes property is deprecated and will stop returning data on July 31, 2023. Please use the mediaSizes property instead of this.")]
        [JsonPropertyName("supportedMediaSizes")]
        public IEnumerable<string> SupportedMediaSizes { get; set; }
    
        /// <summary>
        /// Gets or sets supportedMediaTypes.
        /// </summary>
        [Obsolete("The supportedMediaTypes property is deprecated and will stop returning data on July 31, 2023. Please use the mediaTypes property instead of this.")]
        [JsonPropertyName("supportedMediaTypes")]
        public IEnumerable<PrintMediaType> SupportedMediaTypes { get; set; }
    
        /// <summary>
        /// Gets or sets supportedOrientations.
        /// </summary>
        [Obsolete("The supportedOrientations property is deprecated and will stop returning data on July 31, 2023. Please use the orientations property instead of this.")]
        [JsonPropertyName("supportedOrientations")]
        public IEnumerable<PrintOrientation> SupportedOrientations { get; set; }
    
        /// <summary>
        /// Gets or sets supportedOutputBins.
        /// </summary>
        [Obsolete("The supportedOutputBins property is deprecated and will stop returning data on July 31, 2023. Please use the outputBins property instead of this.")]
        [JsonPropertyName("supportedOutputBins")]
        public IEnumerable<string> SupportedOutputBins { get; set; }
    
        /// <summary>
        /// Gets or sets supportedPagesPerSheet.
        /// </summary>
        [Obsolete("The supportedPagesPerSheet property is deprecated and will stop returning data on July 31, 2023. Please use the pagesPerSheet property instead of this.")]
        [JsonPropertyName("supportedPagesPerSheet")]
        public IntegerRange SupportedPagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets supportedPresentationDirections.
        /// </summary>
        [Obsolete("The supportedPresentationDirections property is deprecated and will stop returning data on July 31, 2023. Please use the multipageLayouts property instead of this.")]
        [JsonPropertyName("supportedPresentationDirections")]
        public IEnumerable<PrintPresentationDirection> SupportedPresentationDirections { get; set; }
    
        /// <summary>
        /// Gets or sets supportedPrintQualities.
        /// </summary>
        [Obsolete("The supportedPrintQualities property is deprecated and will stop returning data on July 31, 2023. Please use the qualities property instead of this.")]
        [JsonPropertyName("supportedPrintQualities")]
        public IEnumerable<PrintQuality> SupportedPrintQualities { get; set; }
    
        /// <summary>
        /// Gets or sets supportsFitPdfToPage.
        /// True if the printer supports scaling PDF pages to match the print media size; false otherwise.
        /// </summary>
        [JsonPropertyName("supportsFitPdfToPage")]
        public bool? SupportsFitPdfToPage { get; set; }
    
        /// <summary>
        /// Gets or sets topMargins.
        /// A list of supported top margins(in microns) for the printer.
        /// </summary>
        [JsonPropertyName("topMargins")]
        public IEnumerable<Int32> TopMargins { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
