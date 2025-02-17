namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm NIC details.</summary>
    public partial class InMageRcmNicDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal
    {

        /// <summary>Backing field for <see cref="IsPrimaryNic" /> property.</summary>
        private string _isPrimaryNic;

        /// <summary>A value indicating whether this is the primary NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsPrimaryNic { get => this._isPrimaryNic; set => this._isPrimaryNic = value; }

        /// <summary>Backing field for <see cref="IsSelectedForFailover" /> property.</summary>
        private string _isSelectedForFailover;

        /// <summary>A value indicating whether this NIC is selected for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsSelectedForFailover { get => this._isSelectedForFailover; set => this._isSelectedForFailover = value; }

        /// <summary>Internal Acessors for NicId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal.NicId { get => this._nicId; set { {_nicId = value;} } }

        /// <summary>Internal Acessors for SourceIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal.SourceIPAddress { get => this._sourceIPAddress; set { {_sourceIPAddress = value;} } }

        /// <summary>Internal Acessors for SourceIPAddressType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal.SourceIPAddressType { get => this._sourceIPAddressType; set { {_sourceIPAddressType = value;} } }

        /// <summary>Internal Acessors for SourceNetworkId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal.SourceNetworkId { get => this._sourceNetworkId; set { {_sourceNetworkId = value;} } }

        /// <summary>Internal Acessors for SourceSubnetName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal.SourceSubnetName { get => this._sourceSubnetName; set { {_sourceSubnetName = value;} } }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>The NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; }

        /// <summary>Backing field for <see cref="SourceIPAddress" /> property.</summary>
        private string _sourceIPAddress;

        /// <summary>The source IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceIPAddress { get => this._sourceIPAddress; }

        /// <summary>Backing field for <see cref="SourceIPAddressType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? _sourceIPAddressType;

        /// <summary>The source IP address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? SourceIPAddressType { get => this._sourceIPAddressType; }

        /// <summary>Backing field for <see cref="SourceNetworkId" /> property.</summary>
        private string _sourceNetworkId;

        /// <summary>Source network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceNetworkId { get => this._sourceNetworkId; }

        /// <summary>Backing field for <see cref="SourceSubnetName" /> property.</summary>
        private string _sourceSubnetName;

        /// <summary>Source subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceSubnetName { get => this._sourceSubnetName; }

        /// <summary>Backing field for <see cref="TargetIPAddress" /> property.</summary>
        private string _targetIPAddress;

        /// <summary>The target IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetIPAddress { get => this._targetIPAddress; set => this._targetIPAddress = value; }

        /// <summary>Backing field for <see cref="TargetIPAddressType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? _targetIPAddressType;

        /// <summary>The target IP address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? TargetIPAddressType { get => this._targetIPAddressType; set => this._targetIPAddressType = value; }

        /// <summary>Backing field for <see cref="TargetSubnetName" /> property.</summary>
        private string _targetSubnetName;

        /// <summary>Target subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetSubnetName { get => this._targetSubnetName; set => this._targetSubnetName = value; }

        /// <summary>Backing field for <see cref="TestIPAddress" /> property.</summary>
        private string _testIPAddress;

        /// <summary>The test IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TestIPAddress { get => this._testIPAddress; set => this._testIPAddress = value; }

        /// <summary>Backing field for <see cref="TestIPAddressType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? _testIPAddressType;

        /// <summary>The test IP address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? TestIPAddressType { get => this._testIPAddressType; set => this._testIPAddressType = value; }

        /// <summary>Backing field for <see cref="TestSubnetName" /> property.</summary>
        private string _testSubnetName;

        /// <summary>Test subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TestSubnetName { get => this._testSubnetName; set => this._testSubnetName = value; }

        /// <summary>Creates an new <see cref="InMageRcmNicDetails" /> instance.</summary>
        public InMageRcmNicDetails()
        {

        }
    }
    /// InMageRcm NIC details.
    public partial interface IInMageRcmNicDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>A value indicating whether this is the primary NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether this is the primary NIC.",
        SerializedName = @"isPrimaryNic",
        PossibleTypes = new [] { typeof(string) })]
        string IsPrimaryNic { get; set; }
        /// <summary>A value indicating whether this NIC is selected for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether this NIC is selected for failover.",
        SerializedName = @"isSelectedForFailover",
        PossibleTypes = new [] { typeof(string) })]
        string IsSelectedForFailover { get; set; }
        /// <summary>The NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The NIC Id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get;  }
        /// <summary>The source IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The source IP address.",
        SerializedName = @"sourceIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string SourceIPAddress { get;  }
        /// <summary>The source IP address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The source IP address type.",
        SerializedName = @"sourceIPAddressType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? SourceIPAddressType { get;  }
        /// <summary>Source network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Source network Id.",
        SerializedName = @"sourceNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceNetworkId { get;  }
        /// <summary>Source subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Source subnet name.",
        SerializedName = @"sourceSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceSubnetName { get;  }
        /// <summary>The target IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target IP address.",
        SerializedName = @"targetIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TargetIPAddress { get; set; }
        /// <summary>The target IP address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target IP address type.",
        SerializedName = @"targetIPAddressType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? TargetIPAddressType { get; set; }
        /// <summary>Target subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target subnet name.",
        SerializedName = @"targetSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetSubnetName { get; set; }
        /// <summary>The test IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The test IP address.",
        SerializedName = @"testIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TestIPAddress { get; set; }
        /// <summary>The test IP address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The test IP address type.",
        SerializedName = @"testIPAddressType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? TestIPAddressType { get; set; }
        /// <summary>Test subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Test subnet name.",
        SerializedName = @"testSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TestSubnetName { get; set; }

    }
    /// InMageRcm NIC details.
    internal partial interface IInMageRcmNicDetailsInternal

    {
        /// <summary>A value indicating whether this is the primary NIC.</summary>
        string IsPrimaryNic { get; set; }
        /// <summary>A value indicating whether this NIC is selected for failover.</summary>
        string IsSelectedForFailover { get; set; }
        /// <summary>The NIC Id.</summary>
        string NicId { get; set; }
        /// <summary>The source IP address.</summary>
        string SourceIPAddress { get; set; }
        /// <summary>The source IP address type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? SourceIPAddressType { get; set; }
        /// <summary>Source network Id.</summary>
        string SourceNetworkId { get; set; }
        /// <summary>Source subnet name.</summary>
        string SourceSubnetName { get; set; }
        /// <summary>The target IP address.</summary>
        string TargetIPAddress { get; set; }
        /// <summary>The target IP address type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? TargetIPAddressType { get; set; }
        /// <summary>Target subnet name.</summary>
        string TargetSubnetName { get; set; }
        /// <summary>The test IP address.</summary>
        string TestIPAddress { get; set; }
        /// <summary>The test IP address type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType? TestIPAddressType { get; set; }
        /// <summary>Test subnet name.</summary>
        string TestSubnetName { get; set; }

    }
}