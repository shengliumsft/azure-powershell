namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Backup properties of a server</summary>
    public partial class Backup
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject into a new instance of <see cref="Backup" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Backup(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_retentionDay = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("backupRetentionDays"), out var __jsonBackupRetentionDays) ? (int?)__jsonBackupRetentionDays : RetentionDay;}
            {_geoRedundantBackup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("geoRedundantBackup"), out var __jsonGeoRedundantBackup) ? (string)__jsonGeoRedundantBackup : (string)GeoRedundantBackup;}
            {_earliestRestoreDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("earliestRestoreDate"), out var __jsonEarliestRestoreDate) ? global::System.DateTime.TryParse((string)__jsonEarliestRestoreDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEarliestRestoreDateValue) ? __jsonEarliestRestoreDateValue : EarliestRestoreDate : EarliestRestoreDate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json ? new Backup(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Backup" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Backup" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._retentionDay ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._retentionDay) : null, "backupRetentionDays" ,container.Add );
            AddIf( null != (((object)this._geoRedundantBackup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._geoRedundantBackup.ToString()) : null, "geoRedundantBackup" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._earliestRestoreDate ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._earliestRestoreDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "earliestRestoreDate" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}