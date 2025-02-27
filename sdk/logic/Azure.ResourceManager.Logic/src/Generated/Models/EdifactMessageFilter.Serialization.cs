// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactMessageFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("messageFilterType"u8);
            writer.WriteStringValue(MessageFilterType.ToString());
            writer.WriteEndObject();
        }

        internal static EdifactMessageFilter DeserializeEdifactMessageFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MessageFilterType messageFilterType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageFilterType"u8))
                {
                    messageFilterType = new MessageFilterType(property.Value.GetString());
                    continue;
                }
            }
            return new EdifactMessageFilter(messageFilterType);
        }
    }
}
