// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ServicePrincipalSignInActivity : Entity, IParsable {
        /// <summary>The application ID of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>The sign-in activity of the application in a app-only authentication flow (app-to-app tokens) where the application acts like a client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInActivity? ApplicationAuthenticationClientSignInActivity {
            get { return BackingStore?.Get<SignInActivity?>("applicationAuthenticationClientSignInActivity"); }
            set { BackingStore?.Set("applicationAuthenticationClientSignInActivity", value); }
        }
#nullable restore
#else
        public SignInActivity ApplicationAuthenticationClientSignInActivity {
            get { return BackingStore?.Get<SignInActivity>("applicationAuthenticationClientSignInActivity"); }
            set { BackingStore?.Set("applicationAuthenticationClientSignInActivity", value); }
        }
#endif
        /// <summary>The sign-in activity of the application in a app-only authentication flow (app-to-app tokens) where the application acts like a resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInActivity? ApplicationAuthenticationResourceSignInActivity {
            get { return BackingStore?.Get<SignInActivity?>("applicationAuthenticationResourceSignInActivity"); }
            set { BackingStore?.Set("applicationAuthenticationResourceSignInActivity", value); }
        }
#nullable restore
#else
        public SignInActivity ApplicationAuthenticationResourceSignInActivity {
            get { return BackingStore?.Get<SignInActivity>("applicationAuthenticationResourceSignInActivity"); }
            set { BackingStore?.Set("applicationAuthenticationResourceSignInActivity", value); }
        }
#endif
        /// <summary>The sign-in activity of the application in a delegated flow (user sign-in) where the application acts like a client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInActivity? DelegatedClientSignInActivity {
            get { return BackingStore?.Get<SignInActivity?>("delegatedClientSignInActivity"); }
            set { BackingStore?.Set("delegatedClientSignInActivity", value); }
        }
#nullable restore
#else
        public SignInActivity DelegatedClientSignInActivity {
            get { return BackingStore?.Get<SignInActivity>("delegatedClientSignInActivity"); }
            set { BackingStore?.Set("delegatedClientSignInActivity", value); }
        }
#endif
        /// <summary>The sign-in activity of the application in a delegated flow (user sign-in) where the application acts like a resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInActivity? DelegatedResourceSignInActivity {
            get { return BackingStore?.Get<SignInActivity?>("delegatedResourceSignInActivity"); }
            set { BackingStore?.Set("delegatedResourceSignInActivity", value); }
        }
#nullable restore
#else
        public SignInActivity DelegatedResourceSignInActivity {
            get { return BackingStore?.Get<SignInActivity>("delegatedResourceSignInActivity"); }
            set { BackingStore?.Set("delegatedResourceSignInActivity", value); }
        }
#endif
        /// <summary>The most recent sign-in activity of the application across delegated or app-only flows where the application is used either as a client or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInActivity? LastSignInActivity {
            get { return BackingStore?.Get<SignInActivity?>("lastSignInActivity"); }
            set { BackingStore?.Set("lastSignInActivity", value); }
        }
#nullable restore
#else
        public SignInActivity LastSignInActivity {
            get { return BackingStore?.Get<SignInActivity>("lastSignInActivity"); }
            set { BackingStore?.Set("lastSignInActivity", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ServicePrincipalSignInActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServicePrincipalSignInActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalSignInActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"applicationAuthenticationClientSignInActivity", n => { ApplicationAuthenticationClientSignInActivity = n.GetObjectValue<SignInActivity>(SignInActivity.CreateFromDiscriminatorValue); } },
                {"applicationAuthenticationResourceSignInActivity", n => { ApplicationAuthenticationResourceSignInActivity = n.GetObjectValue<SignInActivity>(SignInActivity.CreateFromDiscriminatorValue); } },
                {"delegatedClientSignInActivity", n => { DelegatedClientSignInActivity = n.GetObjectValue<SignInActivity>(SignInActivity.CreateFromDiscriminatorValue); } },
                {"delegatedResourceSignInActivity", n => { DelegatedResourceSignInActivity = n.GetObjectValue<SignInActivity>(SignInActivity.CreateFromDiscriminatorValue); } },
                {"lastSignInActivity", n => { LastSignInActivity = n.GetObjectValue<SignInActivity>(SignInActivity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteObjectValue<SignInActivity>("applicationAuthenticationClientSignInActivity", ApplicationAuthenticationClientSignInActivity);
            writer.WriteObjectValue<SignInActivity>("applicationAuthenticationResourceSignInActivity", ApplicationAuthenticationResourceSignInActivity);
            writer.WriteObjectValue<SignInActivity>("delegatedClientSignInActivity", DelegatedClientSignInActivity);
            writer.WriteObjectValue<SignInActivity>("delegatedResourceSignInActivity", DelegatedResourceSignInActivity);
            writer.WriteObjectValue<SignInActivity>("lastSignInActivity", LastSignInActivity);
        }
    }
}
