namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Email Authenticator Options response class
/// </summary>
public class AuthenticatorsEmailOptions
{
  /// <summary>
  /// Enable Email Sign-in
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Enable Email Sign-up
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Enable Email Jit Provisioning
  /// </summary>
  public bool EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the type of verification tokens to be sent
  /// </summary>
  public VerificationTypes VerificationType { get; set; }

  /// <summary>
  /// Allow sign up/sign in flow to resume in a different browser
  /// </summary>
  public bool AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the expiration period of the email (in seconds)
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public int CodeLength { get; set; }
}


