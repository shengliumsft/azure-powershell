namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcmFailback NIC details.</summary>
    public partial class InMageRcmFailbackNicDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetailsInternal
    {

        /// <summary>Backing field for <see cref="AdapterType" /> property.</summary>
        private string _adapterType;

        /// <summary>The adapter type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AdapterType { get => this._adapterType; }

        /// <summary>Backing field for <see cref="MacAddress" /> property.</summary>
        private string _macAddress;

        /// <summary>The mac address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MacAddress { get => this._macAddress; }

        /// <summary>Internal Acessors for AdapterType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetailsInternal.AdapterType { get => this._adapterType; set { {_adapterType = value;} } }

        /// <summary>Internal Acessors for MacAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetailsInternal.MacAddress { get => this._macAddress; set { {_macAddress = value;} } }

        /// <summary>Internal Acessors for NetworkName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetailsInternal.NetworkName { get => this._networkName; set { {_networkName = value;} } }

        /// <summary>Internal Acessors for SourceIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetailsInternal.SourceIPAddress { get => this._sourceIPAddress; set { {_sourceIPAddress = value;} } }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>The network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; }

        /// <summary>Backing field for <see cref="SourceIPAddress" /> property.</summary>
        private string _sourceIPAddress;

        /// <summary>The IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceIPAddress { get => this._sourceIPAddress; }

        /// <summary>Creates an new <see cref="InMageRcmFailbackNicDetails" /> instance.</summary>
        public InMageRcmFailbackNicDetails()
        {

        }
    }
    /// InMageRcmFailback NIC details.
    public partial interface IInMageRcmFailbackNicDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The adapter type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The adapter type.",
        SerializedName = @"adapterType",
        PossibleTypes = new [] { typeof(string) })]
        string AdapterType { get;  }
        /// <summary>The mac address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The mac address.",
        SerializedName = @"macAddress",
        PossibleTypes = new [] { typeof(string) })]
        string MacAddress { get;  }
        /// <summary>The network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The network name.",
        SerializedName = @"networkName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get;  }
        /// <summary>The IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The IP address.",
        SerializedName = @"sourceIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string SourceIPAddress { get;  }

    }
    /// InMageRcmFailback NIC details.
    internal partial interface IInMageRcmFailbackNicDetailsInternal

    {
        /// <summary>The adapter type.</summary>
        string AdapterType { get; set; }
        /// <summary>The mac address.</summary>
        string MacAddress { get; set; }
        /// <summary>The network name.</summary>
        string NetworkName { get; set; }
        /// <summary>The IP address.</summary>
        string SourceIPAddress { get; set; }

    }
}