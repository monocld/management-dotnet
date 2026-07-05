namespace MonoCloud.Management.Models;

/// <summary>
/// User MFA TOTP Authenticator: Represents a TOTP authenticator enrolled by the user as a second factor.
/// </summary>
public class UserMfaTotpAuthenticator
{
  /// <summary>
  /// The unique identifier of the TOTP authenticator.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Human-readable name assigned to the authenticator.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Specifies the creation time of the authenticator (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the time the authenticator was last used (in Epoch).
  /// </summary>
  public DateTime? LastUsed { get; set; }
}


