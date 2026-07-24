namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Authenticator Options Request: Used to partially update the authentication provider configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorOptionsRequest>))]
public class PatchAuthenticatorOptionsRequest
{
  /// <summary>
  /// Determines whether external authentication providers are prioritized over other authenticators during sign-in.
  /// </summary>
  public Optional<bool> ExternalSignInMethodsFirst { get; set; }

  /// <summary>
  /// Password authenticator configuration.
  /// </summary>
  public Optional<PatchPasswordAuthenticatorOptionsRequest> Password { get; set; }

  /// <summary>
  /// Passkey authenticator configuration.
  /// </summary>
  public Optional<PatchPasskeyAuthenticatorOptionsRequest> Passkey { get; set; }

  /// <summary>
  /// Email authenticator configuration.
  /// </summary>
  public Optional<PatchEmailAuthenticatorOptionsRequest> Email { get; set; }

  /// <summary>
  /// Phone authenticator configuration.
  /// </summary>
  public Optional<PatchPhoneAuthenticatorOptionsRequest> Phone { get; set; }
}


