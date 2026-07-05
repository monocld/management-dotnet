namespace MonoCloud.Management.Models;

/// <summary>
/// Dynamic Client Registration Options Response: Represents the current dynamic client registration configuration for the tenant.
/// </summary>
public class DynamicClientRegistrationOptions
{
  /// <summary>
  /// The dynamic client registration mode for the tenant.
  /// </summary>
  public DynamicClientRegistrationModes Mode { get; set; }

  /// <summary>
  /// The scope an initial access token must carry to register a client when the mode requires authorization.
  /// </summary>
  public string InitialAccessTokenScope { get; set; }

  /// <summary>
  /// The maximum number of dynamically registered clients allowed for the tenant.
  /// </summary>
  public int MaxDynamicClients { get; set; }

  /// <summary>
  /// The maximum number of redirect uris a registration may include.
  /// </summary>
  public int MaxRedirectUris { get; set; }

  /// <summary>
  /// The maximum number of post logout redirect uris a registration may include.
  /// </summary>
  public int MaxPostLogoutRedirectUris { get; set; }
}


