namespace MonoCloud.Management.Models;

/// <summary>
/// User MFA Passkey: Represents a passkey / security key enrolled by the user as a second factor.
/// </summary>
public class UserMfaPasskey
{
  /// <summary>
  /// The unique identifier of the MFA passkey.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Human-readable name assigned to the passkey.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Unique identifier of the passkey as provided by the authenticator.
  /// </summary>
  public string PasskeyId { get; set; }

  /// <summary>
  /// Public key material associated with the passkey.
  /// </summary>
  public string PublicKey { get; set; }

  /// <summary>
  /// Authenticator Attestation GUID (AAGUID) identifying the authenticator model.
  /// </summary>
  public Guid AaGuid { get; set; }

  /// <summary>
  /// Indicates whether the passkey is currently backed up by the authenticator.
  /// </summary>
  public bool BackupState { get; set; }

  /// <summary>
  /// Indicates whether the passkey is eligible for backup and multi-device use.
  /// </summary>
  public bool BackupEligibility { get; set; }

  /// <summary>
  /// Indicates whether user presence was verified during passkey registration.
  /// </summary>
  public bool UserPresent { get; set; }

  /// <summary>
  /// Indicates whether user verification (such as biometrics or PIN) was performed during registration.
  /// </summary>
  public bool UserVerified { get; set; }

  /// <summary>
  /// User agent of the device used to register the passkey.
  /// </summary>
  public string UserAgent { get; set; }

  /// <summary>
  /// Specifies the creation time of the passkey (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the time the passkey was last used (in Epoch).
  /// </summary>
  public DateTime? LastUsed { get; set; }
}


