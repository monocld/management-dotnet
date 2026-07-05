namespace MonoCloud.Management.Models;

/// <summary>
/// Create External Authenticator Credentials Request: The client credentials issued by the external identity provider.
/// </summary>
public class CreateExternalAuthenticatorCredentialsRequest
{
  /// <summary>
  /// The client identifier issued by the external identity provider.
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// The client secret issued by the external identity provider.
  /// </summary>
  public string ClientSecret { get; set; }

  /// <summary>
  /// The Apple Developer Team ID used to sign the client secret. Applies only to the Sign in with Apple provider.
  /// </summary>
  public string? AppleTeamId { get; set; }

  /// <summary>
  /// The Apple Key ID used to sign the client secret. Applies only to the Sign in with Apple provider.
  /// </summary>
  public string? AppleKeyId { get; set; }
}


