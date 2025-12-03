namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Email Recovery Method Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRecoveryMethodsEmailOptionsRequest>))]
public class PatchRecoveryMethodsEmailOptionsRequest
{
  /// <summary>
  /// Enable Password recovery through Email.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Verification type that should be used for email password reset
  /// </summary>
  public Optional<VerificationTypes> VerificationType { get; set; }

  /// <summary>
  /// Allow password reset flow to resume in a different browser
  /// </summary>
  public Optional<bool> AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the expiration period of the email (in seconds)
  /// </summary>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public Optional<int> CodeLength { get; set; }
}


