// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeight {
    [Obsolete("This class is obsolete. Use {TypeName} instead.")]
    public class ImageWithWidthWithHeightResponse : ImageWithWidthWithHeightGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ImageWithWidthWithHeightResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImageWithWidthWithHeightResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImageWithWidthWithHeightResponse();
        }
    }
}
