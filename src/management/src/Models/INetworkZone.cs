namespace MonoCloud.Management.Models;

/// <summary>
/// Network Zone Response: Represents a Network Zone (IP or Regional).
/// </summary>
[JsonConverter(typeof(INetworkZoneJsonConverter))]
public interface INetworkZone
{
  /// <summary>
  /// The unique identifier of the network zone.
  /// </summary>
  string Id { get; set; }

  /// <summary>
  /// Indicates whether the zone is enabled.
  /// </summary>
  bool Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the zone.
  /// </summary>
  string Name { get; set; }

  /// <summary>
  /// The category the zone belongs to.
  /// </summary>
  NetworkZoneCategory Category { get; set; }

  /// <summary>
  /// Specifies the creation time of the zone (in Epoch).
  /// </summary>
  DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the zone (in Epoch).
  /// </summary>
  DateTime LastUpdated { get; set; }

  /// <summary>
  /// The evaluation operator for the network zone.
  /// </summary>
  NetworkZoneOperator Operator { get; set; }

  string Type { get; set; }
}

internal class INetworkZoneJsonConverter : JsonConverter<INetworkZone>
{
  public override INetworkZone? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    using var doc = JsonDocument.ParseValue(ref reader);
    if (!doc.RootElement.TryGetProperty("type", out var typeProperty))
    {
      throw new JsonException("Missing 'type' discriminator property.");
    }

    var typeValue = typeProperty.GetString();
    var json = doc.RootElement.GetRawText();

    return typeValue switch
    {
      "ip" => JsonSerializer.Deserialize<IpNetworkZone>(json, options),
      "regional" => JsonSerializer.Deserialize<RegionalNetworkZone>(json, options),
      _ => throw new JsonException($"Unknown type discriminator value: '{typeValue}'.")
    };
  }

  public override void Write(Utf8JsonWriter writer, INetworkZone value, JsonSerializerOptions options) =>
    JsonSerializer.Serialize(writer, value, value.GetType(), options);
}


