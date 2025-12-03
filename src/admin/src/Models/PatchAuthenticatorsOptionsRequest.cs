namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Authenticators Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsOptionsRequest>))]
public class PatchAuthenticatorsOptionsRequest
{
  /// <summary>
  /// If enabled, External SigIn Methods are shown on top and the Primary SigIn method is shown on bottom.
  /// </summary>
  public Optional<bool> ExternalSignInMethodsFirst { get; set; }

  /// <summary>
  /// Order of the External SigIn methods buttons
  /// </summary>
  public Optional<List<ExternalAuthenticators>> ExternalSignInMethodsOrder { get; set; }

  /// <summary>
  /// Password Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsPasswordOptionsRequest> Password { get; set; }

  /// <summary>
  /// Passkey Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsPasskeyOptionsRequest> Passkey { get; set; }

  /// <summary>
  /// Email Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsEmailOptionsRequest> Email { get; set; }

  /// <summary>
  /// Phone Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsPhoneOptionsRequest> Phone { get; set; }

  /// <summary>
  /// Google Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsGoogleOptionsRequest?> Google { get; set; }

  /// <summary>
  /// Apple Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsAppleOptionsRequest?> Apple { get; set; }

  /// <summary>
  /// Facebook Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsFacebookOptionsRequest?> Facebook { get; set; }

  /// <summary>
  /// Microsoft Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsMicrosoftOptionsRequest?> Microsoft { get; set; }

  /// <summary>
  /// GitHub Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsGitHubOptionsRequest?> Github { get; set; }

  /// <summary>
  /// GitLab Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsGitLabOptionsRequest?> Gitlab { get; set; }

  /// <summary>
  /// Discord Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsDiscordOptionsRequest?> Discord { get; set; }

  /// <summary>
  /// Twitter Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsTwitterOptionsRequest?> Twitter { get; set; }

  /// <summary>
  /// LinkedIn Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsLinkedInOptionsRequest?> Linkedin { get; set; }

  /// <summary>
  /// Xero Authenticator Settings
  /// </summary>
  public Optional<PatchAuthenticatorsXeroOptionsRequest?> Xero { get; set; }
}


