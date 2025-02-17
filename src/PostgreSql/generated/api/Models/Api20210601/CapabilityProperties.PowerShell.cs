namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>Location capabilities.</summary>
    [System.ComponentModel.TypeConverter(typeof(CapabilityPropertiesTypeConverter))]
    public partial class CapabilityProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.CapabilityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CapabilityProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Zone = (string) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Zone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).GeoBackupSupported = (bool?) content.GetValueForProperty("GeoBackupSupported",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).GeoBackupSupported, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaSupported = (bool?) content.GetValueForProperty("ZoneRedundantHaSupported",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaSupported, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaAndGeoBackupSupported = (bool?) content.GetValueForProperty("ZoneRedundantHaAndGeoBackupSupported",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaAndGeoBackupSupported, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedFlexibleServerEdition = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[]) content.GetValueForProperty("SupportedFlexibleServerEdition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedFlexibleServerEdition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.FlexibleServerEditionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedHyperscaleNodeEdition = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[]) content.GetValueForProperty("SupportedHyperscaleNodeEdition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedHyperscaleNodeEdition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HyperscaleNodeEditionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Status, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.CapabilityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CapabilityProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Zone = (string) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Zone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).GeoBackupSupported = (bool?) content.GetValueForProperty("GeoBackupSupported",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).GeoBackupSupported, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaSupported = (bool?) content.GetValueForProperty("ZoneRedundantHaSupported",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaSupported, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaAndGeoBackupSupported = (bool?) content.GetValueForProperty("ZoneRedundantHaAndGeoBackupSupported",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).ZoneRedundantHaAndGeoBackupSupported, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedFlexibleServerEdition = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[]) content.GetValueForProperty("SupportedFlexibleServerEdition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedFlexibleServerEdition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.FlexibleServerEditionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedHyperscaleNodeEdition = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[]) content.GetValueForProperty("SupportedHyperscaleNodeEdition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).SupportedHyperscaleNodeEdition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HyperscaleNodeEditionCapabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal)this).Status, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.CapabilityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CapabilityProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.CapabilityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CapabilityProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CapabilityProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Location capabilities.
    [System.ComponentModel.TypeConverter(typeof(CapabilityPropertiesTypeConverter))]
    public partial interface ICapabilityProperties

    {

    }
}