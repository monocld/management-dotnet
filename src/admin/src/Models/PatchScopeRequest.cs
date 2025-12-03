namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Scope Resource class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchScopeRequest>))]
public class PatchScopeRequest
{
  /// <summary>
  /// Display Name for the Resource
  /// </summary>
  public Optional<string?> DisplayName { get; set; }

  /// <summary>
  /// A brief description about the Resource
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Specifies whether this resource is shown in the discovery document.
  /// </summary>
  public Optional<bool> ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The unique name of the scope. This is the value a client will use for the scope parameter in the authorize request.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Specifies whether the user can de-select the scope on the consent screen.
  /// </summary>
  public Optional<bool> Required { get; set; }

  /// <summary>
  /// Specifies whether the consent screen will emphasize this scope. Use this setting for sensitive or important scopes.
  /// </summary>
  public Optional<bool> Emphasize { get; set; }

  /// <summary>
  /// List of associated user claim types that should be included in the Identity token or as returned from the User Info Endpoint.
  /// </summary>
  public Optional<List<CreateScopeClaimRequest>> UserClaims { get; set; }
}


