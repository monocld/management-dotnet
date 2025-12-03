namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Phone Identifier Verification Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersPhoneVerificationOptionsRequest>))]
public class PatchIdentifiersPhoneVerificationOptionsRequest
{
  /// <summary>
  /// Specifies whether the phone should be verified at registration.
  /// </summary>
  public Optional<bool> VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public Optional<int> CodeLength { get; set; }
}


