namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Session Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSessionOptionsRequest>))]
public class PatchSessionOptionsRequest
{
  /// <summary>
  /// Persistence Mode of the session.
  /// </summary>
  public Optional<SessionPersistenceModes> PersistenceMode { get; set; }

  /// <summary>
  /// Expiration Type
  /// </summary>
  public Optional<ExpirationTypes> ExpirationType { get; set; }

  /// <summary>
  /// Specifies the duration in minutes after which the user session will expire in accordance with the expiration type.
  /// </summary>
  public Optional<int> SlidingSessionLifetime { get; set; }

  /// <summary>
  /// Specifies the duration in minutes after which the user session will expire regardless of the expiration type.
  /// </summary>
  public Optional<int> AbsoluteSessionLifetime { get; set; }
}


