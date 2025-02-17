namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery Resource Group custom input.</summary>
    public partial class RecoveryResourceGroupCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryResourceGroupCustomDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryResourceGroupCustomDetailsInternal
    {

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Creates an new <see cref="RecoveryResourceGroupCustomDetails" /> instance.</summary>
        public RecoveryResourceGroupCustomDetails()
        {

        }
    }
    /// Recovery Resource Group custom input.
    public partial interface IRecoveryResourceGroupCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }

    }
    /// Recovery Resource Group custom input.
    internal partial interface IRecoveryResourceGroupCustomDetailsInternal

    {
        /// <summary>The class type.</summary>
        string ResourceType { get; set; }

    }
}