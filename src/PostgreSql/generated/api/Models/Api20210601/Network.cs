namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Network properties of a server</summary>
    public partial class Network :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetwork,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal
    {

        /// <summary>Backing field for <see cref="DelegatedSubnetResourceId" /> property.</summary>
        private string _delegatedSubnetResourceId;

        /// <summary>delegated subnet arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string DelegatedSubnetResourceId { get => this._delegatedSubnetResourceId; set => this._delegatedSubnetResourceId = value; }

        /// <summary>Internal Acessors for PublicNetworkAccess</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal.PublicNetworkAccess { get => this._publicNetworkAccess; set { {_publicNetworkAccess = value;} } }

        /// <summary>Backing field for <see cref="PrivateDnsZoneArmResourceId" /> property.</summary>
        private string _privateDnsZoneArmResourceId;

        /// <summary>private dns zone arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string PrivateDnsZoneArmResourceId { get => this._privateDnsZoneArmResourceId; set => this._privateDnsZoneArmResourceId = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? _publicNetworkAccess;

        /// <summary>public network access is enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? PublicNetworkAccess { get => this._publicNetworkAccess; }

        /// <summary>Creates an new <see cref="Network" /> instance.</summary>
        public Network()
        {

        }
    }
    /// Network properties of a server
    public partial interface INetwork :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>delegated subnet arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"delegated subnet arm resource id.",
        SerializedName = @"delegatedSubnetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedSubnetResourceId { get; set; }
        /// <summary>private dns zone arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"private dns zone arm resource id.",
        SerializedName = @"privateDnsZoneArmResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateDnsZoneArmResourceId { get; set; }
        /// <summary>public network access is enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"public network access is enabled or not",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? PublicNetworkAccess { get;  }

    }
    /// Network properties of a server
    internal partial interface INetworkInternal

    {
        /// <summary>delegated subnet arm resource id.</summary>
        string DelegatedSubnetResourceId { get; set; }
        /// <summary>private dns zone arm resource id.</summary>
        string PrivateDnsZoneArmResourceId { get; set; }
        /// <summary>public network access is enabled or not</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? PublicNetworkAccess { get; set; }

    }
}