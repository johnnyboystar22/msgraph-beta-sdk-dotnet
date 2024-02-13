// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics overview entity contains the overall score and the scores and insights of every metric of all categories.
    /// </summary>
    public class UserExperienceAnalyticsOverview : Entity, IParsable {
        /// <summary>The user experience analytics insights. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsInsight>? Insights {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsInsight>?>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsInsight> Insights {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsInsight>>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserExperienceAnalyticsOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"insights", n => { Insights = n.GetCollectionOfObjectValues<UserExperienceAnalyticsInsight>(UserExperienceAnalyticsInsight.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsInsight>("insights", Insights);
        }
    }
}
