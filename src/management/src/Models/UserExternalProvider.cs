namespace MonoCloud.Management.Models;

/// <summary>
/// External Provider: Represents a linked identity provider account for the user.
/// </summary>
public class UserExternalProvider
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

  /// <summary>
  /// Claims received from the identity provider and associated with this connection.
  /// </summary>
  public Dictionary<string, object> Claims { get; set; }
}


