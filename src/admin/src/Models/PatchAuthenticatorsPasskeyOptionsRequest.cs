namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Passkey Authenticator Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsPasskeyOptionsRequest>))]
public class PatchAuthenticatorsPasskeyOptionsRequest
{
  /// <summary>
  /// Enable Passkey Sign-in
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Enable Passkey Sign-up
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Prompt the user for adding a passkey if the user does not have one
  /// </summary>
  public Optional<bool> PromptEnrollment { get; set; }

  /// <summary>
  /// Prompt the user for adding a passkey if the user does not have a passkey for the device
  /// </summary>
  public Optional<bool> PromptDeviceEnrollment { get; set; }

  /// <summary>
  /// Allow users to autofill passkeys using the identifier field on the sign-in page
  /// </summary>
  public Optional<bool> EnableAutoComplete { get; set; }

  /// <summary>
  /// Specifies whether the sign-in with passkey button will be shown on the sign-in page
  /// </summary>
  public Optional<bool> ShowPasskeyButton { get; set; }
}


