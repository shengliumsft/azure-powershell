namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Represents a Database.</summary>
    public partial class Database :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabase,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabaseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.Resource();

        /// <summary>The charset of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string Charset { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabasePropertiesInternal)Property).Charset; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabasePropertiesInternal)Property).Charset = value ?? null; }

        /// <summary>The collation of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string Collation { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabasePropertiesInternal)Property).Collation; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabasePropertiesInternal)Property).Collation = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabaseProperties Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabaseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.DatabaseProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabaseProperties _property;

        /// <summary>The properties of a database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabaseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.DatabaseProperties()); set => this._property = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Database" /> instance.</summary>
        public Database()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Represents a Database.
    public partial interface IDatabase :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource
    {
        /// <summary>The charset of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The charset of the database.",
        SerializedName = @"charset",
        PossibleTypes = new [] { typeof(string) })]
        string Charset { get; set; }
        /// <summary>The collation of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collation of the database.",
        SerializedName = @"collation",
        PossibleTypes = new [] { typeof(string) })]
        string Collation { get; set; }

    }
    /// Represents a Database.
    internal partial interface IDatabaseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal
    {
        /// <summary>The charset of the database.</summary>
        string Charset { get; set; }
        /// <summary>The collation of the database.</summary>
        string Collation { get; set; }
        /// <summary>The properties of a database.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IDatabaseProperties Property { get; set; }

    }
}