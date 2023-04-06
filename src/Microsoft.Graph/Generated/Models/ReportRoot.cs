using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ReportRoot : Entity, IParsable {
        /// <summary>Represents a detailed summary of an application sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>? ApplicationSignInDetailedSummary {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>?>("applicationSignInDetailedSummary"); }
            set { BackingStore?.Set("applicationSignInDetailedSummary", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary> ApplicationSignInDetailedSummary {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>>("applicationSignInDetailedSummary"); }
            set { BackingStore?.Set("applicationSignInDetailedSummary", value); }
        }
#endif
        /// <summary>Container for navigation properties for Azure AD authentication methods resources.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationMethodsRoot? AuthenticationMethods {
            get { return BackingStore?.Get<AuthenticationMethodsRoot?>("authenticationMethods"); }
            set { BackingStore?.Set("authenticationMethods", value); }
        }
#nullable restore
#else
        public AuthenticationMethodsRoot AuthenticationMethods {
            get { return BackingStore?.Get<AuthenticationMethodsRoot>("authenticationMethods"); }
            set { BackingStore?.Set("authenticationMethods", value); }
        }
#endif
        /// <summary>Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>? CredentialUserRegistrationDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>?>("credentialUserRegistrationDetails"); }
            set { BackingStore?.Set("credentialUserRegistrationDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails> CredentialUserRegistrationDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>>("credentialUserRegistrationDetails"); }
            set { BackingStore?.Set("credentialUserRegistrationDetails", value); }
        }
#endif
        /// <summary>The dailyPrintUsage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsage>? DailyPrintUsage {
            get { return BackingStore?.Get<List<PrintUsage>?>("dailyPrintUsage"); }
            set { BackingStore?.Set("dailyPrintUsage", value); }
        }
#nullable restore
#else
        public List<PrintUsage> DailyPrintUsage {
            get { return BackingStore?.Get<List<PrintUsage>>("dailyPrintUsage"); }
            set { BackingStore?.Set("dailyPrintUsage", value); }
        }
#endif
        /// <summary>The dailyPrintUsageByPrinter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByPrinter>? DailyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>?>("dailyPrintUsageByPrinter"); }
            set { BackingStore?.Set("dailyPrintUsageByPrinter", value); }
        }
#nullable restore
#else
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>("dailyPrintUsageByPrinter"); }
            set { BackingStore?.Set("dailyPrintUsageByPrinter", value); }
        }
#endif
        /// <summary>The dailyPrintUsageByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByUser>? DailyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>?>("dailyPrintUsageByUser"); }
            set { BackingStore?.Set("dailyPrintUsageByUser", value); }
        }
#nullable restore
#else
        public List<PrintUsageByUser> DailyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>("dailyPrintUsageByUser"); }
            set { BackingStore?.Set("dailyPrintUsageByUser", value); }
        }
#endif
        /// <summary>The dailyPrintUsageSummariesByPrinter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByPrinter>? DailyPrintUsageSummariesByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>?>("dailyPrintUsageSummariesByPrinter"); }
            set { BackingStore?.Set("dailyPrintUsageSummariesByPrinter", value); }
        }
#nullable restore
#else
        public List<PrintUsageByPrinter> DailyPrintUsageSummariesByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>("dailyPrintUsageSummariesByPrinter"); }
            set { BackingStore?.Set("dailyPrintUsageSummariesByPrinter", value); }
        }
#endif
        /// <summary>The dailyPrintUsageSummariesByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByUser>? DailyPrintUsageSummariesByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>?>("dailyPrintUsageSummariesByUser"); }
            set { BackingStore?.Set("dailyPrintUsageSummariesByUser", value); }
        }
#nullable restore
#else
        public List<PrintUsageByUser> DailyPrintUsageSummariesByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>("dailyPrintUsageSummariesByUser"); }
            set { BackingStore?.Set("dailyPrintUsageSummariesByUser", value); }
        }
#endif
        /// <summary>The monthlyPrintUsageByPrinter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByPrinter>? MonthlyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>?>("monthlyPrintUsageByPrinter"); }
            set { BackingStore?.Set("monthlyPrintUsageByPrinter", value); }
        }
#nullable restore
#else
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>("monthlyPrintUsageByPrinter"); }
            set { BackingStore?.Set("monthlyPrintUsageByPrinter", value); }
        }
#endif
        /// <summary>The monthlyPrintUsageByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByUser>? MonthlyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>?>("monthlyPrintUsageByUser"); }
            set { BackingStore?.Set("monthlyPrintUsageByUser", value); }
        }
#nullable restore
#else
        public List<PrintUsageByUser> MonthlyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>("monthlyPrintUsageByUser"); }
            set { BackingStore?.Set("monthlyPrintUsageByUser", value); }
        }
#endif
        /// <summary>The monthlyPrintUsageSummariesByPrinter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByPrinter>? MonthlyPrintUsageSummariesByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>?>("monthlyPrintUsageSummariesByPrinter"); }
            set { BackingStore?.Set("monthlyPrintUsageSummariesByPrinter", value); }
        }
#nullable restore
#else
        public List<PrintUsageByPrinter> MonthlyPrintUsageSummariesByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>("monthlyPrintUsageSummariesByPrinter"); }
            set { BackingStore?.Set("monthlyPrintUsageSummariesByPrinter", value); }
        }
#endif
        /// <summary>The monthlyPrintUsageSummariesByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByUser>? MonthlyPrintUsageSummariesByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>?>("monthlyPrintUsageSummariesByUser"); }
            set { BackingStore?.Set("monthlyPrintUsageSummariesByUser", value); }
        }
#nullable restore
#else
        public List<PrintUsageByUser> MonthlyPrintUsageSummariesByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>("monthlyPrintUsageSummariesByUser"); }
            set { BackingStore?.Set("monthlyPrintUsageSummariesByUser", value); }
        }
#endif
        /// <summary>Provides the ability to launch a realistic simulated phishing attack that organizations can learn from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityReportsRoot? Security {
            get { return BackingStore?.Get<SecurityReportsRoot?>("security"); }
            set { BackingStore?.Set("security", value); }
        }
#nullable restore
#else
        public SecurityReportsRoot Security {
            get { return BackingStore?.Get<SecurityReportsRoot>("security"); }
            set { BackingStore?.Set("security", value); }
        }
#endif
        /// <summary>Represents the self-service password reset (SSPR) usage for a given tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>? UserCredentialUsageDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>?>("userCredentialUsageDetails"); }
            set { BackingStore?.Set("userCredentialUsageDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails> UserCredentialUsageDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>>("userCredentialUsageDetails"); }
            set { BackingStore?.Set("userCredentialUsageDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ReportRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReportRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationSignInDetailedSummary", n => { ApplicationSignInDetailedSummary = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>(Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationMethods", n => { AuthenticationMethods = n.GetObjectValue<AuthenticationMethodsRoot>(AuthenticationMethodsRoot.CreateFromDiscriminatorValue); } },
                {"credentialUserRegistrationDetails", n => { CredentialUserRegistrationDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>(Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dailyPrintUsage", n => { DailyPrintUsage = n.GetCollectionOfObjectValues<PrintUsage>(PrintUsage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dailyPrintUsageByPrinter", n => { DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dailyPrintUsageByUser", n => { DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dailyPrintUsageSummariesByPrinter", n => { DailyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dailyPrintUsageSummariesByUser", n => { DailyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monthlyPrintUsageByPrinter", n => { MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monthlyPrintUsageByUser", n => { MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monthlyPrintUsageSummariesByPrinter", n => { MonthlyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monthlyPrintUsageSummariesByUser", n => { MonthlyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"security", n => { Security = n.GetObjectValue<SecurityReportsRoot>(SecurityReportsRoot.CreateFromDiscriminatorValue); } },
                {"userCredentialUsageDetails", n => { UserCredentialUsageDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>(Microsoft.Graph.Beta.Models.UserCredentialUsageDetails.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>("applicationSignInDetailedSummary", ApplicationSignInDetailedSummary);
            writer.WriteObjectValue<AuthenticationMethodsRoot>("authenticationMethods", AuthenticationMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>("credentialUserRegistrationDetails", CredentialUserRegistrationDetails);
            writer.WriteCollectionOfObjectValues<PrintUsage>("dailyPrintUsage", DailyPrintUsage);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageSummariesByPrinter", DailyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageSummariesByUser", DailyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageSummariesByPrinter", MonthlyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageSummariesByUser", MonthlyPrintUsageSummariesByUser);
            writer.WriteObjectValue<SecurityReportsRoot>("security", Security);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>("userCredentialUsageDetails", UserCredentialUsageDetails);
        }
    }
}
