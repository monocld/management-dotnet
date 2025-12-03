namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Secret response class
/// </summary>
public class Secret
{
  /// <summary>
  /// Unique ID of the client secret
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Brief description of the secret
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// The expiration date of the secret (in Epoch)
  /// </summary>
  public DateTime? Expiration { get; set; }

  /// <summary>
  /// Specifies type of secret
  /// </summary>
  public SecretTypes Type { get; set; }

  /// <summary>
  /// Specifies the creation time of the client secret (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the client secret (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The secret
  /// </summary>
  public string SecretValue { get; set; }
}


