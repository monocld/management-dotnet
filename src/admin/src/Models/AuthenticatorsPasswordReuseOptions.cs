namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Password Authenticator Reuse Options response class
/// </summary>
public class AuthenticatorsPasswordReuseOptions
{
  /// <summary>
  /// Specifies if there should be any restriction for password reuse.
  /// </summary>
  public PasswordRestrictionModes RestrictionMode { get; set; }

  /// <summary>
  /// Specifies the time in minutes in which the password cannot be reused.
  /// </summary>
  public int RestrictionPeriod { get; set; }

  /// <summary>
  /// Specifies the number of previous passwords which cannot be reused.
  /// </summary>
  public int RestrictionCount { get; set; }
}


