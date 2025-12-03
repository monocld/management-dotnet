namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Phone Identifier Options response class
/// </summary>
public class IdentifiersPhoneOptions
{
  /// <summary>
  /// Specifies if the users are allowed to sign-in using a phone number
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies if the users are allowed to enter a phone number at the time of registration.
  /// </summary>
  public bool ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies if the phone number is required at the time of registration.
  /// </summary>
  public bool RequiredAtSignUp { get; set; }

  /// <summary>
  /// Phone verification related to Sign Up
  /// </summary>
  public IdentifiersPhoneVerificationOptions Verification { get; set; }
}


