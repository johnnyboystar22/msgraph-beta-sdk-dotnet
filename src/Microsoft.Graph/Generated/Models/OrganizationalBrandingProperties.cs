using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundColor {
            get { return BackingStore?.Get<string?>("backgroundColor"); }
            set { BackingStore?.Set("backgroundColor", value); }
        }
#nullable restore
#else
        public string BackgroundColor {
            get { return BackingStore?.Get<string>("backgroundColor"); }
            set { BackingStore?.Set("backgroundColor", value); }
        }
#endif
        /// <summary>Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? BackgroundImage {
            get { return BackingStore?.Get<byte[]?>("backgroundImage"); }
            set { BackingStore?.Set("backgroundImage", value); }
        }
#nullable restore
#else
        public byte[] BackgroundImage {
            get { return BackingStore?.Get<byte[]>("backgroundImage"); }
            set { BackingStore?.Set("backgroundImage", value); }
        }
#endif
        /// <summary>A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundImageRelativeUrl {
            get { return BackingStore?.Get<string?>("backgroundImageRelativeUrl"); }
            set { BackingStore?.Set("backgroundImageRelativeUrl", value); }
        }
#nullable restore
#else
        public string BackgroundImageRelativeUrl {
            get { return BackingStore?.Get<string>("backgroundImageRelativeUrl"); }
            set { BackingStore?.Set("backgroundImageRelativeUrl", value); }
        }
#endif
        /// <summary>A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? BannerLogo {
            get { return BackingStore?.Get<byte[]?>("bannerLogo"); }
            set { BackingStore?.Set("bannerLogo", value); }
        }
#nullable restore
#else
        public byte[] BannerLogo {
            get { return BackingStore?.Get<byte[]>("bannerLogo"); }
            set { BackingStore?.Set("bannerLogo", value); }
        }
#endif
        /// <summary>A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BannerLogoRelativeUrl {
            get { return BackingStore?.Get<string?>("bannerLogoRelativeUrl"); }
            set { BackingStore?.Set("bannerLogoRelativeUrl", value); }
        }
#nullable restore
#else
        public string BannerLogoRelativeUrl {
            get { return BackingStore?.Get<string>("bannerLogoRelativeUrl"); }
            set { BackingStore?.Set("bannerLogoRelativeUrl", value); }
        }
#endif
        /// <summary>A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CdnList {
            get { return BackingStore?.Get<List<string>?>("cdnList"); }
            set { BackingStore?.Set("cdnList", value); }
        }
#nullable restore
#else
        public List<string> CdnList {
            get { return BackingStore?.Get<List<string>>("cdnList"); }
            set { BackingStore?.Set("cdnList", value); }
        }
#endif
        /// <summary>A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomAccountResetCredentialsUrl {
            get { return BackingStore?.Get<string?>("customAccountResetCredentialsUrl"); }
            set { BackingStore?.Set("customAccountResetCredentialsUrl", value); }
        }
#nullable restore
#else
        public string CustomAccountResetCredentialsUrl {
            get { return BackingStore?.Get<string>("customAccountResetCredentialsUrl"); }
            set { BackingStore?.Set("customAccountResetCredentialsUrl", value); }
        }
#endif
        /// <summary>A string to replace the default &apos;Can&apos;t access your account?&apos; self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCannotAccessYourAccountText {
            get { return BackingStore?.Get<string?>("customCannotAccessYourAccountText"); }
            set { BackingStore?.Set("customCannotAccessYourAccountText", value); }
        }
#nullable restore
#else
        public string CustomCannotAccessYourAccountText {
            get { return BackingStore?.Get<string>("customCannotAccessYourAccountText"); }
            set { BackingStore?.Set("customCannotAccessYourAccountText", value); }
        }
#endif
        /// <summary>A custom URL to replace the default URL of the self-service password reset (SSPR) &apos;Can&apos;t access your account?&apos; hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCannotAccessYourAccountUrl {
            get { return BackingStore?.Get<string?>("customCannotAccessYourAccountUrl"); }
            set { BackingStore?.Set("customCannotAccessYourAccountUrl", value); }
        }
#nullable restore
#else
        public string CustomCannotAccessYourAccountUrl {
            get { return BackingStore?.Get<string>("customCannotAccessYourAccountUrl"); }
            set { BackingStore?.Set("customCannotAccessYourAccountUrl", value); }
        }
#endif
        /// <summary>CSS styling that appears on the sign-in page. The allowed format is .css format only and not larger than 25 KB.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? CustomCSS {
            get { return BackingStore?.Get<byte[]?>("customCSS"); }
            set { BackingStore?.Set("customCSS", value); }
        }
#nullable restore
#else
        public byte[] CustomCSS {
            get { return BackingStore?.Get<byte[]>("customCSS"); }
            set { BackingStore?.Set("customCSS", value); }
        }
#endif
        /// <summary>A relative URL for the customCSS property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCSSRelativeUrl {
            get { return BackingStore?.Get<string?>("customCSSRelativeUrl"); }
            set { BackingStore?.Set("customCSSRelativeUrl", value); }
        }
#nullable restore
#else
        public string CustomCSSRelativeUrl {
            get { return BackingStore?.Get<string>("customCSSRelativeUrl"); }
            set { BackingStore?.Set("customCSSRelativeUrl", value); }
        }
#endif
        /// <summary>A string to replace the default &apos;Forgot my password&apos; hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomForgotMyPasswordText {
            get { return BackingStore?.Get<string?>("customForgotMyPasswordText"); }
            set { BackingStore?.Set("customForgotMyPasswordText", value); }
        }
#nullable restore
#else
        public string CustomForgotMyPasswordText {
            get { return BackingStore?.Get<string>("customForgotMyPasswordText"); }
            set { BackingStore?.Set("customForgotMyPasswordText", value); }
        }
#endif
        /// <summary>A string to replace the default &apos;Privacy and Cookies&apos; hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomPrivacyAndCookiesText {
            get { return BackingStore?.Get<string?>("customPrivacyAndCookiesText"); }
            set { BackingStore?.Set("customPrivacyAndCookiesText", value); }
        }
#nullable restore
#else
        public string CustomPrivacyAndCookiesText {
            get { return BackingStore?.Get<string>("customPrivacyAndCookiesText"); }
            set { BackingStore?.Set("customPrivacyAndCookiesText", value); }
        }
#endif
        /// <summary>A custom URL to replace the default URL of the &apos;Privacy and Cookies&apos; hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomPrivacyAndCookiesUrl {
            get { return BackingStore?.Get<string?>("customPrivacyAndCookiesUrl"); }
            set { BackingStore?.Set("customPrivacyAndCookiesUrl", value); }
        }
#nullable restore
#else
        public string CustomPrivacyAndCookiesUrl {
            get { return BackingStore?.Get<string>("customPrivacyAndCookiesUrl"); }
            set { BackingStore?.Set("customPrivacyAndCookiesUrl", value); }
        }
#endif
        /// <summary>A string to replace the default &apos;reset it now&apos; hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the &apos;reset it now&apos; hyperlink text is currently not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomResetItNowText {
            get { return BackingStore?.Get<string?>("customResetItNowText"); }
            set { BackingStore?.Set("customResetItNowText", value); }
        }
#nullable restore
#else
        public string CustomResetItNowText {
            get { return BackingStore?.Get<string>("customResetItNowText"); }
            set { BackingStore?.Set("customResetItNowText", value); }
        }
#endif
        /// <summary>A string to replace the the default &apos;Terms of Use&apos; hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomTermsOfUseText {
            get { return BackingStore?.Get<string?>("customTermsOfUseText"); }
            set { BackingStore?.Set("customTermsOfUseText", value); }
        }
#nullable restore
#else
        public string CustomTermsOfUseText {
            get { return BackingStore?.Get<string>("customTermsOfUseText"); }
            set { BackingStore?.Set("customTermsOfUseText", value); }
        }
#endif
        /// <summary>A custom URL to replace the default URL of the &apos;Terms of Use&apos; hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomTermsOfUseUrl {
            get { return BackingStore?.Get<string?>("customTermsOfUseUrl"); }
            set { BackingStore?.Set("customTermsOfUseUrl", value); }
        }
#nullable restore
#else
        public string CustomTermsOfUseUrl {
            get { return BackingStore?.Get<string>("customTermsOfUseUrl"); }
            set { BackingStore?.Set("customTermsOfUseUrl", value); }
        }
#endif
        /// <summary>A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Favicon {
            get { return BackingStore?.Get<byte[]?>("favicon"); }
            set { BackingStore?.Set("favicon", value); }
        }
#nullable restore
#else
        public byte[] Favicon {
            get { return BackingStore?.Get<byte[]>("favicon"); }
            set { BackingStore?.Set("favicon", value); }
        }
#endif
        /// <summary>A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FaviconRelativeUrl {
            get { return BackingStore?.Get<string?>("faviconRelativeUrl"); }
            set { BackingStore?.Set("faviconRelativeUrl", value); }
        }
#nullable restore
#else
        public string FaviconRelativeUrl {
            get { return BackingStore?.Get<string>("faviconRelativeUrl"); }
            set { BackingStore?.Set("faviconRelativeUrl", value); }
        }
#endif
        /// <summary>The RGB color to apply to customize the color of the header.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeaderBackgroundColor {
            get { return BackingStore?.Get<string?>("headerBackgroundColor"); }
            set { BackingStore?.Set("headerBackgroundColor", value); }
        }
#nullable restore
#else
        public string HeaderBackgroundColor {
            get { return BackingStore?.Get<string>("headerBackgroundColor"); }
            set { BackingStore?.Set("headerBackgroundColor", value); }
        }
#endif
        /// <summary>A company logo that appears in the header of the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? HeaderLogo {
            get { return BackingStore?.Get<byte[]?>("headerLogo"); }
            set { BackingStore?.Set("headerLogo", value); }
        }
#nullable restore
#else
        public byte[] HeaderLogo {
            get { return BackingStore?.Get<byte[]>("headerLogo"); }
            set { BackingStore?.Set("headerLogo", value); }
        }
#endif
        /// <summary>A relative URL for the headerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeaderLogoRelativeUrl {
            get { return BackingStore?.Get<string?>("headerLogoRelativeUrl"); }
            set { BackingStore?.Set("headerLogoRelativeUrl", value); }
        }
#nullable restore
#else
        public string HeaderLogoRelativeUrl {
            get { return BackingStore?.Get<string>("headerLogoRelativeUrl"); }
            set { BackingStore?.Set("headerLogoRelativeUrl", value); }
        }
#endif
        /// <summary>Represents the layout configuration to be displayed on the login page for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration? LoginPageLayoutConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration?>("loginPageLayoutConfiguration"); }
            set { BackingStore?.Set("loginPageLayoutConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration LoginPageLayoutConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration>("loginPageLayoutConfiguration"); }
            set { BackingStore?.Set("loginPageLayoutConfiguration", value); }
        }
#endif
        /// <summary>Represents the various texts that can be hidden on the login page for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings? LoginPageTextVisibilitySettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings?>("loginPageTextVisibilitySettings"); }
            set { BackingStore?.Set("loginPageTextVisibilitySettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings LoginPageTextVisibilitySettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>("loginPageTextVisibilitySettings"); }
            set { BackingStore?.Set("loginPageTextVisibilitySettings", value); }
        }
#endif
        /// <summary>Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInPageText {
            get { return BackingStore?.Get<string?>("signInPageText"); }
            set { BackingStore?.Set("signInPageText", value); }
        }
#nullable restore
#else
        public string SignInPageText {
            get { return BackingStore?.Get<string>("signInPageText"); }
            set { BackingStore?.Set("signInPageText", value); }
        }
#endif
        /// <summary>A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? SquareLogo {
            get { return BackingStore?.Get<byte[]?>("squareLogo"); }
            set { BackingStore?.Set("squareLogo", value); }
        }
#nullable restore
#else
        public byte[] SquareLogo {
            get { return BackingStore?.Get<byte[]>("squareLogo"); }
            set { BackingStore?.Set("squareLogo", value); }
        }
#endif
        /// <summary>A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? SquareLogoDark {
            get { return BackingStore?.Get<byte[]?>("squareLogoDark"); }
            set { BackingStore?.Set("squareLogoDark", value); }
        }
#nullable restore
#else
        public byte[] SquareLogoDark {
            get { return BackingStore?.Get<byte[]>("squareLogoDark"); }
            set { BackingStore?.Set("squareLogoDark", value); }
        }
#endif
        /// <summary>A relative URL for the squareLogoDark property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SquareLogoDarkRelativeUrl {
            get { return BackingStore?.Get<string?>("squareLogoDarkRelativeUrl"); }
            set { BackingStore?.Set("squareLogoDarkRelativeUrl", value); }
        }
#nullable restore
#else
        public string SquareLogoDarkRelativeUrl {
            get { return BackingStore?.Get<string>("squareLogoDarkRelativeUrl"); }
            set { BackingStore?.Set("squareLogoDarkRelativeUrl", value); }
        }
#endif
        /// <summary>A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SquareLogoRelativeUrl {
            get { return BackingStore?.Get<string?>("squareLogoRelativeUrl"); }
            set { BackingStore?.Set("squareLogoRelativeUrl", value); }
        }
#nullable restore
#else
        public string SquareLogoRelativeUrl {
            get { return BackingStore?.Get<string>("squareLogoRelativeUrl"); }
            set { BackingStore?.Set("squareLogoRelativeUrl", value); }
        }
#endif
        /// <summary>A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can&apos;t exceed 64 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsernameHintText {
            get { return BackingStore?.Get<string?>("usernameHintText"); }
            set { BackingStore?.Set("usernameHintText", value); }
        }
#nullable restore
#else
        public string UsernameHintText {
            get { return BackingStore?.Get<string>("usernameHintText"); }
            set { BackingStore?.Set("usernameHintText", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OrganizationalBrandingProperties CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.organizationalBranding" => new OrganizationalBranding(),
                "#microsoft.graph.organizationalBrandingLocalization" => new OrganizationalBrandingLocalization(),
                _ => new OrganizationalBrandingProperties(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"backgroundColor", n => { BackgroundColor = n.GetStringValue(); } },
                {"backgroundImage", n => { BackgroundImage = n.GetByteArrayValue(); } },
                {"backgroundImageRelativeUrl", n => { BackgroundImageRelativeUrl = n.GetStringValue(); } },
                {"bannerLogo", n => { BannerLogo = n.GetByteArrayValue(); } },
                {"bannerLogoRelativeUrl", n => { BannerLogoRelativeUrl = n.GetStringValue(); } },
                {"cdnList", n => { CdnList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"customAccountResetCredentialsUrl", n => { CustomAccountResetCredentialsUrl = n.GetStringValue(); } },
                {"customCannotAccessYourAccountText", n => { CustomCannotAccessYourAccountText = n.GetStringValue(); } },
                {"customCannotAccessYourAccountUrl", n => { CustomCannotAccessYourAccountUrl = n.GetStringValue(); } },
                {"customCSS", n => { CustomCSS = n.GetByteArrayValue(); } },
                {"customCSSRelativeUrl", n => { CustomCSSRelativeUrl = n.GetStringValue(); } },
                {"customForgotMyPasswordText", n => { CustomForgotMyPasswordText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesText", n => { CustomPrivacyAndCookiesText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesUrl", n => { CustomPrivacyAndCookiesUrl = n.GetStringValue(); } },
                {"customResetItNowText", n => { CustomResetItNowText = n.GetStringValue(); } },
                {"customTermsOfUseText", n => { CustomTermsOfUseText = n.GetStringValue(); } },
                {"customTermsOfUseUrl", n => { CustomTermsOfUseUrl = n.GetStringValue(); } },
                {"favicon", n => { Favicon = n.GetByteArrayValue(); } },
                {"faviconRelativeUrl", n => { FaviconRelativeUrl = n.GetStringValue(); } },
                {"headerBackgroundColor", n => { HeaderBackgroundColor = n.GetStringValue(); } },
                {"headerLogo", n => { HeaderLogo = n.GetByteArrayValue(); } },
                {"headerLogoRelativeUrl", n => { HeaderLogoRelativeUrl = n.GetStringValue(); } },
                {"loginPageLayoutConfiguration", n => { LoginPageLayoutConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration>(Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration.CreateFromDiscriminatorValue); } },
                {"loginPageTextVisibilitySettings", n => { LoginPageTextVisibilitySettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>(Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings.CreateFromDiscriminatorValue); } },
                {"signInPageText", n => { SignInPageText = n.GetStringValue(); } },
                {"squareLogo", n => { SquareLogo = n.GetByteArrayValue(); } },
                {"squareLogoDark", n => { SquareLogoDark = n.GetByteArrayValue(); } },
                {"squareLogoDarkRelativeUrl", n => { SquareLogoDarkRelativeUrl = n.GetStringValue(); } },
                {"squareLogoRelativeUrl", n => { SquareLogoRelativeUrl = n.GetStringValue(); } },
                {"usernameHintText", n => { UsernameHintText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteByteArrayValue("backgroundImage", BackgroundImage);
            writer.WriteStringValue("backgroundImageRelativeUrl", BackgroundImageRelativeUrl);
            writer.WriteByteArrayValue("bannerLogo", BannerLogo);
            writer.WriteStringValue("bannerLogoRelativeUrl", BannerLogoRelativeUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("cdnList", CdnList);
            writer.WriteStringValue("customAccountResetCredentialsUrl", CustomAccountResetCredentialsUrl);
            writer.WriteStringValue("customCannotAccessYourAccountText", CustomCannotAccessYourAccountText);
            writer.WriteStringValue("customCannotAccessYourAccountUrl", CustomCannotAccessYourAccountUrl);
            writer.WriteByteArrayValue("customCSS", CustomCSS);
            writer.WriteStringValue("customCSSRelativeUrl", CustomCSSRelativeUrl);
            writer.WriteStringValue("customForgotMyPasswordText", CustomForgotMyPasswordText);
            writer.WriteStringValue("customPrivacyAndCookiesText", CustomPrivacyAndCookiesText);
            writer.WriteStringValue("customPrivacyAndCookiesUrl", CustomPrivacyAndCookiesUrl);
            writer.WriteStringValue("customResetItNowText", CustomResetItNowText);
            writer.WriteStringValue("customTermsOfUseText", CustomTermsOfUseText);
            writer.WriteStringValue("customTermsOfUseUrl", CustomTermsOfUseUrl);
            writer.WriteByteArrayValue("favicon", Favicon);
            writer.WriteStringValue("faviconRelativeUrl", FaviconRelativeUrl);
            writer.WriteStringValue("headerBackgroundColor", HeaderBackgroundColor);
            writer.WriteByteArrayValue("headerLogo", HeaderLogo);
            writer.WriteStringValue("headerLogoRelativeUrl", HeaderLogoRelativeUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LoginPageLayoutConfiguration>("loginPageLayoutConfiguration", LoginPageLayoutConfiguration);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>("loginPageTextVisibilitySettings", LoginPageTextVisibilitySettings);
            writer.WriteStringValue("signInPageText", SignInPageText);
            writer.WriteByteArrayValue("squareLogo", SquareLogo);
            writer.WriteByteArrayValue("squareLogoDark", SquareLogoDark);
            writer.WriteStringValue("squareLogoDarkRelativeUrl", SquareLogoDarkRelativeUrl);
            writer.WriteStringValue("squareLogoRelativeUrl", SquareLogoRelativeUrl);
            writer.WriteStringValue("usernameHintText", UsernameHintText);
        }
    }
}
