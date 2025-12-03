namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Passkey Authenticator Options response class
/// </summary>
public class AuthenticatorsPasskeyOptions
{
  /// <summary>
  /// Enable Passkey Sign-in
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Enable Passkey Sign-up
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Prompt the user for adding a passkey if the user does not have one
  /// </summary>
  public bool PromptEnrollment { get; set; }

  /// <summary>
  /// Prompt the user for adding a passkey if the user does not have a passkey for the device
  /// </summary>
  public bool PromptDeviceEnrollment { get; set; }

  /// <summary>
  /// Allow users to autofill passkeys using the identifier field on the sign-in page
  /// </summary>
  public bool EnableAutoComplete { get; set; }

  /// <summary>
  /// Specifies whether the sign-in with passkey button will be shown on the sign-in page
  /// </summary>
  public bool ShowPasskeyButton { get; set; }
}


