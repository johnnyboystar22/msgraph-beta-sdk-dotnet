// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Android Device Owner certificate profile base.
    /// </summary>
    public class AndroidDeviceOwnerCertificateProfileBase : Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Certificate Validity Period Options.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>("certificateValidityPeriodScale"); }
            set { BackingStore?.Set("certificateValidityPeriodScale", value); }
        }
        /// <summary>Value for the Certificate Validity Period.</summary>
        public int? CertificateValidityPeriodValue
        {
            get { return BackingStore?.Get<int?>("certificateValidityPeriodValue"); }
            set { BackingStore?.Set("certificateValidityPeriodValue", value); }
        }
        /// <summary>Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>? ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>?>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage> ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#endif
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage
        {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate? RootCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate?>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate RootCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#endif
        /// <summary>Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public Microsoft.Graph.Beta.Models.SubjectAlternativeNameType? SubjectAlternativeNameType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType?>("subjectAlternativeNameType"); }
            set { BackingStore?.Set("subjectAlternativeNameType", value); }
        }
        /// <summary>Certificate Subject Name Format. Possible values are: commonName, commonNameIncludingEmail, commonNameAsEmail, custom, commonNameAsIMEI, commonNameAsSerialNumber, commonNameAsAadDeviceId, commonNameAsIntuneDeviceId, commonNameAsDurableDeviceId.</summary>
        public Microsoft.Graph.Beta.Models.SubjectNameFormat? SubjectNameFormat
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectNameFormat?>("subjectNameFormat"); }
            set { BackingStore?.Set("subjectNameFormat", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateProfileBase"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerCertificateProfileBase() : base()
        {
            OdataType = "#microsoft.graph.androidDeviceOwnerCertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateProfileBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidDeviceOwnerImportedPFXCertificateProfile" => new Microsoft.Graph.Beta.Models.AndroidDeviceOwnerImportedPFXCertificateProfile(),
                "#microsoft.graph.androidDeviceOwnerPkcsCertificateProfile" => new Microsoft.Graph.Beta.Models.AndroidDeviceOwnerPkcsCertificateProfile(),
                "#microsoft.graph.androidDeviceOwnerScepCertificateProfile" => new Microsoft.Graph.Beta.Models.AndroidDeviceOwnerScepCertificateProfile(),
                _ => new Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale>(); } },
                { "certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                { "extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>(Microsoft.Graph.Beta.Models.ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                { "rootCertificate", n => { RootCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate>(Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                { "subjectAlternativeNameType", n => { SubjectAlternativeNameType = n.GetEnumValue<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType>(); } },
                { "subjectNameFormat", n => { SubjectNameFormat = n.GetEnumValue<Microsoft.Graph.Beta.Models.SubjectNameFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerTrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
