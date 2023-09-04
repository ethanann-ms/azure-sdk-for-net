// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterAutoscaleProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(GracefulDecommissionTimeout))
            {
                writer.WritePropertyName("gracefulDecommissionTimeout"u8);
                writer.WriteNumberValue(GracefulDecommissionTimeout.Value);
            }
            if (Optional.IsDefined(AutoscaleType))
            {
                writer.WritePropertyName("autoscaleType"u8);
                writer.WriteStringValue(AutoscaleType.Value.ToString());
            }
            if (Optional.IsDefined(ScheduleBasedConfig))
            {
                writer.WritePropertyName("scheduleBasedConfig"u8);
                writer.WriteObjectValue(ScheduleBasedConfig);
            }
            if (Optional.IsDefined(LoadBasedConfig))
            {
                writer.WritePropertyName("loadBasedConfig"u8);
                writer.WriteObjectValue(LoadBasedConfig);
            }
            writer.WriteEndObject();
        }

        internal static ClusterAutoscaleProfile DeserializeClusterAutoscaleProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            Optional<int> gracefulDecommissionTimeout = default;
            Optional<ClusterAutoscaleType> autoscaleType = default;
            Optional<ScheduleBasedConfig> scheduleBasedConfig = default;
            Optional<LoadBasedConfig> loadBasedConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gracefulDecommissionTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gracefulDecommissionTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleType = new ClusterAutoscaleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduleBasedConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleBasedConfig = ScheduleBasedConfig.DeserializeScheduleBasedConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("loadBasedConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBasedConfig = LoadBasedConfig.DeserializeLoadBasedConfig(property.Value);
                    continue;
                }
            }
            return new ClusterAutoscaleProfile(enabled, Optional.ToNullable(gracefulDecommissionTimeout), Optional.ToNullable(autoscaleType), scheduleBasedConfig.Value, loadBasedConfig.Value);
        }
    }
}
