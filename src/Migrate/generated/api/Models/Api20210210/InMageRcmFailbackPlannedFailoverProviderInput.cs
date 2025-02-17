namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Provider specific input for InMageRcmFailback failover.</summary>
    public partial class InMageRcmFailbackPlannedFailoverProviderInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackPlannedFailoverProviderInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackPlannedFailoverProviderInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInput __plannedFailoverProviderSpecificFailoverInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PlannedFailoverProviderSpecificFailoverInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInputInternal)__plannedFailoverProviderSpecificFailoverInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInputInternal)__plannedFailoverProviderSpecificFailoverInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageRcmFailbackRecoveryPointType _recoveryPointType;

        /// <summary>The recovery point type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageRcmFailbackRecoveryPointType RecoveryPointType { get => this._recoveryPointType; set => this._recoveryPointType = value; }

        /// <summary>
        /// Creates an new <see cref="InMageRcmFailbackPlannedFailoverProviderInput" /> instance.
        /// </summary>
        public InMageRcmFailbackPlannedFailoverProviderInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__plannedFailoverProviderSpecificFailoverInput), __plannedFailoverProviderSpecificFailoverInput);
            await eventListener.AssertObjectIsValid(nameof(__plannedFailoverProviderSpecificFailoverInput), __plannedFailoverProviderSpecificFailoverInput);
        }
    }
    /// Provider specific input for InMageRcmFailback failover.
    public partial interface IInMageRcmFailbackPlannedFailoverProviderInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInput
    {
        /// <summary>The recovery point type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery point type.",
        SerializedName = @"recoveryPointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageRcmFailbackRecoveryPointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageRcmFailbackRecoveryPointType RecoveryPointType { get; set; }

    }
    /// Provider specific input for InMageRcmFailback failover.
    internal partial interface IInMageRcmFailbackPlannedFailoverProviderInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInputInternal
    {
        /// <summary>The recovery point type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageRcmFailbackRecoveryPointType RecoveryPointType { get; set; }

    }
}