namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Api Resource Client response
/// </summary>
public class ApiResourceClient
{
  /// <summary>
  /// The resource Id
  /// </summary>
  public string ResourceId { get; set; }

  /// <summary>
  /// The client ID
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// Specifies the api scopes the client is allowed to access (by default the client has access to all the resource scopes)
  /// </summary>
  public List<string> RestrictedScopes { get; set; }

  /// <summary>
  /// Specifies the creation time of the client group (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the creation time of the client group (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


