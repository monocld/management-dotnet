namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Password Authenticator Reuse Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsPasswordReuseOptionsRequest>))]
public class PatchAuthenticatorsPasswordReuseOptionsRequest
{
  /// <summary>
  /// Specifies if there should be any restriction for password reuse.
  /// </summary>
  public Optional<PasswordRestrictionModes> RestrictionMode { get; set; }

  /// <summary>
  /// Specifies the time in minutes in which the password cannot be reused.
  /// </summary>
  public Optional<int> RestrictionPeriod { get; set; }

  /// <summary>
  /// Specifies the number of previous passwords which cannot be reused.
  /// </summary>
  public Optional<int> RestrictionCount { get; set; }
}


