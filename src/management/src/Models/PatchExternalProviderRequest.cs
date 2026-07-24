namespace MonoCloud.Management.Models;

/// <summary>
/// Patch External Provider Request: Used to update an external authenticator&#39;s configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchExternalProviderRequest>))]
public class PatchExternalProviderRequest
{
  /// <summary>
  /// A custom display name for the provider&#39;s sign-in button.
  /// </summary>
  public Optional<string?> DisplayName { get; set; }

  /// <summary>
  /// A custom icon URL for the provider&#39;s sign-in button.
  /// </summary>
  public Optional<string?> Icon { get; set; }

  /// <summary>
  /// Specifies whether users can sign in using this external identity provider.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using this external identity provider.
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether the provider&#39;s sign-in button is shown on the login page.
  /// </summary>
  public Optional<bool> ShowOnLoginPage { get; set; }

  /// <summary>
  /// The client credentials issued by the external identity provider. When not set, MonoCloud-managed credentials are used.
  /// </summary>
  public Optional<PatchExternalProviderCredentialsRequest?> Credentials { get; set; }

  /// <summary>
  /// The protocol connection settings used to communicate with the external identity provider.
  /// </summary>
  public Optional<PatchExternalProviderConnectionRequest?> Connection { get; set; }

  /// <summary>
  /// The set of scopes requested from the external identity provider during authentication.
  /// </summary>
  public Optional<List<string>> Scopes { get; set; }

  /// <summary>
  /// A map of claim names to upstream source claim names used to map the upstream profile onto the MonoCloud user.
  /// </summary>
  public Optional<Dictionary<string, string>> ClaimMappings { get; set; }

  /// <summary>
  /// A map of parameter names to the values sent to the external provider&#39;s authorization endpoint. A value prefixed with &#x60;$&#x60; forwards the incoming authorization request query parameter with that name; any other value is sent as-is.
  /// </summary>
  public Optional<Dictionary<string, string>> AuthorizationParameters { get; set; }

  /// <summary>
  /// The email domains routed to this provider through home realm discovery.
  /// </summary>
  public Optional<List<string>> HomeRealmDomains { get; set; }

  /// <summary>
  /// Determines whether the email received from the external provider is treated as verified.
  /// </summary>
  public Optional<TrustIdentifierModes> TrustEmail { get; set; }

  /// <summary>
  /// Determines whether the phone number received from the external provider is treated as verified.
  /// </summary>
  public Optional<TrustIdentifierModes> TrustPhone { get; set; }

  /// <summary>
  /// Specifies whether the user profile should be synchronized from the external provider on each successful sign-in.
  /// </summary>
  public Optional<bool> SyncUserProfileAlways { get; set; }

  /// <summary>
  /// Specifies whether the IdP claims should be synchronized from the external provider on each successful sign-in.
  /// </summary>
  public Optional<bool> SyncIdpClaimsAlways { get; set; }

  /// <summary>
  /// The priority of the external provider. Used to order the provider relative to others.
  /// </summary>
  public Optional<int> Priority { get; set; }
}


