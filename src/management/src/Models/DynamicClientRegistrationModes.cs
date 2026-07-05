namespace MonoCloud.Management.Models;

/// <summary>
/// Controls how the dynamic client registration endpoint accepts requests.
/// </summary>
public enum DynamicClientRegistrationModes
{
  /// <summary>
  /// Dynamic client registration is turned off. The registration endpoint is not exposed.
  /// </summary>
  Disabled,

  /// <summary>
  /// Anyone can register a client without presenting credentials (anonymous registration).
  /// </summary>
  Open,

  /// <summary>
  /// Registration requires a bearer initial access token with the configured scope.
  /// </summary>
  InitialAccessToken
}


