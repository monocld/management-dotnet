namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Api Scope Resource response class
/// </summary>
public class ApiScope
{
  /// <summary>
  /// Unique ID of the Resource
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Display Name for the Resource
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// A brief description about the Resource
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Specifies the creation time of the resource (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the resource (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The unique name of the scope. This is the value a client will use for the scope parameter in the authorize request.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies whether the user can de-select the scope on the consent screen.
  /// </summary>
  public bool Required { get; set; }

  /// <summary>
  /// Specifies whether the consent screen will emphasize this scope. Use this setting for sensitive or important scopes.
  /// </summary>
  public bool Emphasize { get; set; }

  /// <summary>
  /// Specifies whether the scopes will automatically added to the token when the scope parameter is empty.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// List of associated user claim types that should be included in the Access Token.
  /// </summary>
  public List<string> UserClaims { get; set; }

  /// <summary>
  /// Specifies whether this resource is shown in the discovery document.
  /// </summary>
  public bool ShowInDiscoveryDocument { get; set; }
}


