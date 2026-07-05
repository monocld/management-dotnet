namespace MonoCloud.Management.Models;

/// <summary>
/// Certificate Revocation Response: Represents a certificate revocation list (CRL) configured for offline revocation checking within a trust store.
/// </summary>
[JsonConverter(typeof(ICertificateRevocationJsonConverter))]
public interface ICertificateRevocation
{
  /// <summary>
  /// The unique identifier of the delta revocation entry.
  /// </summary>
  string Id { get; set; }

  /// <summary>
  /// The certificate revocation list (CRL) in PEM format.
  /// </summary>
  string Value { get; set; }

  /// <summary>
  /// The thumbprint of the CA certificate that issued this CRL.
  /// </summary>
  string IssuerThumbprint { get; set; }

  /// <summary>
  /// Specifies the time at which the CRL was issued (in Epoch).
  /// </summary>
  DateTime IssuedAt { get; set; }

  /// <summary>
  /// Specifies the time at which this revocation entry was created (in Epoch).
  /// </summary>
  DateTime CreationTime { get; set; }

  string Type { get; set; }
}

internal class ICertificateRevocationJsonConverter : JsonConverter<ICertificateRevocation>
{
  public override ICertificateRevocation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
      "base" => JsonSerializer.Deserialize<BaseCertificateRevocation>(json, options),
      "delta" => JsonSerializer.Deserialize<DeltaCertificateRevocation>(json, options),
      _ => throw new JsonException($"Unknown type discriminator value: '{typeValue}'.")
    };
  }

  public override void Write(Utf8JsonWriter writer, ICertificateRevocation value, JsonSerializerOptions options) =>
    JsonSerializer.Serialize(writer, value, value.GetType(), options);
}


