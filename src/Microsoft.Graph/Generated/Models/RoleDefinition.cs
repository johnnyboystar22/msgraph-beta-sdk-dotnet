using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class RoleDefinition : Entity, IParsable {
        /// <summary>Description of the Role definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display Name of the Role definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</summary>
        public bool? IsBuiltInRoleDefinition {
            get { return BackingStore?.Get<bool?>("isBuiltInRoleDefinition"); }
            set { BackingStore?.Set("isBuiltInRoleDefinition", value); }
        }
        /// <summary>List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RolePermission>? Permissions {
            get { return BackingStore?.Get<List<RolePermission>?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public List<RolePermission> Permissions {
            get { return BackingStore?.Get<List<RolePermission>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>List of Role assignments for this role definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleAssignment>? RoleAssignments {
            get { return BackingStore?.Get<List<RoleAssignment>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<RoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<RoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RolePermission>? RolePermissions {
            get { return BackingStore?.Get<List<RolePermission>?>("rolePermissions"); }
            set { BackingStore?.Set("rolePermissions", value); }
        }
#nullable restore
#else
        public List<RolePermission> RolePermissions {
            get { return BackingStore?.Get<List<RolePermission>>("rolePermissions"); }
            set { BackingStore?.Set("rolePermissions", value); }
        }
#endif
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceAndAppManagementRoleDefinition" => new DeviceAndAppManagementRoleDefinition(),
                _ => new RoleDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"isBuiltInRoleDefinition", n => { IsBuiltInRoleDefinition = n.GetBoolValue(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<RolePermission>(RolePermission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<RoleAssignment>(RoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rolePermissions", n => { RolePermissions = n.GetCollectionOfObjectValues<RolePermission>(RolePermission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteBoolValue("isBuiltInRoleDefinition", IsBuiltInRoleDefinition);
            writer.WriteCollectionOfObjectValues<RolePermission>("permissions", Permissions);
            writer.WriteCollectionOfObjectValues<RoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<RolePermission>("rolePermissions", RolePermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
