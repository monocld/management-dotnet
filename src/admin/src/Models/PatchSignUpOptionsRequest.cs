namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch SignUp Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSignUpOptionsRequest>))]
public class PatchSignUpOptionsRequest
{
  /// <summary>
  /// Shows T&amp;C and/or Privacy Policy Agreement on the Sign Up screen.  Make sure to add T&amp;C and/or Privacy Policy links in the Project Settings.  T&amp;C and/or Privacy Policy Agreement is not shown when user is created through External Identity Providers
  /// </summary>
  public Optional<bool> ShowTermsAndPrivacyPolicy { get; set; }

  /// <summary>
  /// Requires user interaction to agree with T&amp;C and/or Privacy Policy
  /// </summary>
  public Optional<bool> RequireExplicitUserAgreement { get; set; }

  /// <summary>
  /// Privacy Url
  /// </summary>
  public Optional<string?> PrivacyUrl { get; set; }

  /// <summary>
  /// Terms Url
  /// </summary>
  public Optional<string?> TermsUrl { get; set; }

  /// <summary>
  /// The whitelist Restriction Options.
  /// </summary>
  public Optional<PatchSignUpRestrictionsOptionsRequest> Whitelist { get; set; }

  /// <summary>
  /// The blacklist Restriction Options.
  /// </summary>
  public Optional<PatchSignUpRestrictionsOptionsRequest> Blacklist { get; set; }
}


