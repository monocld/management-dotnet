namespace MonoCloud.Management.Models;

/// <summary>
/// External Provider Summary: Represents a linked identity provider account for the user.
/// </summary>
public class UserExternalProviderSummary
{
  /// <summary>
  /// The provider associated with this connection.
  /// </summary>
  public string Provider { get; set; }

  /// <summary>
  /// The authenticator used by the provider.
  /// </summary>
  public ExternalAuthenticators Authenticator { get; set; }

  /// <summary>
  /// The user identifier assigned by the identity provider.
  /// </summary>
  public string ProviderUserId { get; set; }
}


