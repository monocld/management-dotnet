namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Xero Authenticator Options response class
/// </summary>
public class AuthenticatorsXeroOptions
{
  /// <summary>
  /// Enable External Provider Sign-in
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Enable External Provider Sign-up
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// If set to true, will use the internal keys for authentication
  /// </summary>
  public bool UseInternalKeys { get; set; }

  /// <summary>
  /// If set to true, will sync the profile with each login
  /// </summary>
  public bool SyncUserProfileAlways { get; set; }

  /// <summary>
  /// Client Id issued for the customer by provider
  /// </summary>
  public string? ClientId { get; set; }

  /// <summary>
  /// Client Secret issued for the customer by provider
  /// </summary>
  public string? ClientSecret { get; set; }

  /// <summary>
  /// List of provider scopes to be obtained
  /// </summary>
  public List<string> Scopes { get; set; }

  /// <summary>
  /// Specifies if we should treat the email received from the external provider as verified.
  /// </summary>
  public bool TreatEmailAsVerified { get; set; }
}


