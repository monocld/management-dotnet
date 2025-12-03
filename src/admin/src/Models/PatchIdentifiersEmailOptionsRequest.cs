namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Email Identifier Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersEmailOptionsRequest>))]
public class PatchIdentifiersEmailOptionsRequest
{
  /// <summary>
  /// Specifies if the users are allowed to sign-in using an email
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies if the users are allowed to enter an email at the time of registration.
  /// </summary>
  public Optional<bool> ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies if the email is required at the time of registration.
  /// </summary>
  public Optional<bool> RequiredAtSignUp { get; set; }

  /// <summary>
  /// Email verification related to Sign Up
  /// </summary>
  public Optional<PatchIdentifiersEmailVerificationOptionsRequest> Verification { get; set; }
}


