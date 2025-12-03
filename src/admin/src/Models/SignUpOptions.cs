namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The SignUp Options response class
/// </summary>
public class SignUpOptions
{
  /// <summary>
  /// Registration Custom Fields Options
  /// </summary>
  public List<SignUpCustomFieldOptions> CustomFields { get; set; }

  /// <summary>
  /// Shows T&amp;C and/or Privacy Policy Agreement on the Sign Up screen.  Make sure to add T&amp;C and/or Privacy Policy links in the Project Settings.  T&amp;C and/or Privacy Policy Agreement is not shown when user is created through External Identity Providers
  /// </summary>
  public bool ShowTermsAndPrivacyPolicy { get; set; }

  /// <summary>
  /// Requires user interaction to agree with T&amp;C and/or Privacy Policy
  /// </summary>
  public bool RequireExplicitUserAgreement { get; set; }

  /// <summary>
  /// Privacy Url
  /// </summary>
  public string? PrivacyUrl { get; set; }

  /// <summary>
  /// Terms Url
  /// </summary>
  public string? TermsUrl { get; set; }

  /// <summary>
  /// The whitelist Restriction Options.
  /// </summary>
  public SignUpGenericRestrictionsOptions Whitelist { get; set; }

  /// <summary>
  /// The blacklist Restriction Options.
  /// </summary>
  public SignUpGenericRestrictionsOptions Blacklist { get; set; }
}


