namespace MonoCloud.Management.Models;

/// <summary>
/// Authenticator Options Response: Defines how users can authenticate, including password, passkeys, and external identity providers.
/// </summary>
public class AuthenticatorOptions
{
  /// <summary>
  /// Determines whether external authentication providers are prioritized over other authenticators during sign-in.
  /// </summary>
  public bool ExternalSignInMethodsFirst { get; set; }

  /// <summary>
  /// Password authenticator configuration.
  /// </summary>
  public PasswordAuthenticatorOptions Password { get; set; }

  /// <summary>
  /// Passkey authenticator configuration.
  /// </summary>
  public PasskeyAuthenticatorOptions Passkey { get; set; }

  /// <summary>
  /// Email authenticator configuration.
  /// </summary>
  public EmailAuthenticatorOptions Email { get; set; }

  /// <summary>
  /// Phone authenticator configuration.
  /// </summary>
  public PhoneAuthenticatorOptions Phone { get; set; }
}


