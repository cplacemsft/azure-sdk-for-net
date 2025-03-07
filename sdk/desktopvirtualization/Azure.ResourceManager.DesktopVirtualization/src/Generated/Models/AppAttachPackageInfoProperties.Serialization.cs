// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class AppAttachPackageInfoProperties : IUtf8JsonSerializable, IJsonModel<AppAttachPackageInfoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppAttachPackageInfoProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppAttachPackageInfoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppAttachPackageInfoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppAttachPackageInfoProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PackageAlias))
            {
                writer.WritePropertyName("packageAlias"u8);
                writer.WriteStringValue(PackageAlias);
            }
            if (Optional.IsDefined(ImagePath))
            {
                writer.WritePropertyName("imagePath"u8);
                writer.WriteStringValue(ImagePath);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(PackageFamilyName))
            {
                writer.WritePropertyName("packageFamilyName"u8);
                writer.WriteStringValue(PackageFamilyName);
            }
            if (Optional.IsDefined(PackageFullName))
            {
                writer.WritePropertyName("packageFullName"u8);
                writer.WriteStringValue(PackageFullName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(PackageRelativePath))
            {
                writer.WritePropertyName("packageRelativePath"u8);
                writer.WriteStringValue(PackageRelativePath);
            }
            if (Optional.IsDefined(IsRegularRegistration))
            {
                writer.WritePropertyName("isRegularRegistration"u8);
                writer.WriteBooleanValue(IsRegularRegistration.Value);
            }
            if (Optional.IsDefined(IsActive))
            {
                writer.WritePropertyName("isActive"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (Optional.IsCollectionDefined(PackageDependencies))
            {
                if (PackageDependencies != null)
                {
                    writer.WritePropertyName("packageDependencies"u8);
                    writer.WriteStartArray();
                    foreach (var item in PackageDependencies)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("packageDependencies");
                }
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(PackageApplications))
            {
                writer.WritePropertyName("packageApplications"u8);
                writer.WriteStartArray();
                foreach (var item in PackageApplications)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CertificateName))
            {
                if (CertificateName != null)
                {
                    writer.WritePropertyName("certificateName"u8);
                    writer.WriteStringValue(CertificateName);
                }
                else
                {
                    writer.WriteNull("certificateName");
                }
            }
            if (Optional.IsDefined(CertificateExpireOn))
            {
                if (CertificateExpireOn != null)
                {
                    writer.WritePropertyName("certificateExpiry"u8);
                    writer.WriteStringValue(CertificateExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("certificateExpiry");
                }
            }
            if (Optional.IsDefined(IsPackageTimestamped))
            {
                if (IsPackageTimestamped != null)
                {
                    writer.WritePropertyName("isPackageTimestamped"u8);
                    writer.WriteStringValue(IsPackageTimestamped.Value.ToString());
                }
                else
                {
                    writer.WriteNull("isPackageTimestamped");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AppAttachPackageInfoProperties IJsonModel<AppAttachPackageInfoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppAttachPackageInfoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppAttachPackageInfoProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppAttachPackageInfoProperties(document.RootElement, options);
        }

        internal static AppAttachPackageInfoProperties DeserializeAppAttachPackageInfoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string packageAlias = default;
            string imagePath = default;
            string packageName = default;
            string packageFamilyName = default;
            string packageFullName = default;
            string displayName = default;
            string packageRelativePath = default;
            bool? isRegularRegistration = default;
            bool? isActive = default;
            IList<MsixPackageDependencies> packageDependencies = default;
            string version = default;
            DateTimeOffset? lastUpdated = default;
            IList<MsixPackageApplications> packageApplications = default;
            string certificateName = default;
            DateTimeOffset? certificateExpiry = default;
            PackageTimestamped? isPackageTimestamped = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packageAlias"u8))
                {
                    packageAlias = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imagePath"u8))
                {
                    imagePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageName"u8))
                {
                    packageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageFamilyName"u8))
                {
                    packageFamilyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageFullName"u8))
                {
                    packageFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageRelativePath"u8))
                {
                    packageRelativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isRegularRegistration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRegularRegistration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isActive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("packageDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        packageDependencies = null;
                        continue;
                    }
                    List<MsixPackageDependencies> array = new List<MsixPackageDependencies>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MsixPackageDependencies.DeserializeMsixPackageDependencies(item, options));
                    }
                    packageDependencies = array;
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("packageApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MsixPackageApplications> array = new List<MsixPackageApplications>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MsixPackageApplications.DeserializeMsixPackageApplications(item, options));
                    }
                    packageApplications = array;
                    continue;
                }
                if (property.NameEquals("certificateName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        certificateName = null;
                        continue;
                    }
                    certificateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateExpiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        certificateExpiry = null;
                        continue;
                    }
                    certificateExpiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isPackageTimestamped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isPackageTimestamped = null;
                        continue;
                    }
                    isPackageTimestamped = new PackageTimestamped(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppAttachPackageInfoProperties(
                packageAlias,
                imagePath,
                packageName,
                packageFamilyName,
                packageFullName,
                displayName,
                packageRelativePath,
                isRegularRegistration,
                isActive,
                packageDependencies ?? new ChangeTrackingList<MsixPackageDependencies>(),
                version,
                lastUpdated,
                packageApplications ?? new ChangeTrackingList<MsixPackageApplications>(),
                certificateName,
                certificateExpiry,
                isPackageTimestamped,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageAlias), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageAlias: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PackageAlias))
                {
                    builder.Append("  packageAlias: ");
                    if (PackageAlias.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PackageAlias}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PackageAlias}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImagePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  imagePath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ImagePath))
                {
                    builder.Append("  imagePath: ");
                    if (ImagePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ImagePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ImagePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PackageName))
                {
                    builder.Append("  packageName: ");
                    if (PackageName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PackageName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PackageName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageFamilyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageFamilyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PackageFamilyName))
                {
                    builder.Append("  packageFamilyName: ");
                    if (PackageFamilyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PackageFamilyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PackageFamilyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageFullName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageFullName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PackageFullName))
                {
                    builder.Append("  packageFullName: ");
                    if (PackageFullName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PackageFullName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PackageFullName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageRelativePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageRelativePath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PackageRelativePath))
                {
                    builder.Append("  packageRelativePath: ");
                    if (PackageRelativePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PackageRelativePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PackageRelativePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsRegularRegistration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isRegularRegistration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsRegularRegistration))
                {
                    builder.Append("  isRegularRegistration: ");
                    var boolValue = IsRegularRegistration.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsActive), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isActive: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsActive))
                {
                    builder.Append("  isActive: ");
                    var boolValue = IsActive.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageDependencies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageDependencies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PackageDependencies))
                {
                    if (PackageDependencies.Any())
                    {
                        builder.Append("  packageDependencies: ");
                        builder.AppendLine("[");
                        foreach (var item in PackageDependencies)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  packageDependencies: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Version))
                {
                    builder.Append("  version: ");
                    if (Version.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Version}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Version}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastUpdated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdatedOn))
                {
                    builder.Append("  lastUpdated: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageApplications), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  packageApplications: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PackageApplications))
                {
                    if (PackageApplications.Any())
                    {
                        builder.Append("  packageApplications: ");
                        builder.AppendLine("[");
                        foreach (var item in PackageApplications)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  packageApplications: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertificateName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certificateName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CertificateName))
                {
                    builder.Append("  certificateName: ");
                    if (CertificateName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CertificateName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CertificateName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertificateExpireOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certificateExpiry: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CertificateExpireOn))
                {
                    builder.Append("  certificateExpiry: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CertificateExpireOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPackageTimestamped), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isPackageTimestamped: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPackageTimestamped))
                {
                    builder.Append("  isPackageTimestamped: ");
                    builder.AppendLine($"'{IsPackageTimestamped.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppAttachPackageInfoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppAttachPackageInfoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppAttachPackageInfoProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppAttachPackageInfoProperties IPersistableModel<AppAttachPackageInfoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppAttachPackageInfoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppAttachPackageInfoProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppAttachPackageInfoProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppAttachPackageInfoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
