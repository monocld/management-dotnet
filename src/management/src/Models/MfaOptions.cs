namespace MonoCloud.Management.Models;

/// <summary>
/// MFA Options Response: Represents the tenant&#39;s multi-factor authentication configuration.
/// </summary>
public class MfaOptions
{
  /// <summary>
  /// Indicates whether multi-factor authentication is enabled for the tenant. When enabled, users who have enrolled a factor are challenged during sign-in.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Indicates whether multi-factor authentication is required for all users. When required, users without a factor are forced to enroll one during sign-in.
  /// </summary>
  public bool Required { get; set; }

  /// <summary>
  /// Indicates whether authenticator apps (TOTP) can be used as a second factor.
  /// </summary>
  public bool TotpEnabled { get; set; }

  /// <summary>
  /// The issuer name shown in authenticator apps. When not set, the project name is used.
  /// </summary>
  public string? TotpIssuer { get; set; }

  /// <summary>
  /// Indicates whether passkeys / security keys can be enrolled as a second factor.
  /// </summary>
  public bool PasskeyEnabled { get; set; }

  /// <summary>
  /// Indicates whether one-time recovery codes are issued when a user enrolls their first factor.
  /// </summary>
  public bool RecoveryCodesEnabled { get; set; }

  /// <summary>
  /// Indicates whether users can mark a browser as trusted to skip the multi-factor challenge for a period of time.
  /// </summary>
  public bool RememberBrowserEnabled { get; set; }

  /// <summary>
  /// The number of days a trusted browser skips the multi-factor challenge.
  /// </summary>
  public int RememberBrowserDurationDays { get; set; }
}


