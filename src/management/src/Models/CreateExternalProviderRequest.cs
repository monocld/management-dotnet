namespace MonoCloud.Management.Models;

/// <summary>
/// Create External Provider Request: Used to create an external authenticator.
/// </summary>
public class CreateExternalProviderRequest
{
  /// <summary>
  /// The unique logical name of the connection. Identifies the connection and addresses it through the API.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The external identity provider of the connection.
  /// </summary>
  public ExternalAuthenticators? Authenticator { get; set; }

  /// <summary>
  /// A custom display name for the provider&#39;s sign-in button. When not set, the provider&#39;s default display name is used.
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// A custom icon URL for the provider&#39;s sign-in button. When not set, the provider&#39;s default icon is used.
  /// </summary>
  public string? Icon { get; set; }

  /// <summary>
  /// Specifies whether users can sign in using this external identity provider.
  /// </summary>
  public bool? EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using this external identity provider.
  /// </summary>
  public bool? EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether the provider&#39;s sign-in button is shown on the login page.
  /// </summary>
  public bool? ShowOnLoginPage { get; set; }

  /// <summary>
  /// The client credentials issued by the external identity provider. When not set, MonoCloud-managed credentials are used.
  /// </summary>
  public CreateExternalProviderCredentialsRequest? Credentials { get; set; }

  /// <summary>
  /// The protocol connection settings used to communicate with the external identity provider. Applies only to custom and enterprise connections.
  /// </summary>
  public CreateExternalProviderConnectionRequest? Connection { get; set; }

  /// <summary>
  /// The set of scopes requested from the external identity provider during authentication.
  /// </summary>
  public List<string> Scopes { get; set; }

  /// <summary>
  /// A map of claim names to upstream source claim names used to map the upstream profile onto the MonoCloud user.
  /// </summary>
  public Dictionary<string, string> ClaimMappings { get; set; }

  /// <summary>
  /// A map of parameter names to the values sent to the external provider&#39;s authorization endpoint. A value prefixed with &#x60;$&#x60; forwards the incoming authorization request query parameter with that name; any other value is sent as-is.
  /// </summary>
  public Dictionary<string, string> AuthorizationParameters { get; set; }

  /// <summary>
  /// Determines whether the email received from the external provider is treated as verified.
  /// </summary>
  public TrustIdentifierModes? TrustEmail { get; set; }

  /// <summary>
  /// Determines whether the phone number received from the external provider is treated as verified.
  /// </summary>
  public TrustIdentifierModes? TrustPhone { get; set; }

  /// <summary>
  /// Specifies whether the user profile should be synchronized from the external provider on each successful sign-in.
  /// </summary>
  public bool? SyncUserProfileAlways { get; set; }

  /// <summary>
  /// Specifies whether the IdP claims should be synchronized from the external provider on each successful sign-in.
  /// </summary>
  public bool? SyncIdpClaimsAlways { get; set; }

  /// <summary>
  /// The email domains routed to this provider through home realm discovery.
  /// </summary>
  public List<string> HomeRealmDomains { get; set; }

  /// <summary>
  /// The priority of the external provider. Used to order the provider relative to others.
  /// </summary>
  public int? Priority { get; set; }
}


