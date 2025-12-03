namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Authenticators Options response class
/// </summary>
public class AuthenticatorsOptions
{
  /// <summary>
  /// If enabled, External SigIn Methods are shown on top and the Primary SigIn method is shown on bottom.
  /// </summary>
  public bool ExternalSignInMethodsFirst { get; set; }

  /// <summary>
  /// Order of the External SigIn methods buttons
  /// </summary>
  public List<ExternalAuthenticators> ExternalSignInMethodsOrder { get; set; }

  /// <summary>
  /// Password Authenticator Settings
  /// </summary>
  public AuthenticatorsPasswordOptions Password { get; set; }

  /// <summary>
  /// Passkey Authenticator Settings
  /// </summary>
  public AuthenticatorsPasskeyOptions Passkey { get; set; }

  /// <summary>
  /// Email Authenticator Settings
  /// </summary>
  public AuthenticatorsEmailOptions Email { get; set; }

  /// <summary>
  /// Phone Authenticator Settings
  /// </summary>
  public AuthenticatorsPhoneOptions Phone { get; set; }

  /// <summary>
  /// Google Authenticator Settings
  /// </summary>
  public AuthenticatorsGoogleOptions? Google { get; set; }

  /// <summary>
  /// Apple Authenticator Settings
  /// </summary>
  public AuthenticatorsAppleOptions? Apple { get; set; }

  /// <summary>
  /// Facebook Authenticator Settings
  /// </summary>
  public AuthenticatorsFacebookOptions? Facebook { get; set; }

  /// <summary>
  /// Microsoft Authenticator Settings
  /// </summary>
  public AuthenticatorsMicrosoftOptions? Microsoft { get; set; }

  /// <summary>
  /// GitHub Authenticator Settings
  /// </summary>
  public AuthenticatorsGitHubOptions? Github { get; set; }

  /// <summary>
  /// GitLab Authenticator Settings
  /// </summary>
  public AuthenticatorsGitLabOptions? Gitlab { get; set; }

  /// <summary>
  /// Discord Authenticator Settings
  /// </summary>
  public AuthenticatorsDiscordOptions? Discord { get; set; }

  /// <summary>
  /// Twitter Authenticator Settings
  /// </summary>
  public AuthenticatorsTwitterOptions? Twitter { get; set; }

  /// <summary>
  /// LinkedIn Authenticator Settings
  /// </summary>
  public AuthenticatorsLinkedInOptions? Linkedin { get; set; }

  /// <summary>
  /// Xero Authenticator Settings
  /// </summary>
  public AuthenticatorsXeroOptions? Xero { get; set; }
}


