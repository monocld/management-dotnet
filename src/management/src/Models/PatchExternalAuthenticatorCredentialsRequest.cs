namespace MonoCloud.Management.Models;

/// <summary>
/// Patch External Authenticator Credentials Request: Used to update client credentials used by an external authenticator.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchExternalAuthenticatorCredentialsRequest>))]
public class PatchExternalAuthenticatorCredentialsRequest
{
  /// <summary>
  /// The client identifier issued by the external identity provider.
  /// </summary>
  public Optional<string> ClientId { get; set; }

  /// <summary>
  /// The client secret issued by the external identity provider.
  /// </summary>
  public Optional<string> ClientSecret { get; set; }

  /// <summary>
  /// The Apple Developer Team ID used to sign the client secret. Applies only to the Sign in with Apple provider.
  /// </summary>
  public Optional<string?> AppleTeamId { get; set; }

  /// <summary>
  /// The Apple Key ID used to sign the client secret. Applies only to the Sign in with Apple provider.
  /// </summary>
  public Optional<string?> AppleKeyId { get; set; }
}


