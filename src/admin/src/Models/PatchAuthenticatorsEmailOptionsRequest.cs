namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Email Authenticator Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsEmailOptionsRequest>))]
public class PatchAuthenticatorsEmailOptionsRequest
{
  /// <summary>
  /// Enable Email Sign-in
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Enable Email Sign-up
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Enable Email Jit Provisioning
  /// </summary>
  public Optional<bool> EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the type of verification tokens to be sent
  /// </summary>
  public Optional<VerificationTypes> VerificationType { get; set; }

  /// <summary>
  /// Allow sign up/sign in flow to resume in a different browser
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


