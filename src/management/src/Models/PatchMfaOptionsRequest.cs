namespace MonoCloud.Management.Models;

/// <summary>
/// Patch MFA Options Request: Used to update the tenant&#39;s multi-factor authentication configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchMfaOptionsRequest>))]
public class PatchMfaOptionsRequest
{
  /// <summary>
  /// Indicates whether multi-factor authentication is enabled for the tenant. &lt;note&gt;Pro plan required to enable.&lt;/note&gt;
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Indicates whether multi-factor authentication is required for all users. &lt;note&gt;Pro plan required to enable.&lt;/note&gt;
  /// </summary>
  public Optional<bool> Required { get; set; }

  /// <summary>
  /// Indicates whether authenticator apps (TOTP) can be used as a second factor.
  /// </summary>
  public Optional<bool> TotpEnabled { get; set; }

  /// <summary>
  /// The issuer name shown in authenticator apps. When not set, the project name is used.
  /// </summary>
  public Optional<string?> TotpIssuer { get; set; }

  /// <summary>
  /// Indicates whether passkeys / security keys can be enrolled as a second factor.
  /// </summary>
  public Optional<bool> PasskeyEnabled { get; set; }

  /// <summary>
  /// Indicates whether one-time recovery codes are issued when a user enrolls their first factor.
  /// </summary>
  public Optional<bool> RecoveryCodesEnabled { get; set; }

  /// <summary>
  /// Indicates whether users can mark a browser as trusted to skip the multi-factor challenge for a period of time.
  /// </summary>
  public Optional<bool> RememberBrowserEnabled { get; set; }

  /// <summary>
  /// The number of days a trusted browser skips the multi-factor challenge.
  /// </summary>
  public Optional<int> RememberBrowserDurationDays { get; set; }
}


