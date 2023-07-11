using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationCustomizations : EducationSynchronizationCustomizationsBase, IParsable {
        /// <summary>Customizations for School entities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomization? School {
            get { return BackingStore?.Get<EducationSynchronizationCustomization?>("school"); }
            set { BackingStore?.Set("school", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomization School {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>("school"); }
            set { BackingStore?.Set("school", value); }
        }
#endif
        /// <summary>Customizations for Section entities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomization? Section {
            get { return BackingStore?.Get<EducationSynchronizationCustomization?>("section"); }
            set { BackingStore?.Set("section", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomization Section {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>("section"); }
            set { BackingStore?.Set("section", value); }
        }
#endif
        /// <summary>Customizations for Student entities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomization? Student {
            get { return BackingStore?.Get<EducationSynchronizationCustomization?>("student"); }
            set { BackingStore?.Set("student", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomization Student {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>("student"); }
            set { BackingStore?.Set("student", value); }
        }
#endif
        /// <summary>Customizations for Student Enrollments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomization? StudentEnrollment {
            get { return BackingStore?.Get<EducationSynchronizationCustomization?>("studentEnrollment"); }
            set { BackingStore?.Set("studentEnrollment", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomization StudentEnrollment {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>("studentEnrollment"); }
            set { BackingStore?.Set("studentEnrollment", value); }
        }
#endif
        /// <summary>Customizations for Teacher entities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomization? Teacher {
            get { return BackingStore?.Get<EducationSynchronizationCustomization?>("teacher"); }
            set { BackingStore?.Set("teacher", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomization Teacher {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>("teacher"); }
            set { BackingStore?.Set("teacher", value); }
        }
#endif
        /// <summary>Customizations for Teacher Rosters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomization? TeacherRoster {
            get { return BackingStore?.Get<EducationSynchronizationCustomization?>("teacherRoster"); }
            set { BackingStore?.Set("teacherRoster", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomization TeacherRoster {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>("teacherRoster"); }
            set { BackingStore?.Set("teacherRoster", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new educationSynchronizationCustomizations and sets the default values.
        /// </summary>
        public EducationSynchronizationCustomizations() : base() {
            OdataType = "#microsoft.graph.educationSynchronizationCustomizations";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationSynchronizationCustomizations CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationCustomizations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"school", n => { School = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"section", n => { Section = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"student", n => { Student = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"studentEnrollment", n => { StudentEnrollment = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"teacher", n => { Teacher = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"teacherRoster", n => { TeacherRoster = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("school", School);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("section", Section);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("student", Student);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("studentEnrollment", StudentEnrollment);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("teacher", Teacher);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("teacherRoster", TeacherRoster);
        }
    }
}
