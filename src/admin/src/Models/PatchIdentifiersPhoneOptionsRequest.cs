namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Phone Identifier Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersPhoneOptionsRequest>))]
public class PatchIdentifiersPhoneOptionsRequest
{
  /// <summary>
  /// Specifies if the users are allowed to sign-in using a phone number
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies if the users are allowed to enter a phone number at the time of registration.
  /// </summary>
  public Optional<bool> ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies if the phone number is required at the time of registration.
  /// </summary>
  public Optional<bool> RequiredAtSignUp { get; set; }

  /// <summary>
  /// Phone verification related to Sign Up
  /// </summary>
  public Optional<PatchIdentifiersPhoneVerificationOptionsRequest> Verification { get; set; }
}


