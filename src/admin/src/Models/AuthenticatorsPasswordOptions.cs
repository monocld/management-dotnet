namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Password Authenticator Options response class
/// </summary>
public class AuthenticatorsPasswordOptions
{
  /// <summary>
  /// Enable Password Sign-in
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Enable Password Sign-up
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// If enabled password will be prompted on the same screen as the username.
  /// </summary>
  public bool PromptPasswordOnInitialScreen { get; set; }

  /// <summary>
  /// Specifies the expiration period of the password (in days)
  /// </summary>
  public int? Expiry { get; set; }

  /// <summary>
  /// Password Strength Options
  /// </summary>
  public AuthenticatorsPasswordStrengthOptions Strength { get; set; }

  /// <summary>
  /// Password Re-use Options
  /// </summary>
  public AuthenticatorsPasswordReuseOptions Reuse { get; set; }
}


