namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Email Identifier Verification Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersEmailVerificationOptionsRequest>))]
public class PatchIdentifiersEmailVerificationOptionsRequest
{
  /// <summary>
  /// Specifies whether the email should be verified at registration.
  /// </summary>
  public Optional<bool> VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the type of verification tokens to be sent
  /// </summary>
  public Optional<VerificationTypes> VerificationType { get; set; }

  /// <summary>
  /// Allow sign up/sign in flow to resume in a different browser
  /// </summary>
  public Optional<bool> AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public Optional<int> CodeLength { get; set; }
}


