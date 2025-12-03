namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch GitLab Authenticator Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsGitLabOptionsRequest>))]
public class PatchAuthenticatorsGitLabOptionsRequest
{
  /// <summary>
  /// Enable External Provider Sign-in
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Enable External Provider Sign-up
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// If set to true, will use the internal keys for authentication
  /// </summary>
  public Optional<bool> UseInternalKeys { get; set; }

  /// <summary>
  /// If set to true, will sync the profile with each login
  /// </summary>
  public Optional<bool> SyncUserProfileAlways { get; set; }

  /// <summary>
  /// Client Id issued for the customer by provider
  /// </summary>
  public Optional<string?> ClientId { get; set; }

  /// <summary>
  /// Client Secret issued for the customer by provider
  /// </summary>
  public Optional<string?> ClientSecret { get; set; }

  /// <summary>
  /// List of provider scopes to be obtained
  /// </summary>
  public Optional<List<string>> Scopes { get; set; }

  /// <summary>
  /// Specifies if we should trust the email verified scope received from the external provider.
  /// </summary>
  public Optional<bool> TrustEmailVerifiedScope { get; set; }
}


