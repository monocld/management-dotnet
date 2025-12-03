namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Create Api Resource Client Request
/// </summary>
public class CreateApiResourceClientRequest
{
  /// <summary>
  /// Specifies the api scopes the client is allowed to access (by default the client has access to all the resource scopes)
  /// </summary>
  public List<string> RestrictedScopes { get; set; }
}


