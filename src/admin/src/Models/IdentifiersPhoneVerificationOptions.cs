namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Phone Identifier Verification Options response class
/// </summary>
public class IdentifiersPhoneVerificationOptions
{
  /// <summary>
  /// Specifies whether the phone should be verified at registration.
  /// </summary>
  public bool VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public int CodeLength { get; set; }
}


