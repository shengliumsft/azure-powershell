namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The tags for the target managed disks.</summary>
    public partial class HyperVReplicaAzureReplicationDetailsTargetManagedDiskTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureReplicationDetailsTargetManagedDiskTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureReplicationDetailsTargetManagedDiskTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="HyperVReplicaAzureReplicationDetailsTargetManagedDiskTags" /> instance.
        /// </summary>
        public HyperVReplicaAzureReplicationDetailsTargetManagedDiskTags()
        {

        }
    }
    /// The tags for the target managed disks.
    public partial interface IHyperVReplicaAzureReplicationDetailsTargetManagedDiskTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags for the target managed disks.
    internal partial interface IHyperVReplicaAzureReplicationDetailsTargetManagedDiskTagsInternal

    {

    }
}