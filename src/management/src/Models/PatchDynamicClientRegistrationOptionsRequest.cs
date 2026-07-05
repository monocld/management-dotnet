namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Dynamic Client Registration Options Request: Used to update the dynamic client registration configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchDynamicClientRegistrationOptionsRequest>))]
public class PatchDynamicClientRegistrationOptionsRequest
{
  /// <summary>
  /// The dynamic client registration mode for the tenant.
  /// </summary>
  public Optional<DynamicClientRegistrationModes> Mode { get; set; }

  /// <summary>
  /// The scope an initial access token must carry to register a client when the mode requires authorization.
  /// </summary>
  public Optional<string> InitialAccessTokenScope { get; set; }

  /// <summary>
  /// The maximum number of dynamically registered clients allowed for the tenant.
  /// </summary>
  public Optional<int> MaxDynamicClients { get; set; }

  /// <summary>
  /// The maximum number of redirect uris a registration may include.
  /// </summary>
  public Optional<int> MaxRedirectUris { get; set; }

  /// <summary>
  /// The maximum number of post logout redirect uris a registration may include.
  /// </summary>
  public Optional<int> MaxPostLogoutRedirectUris { get; set; }
}


