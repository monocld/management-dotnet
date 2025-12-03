namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Email Identifier Verification Options response class
/// </summary>
public class IdentifiersEmailVerificationOptions
{
  /// <summary>
  /// Specifies whether the email should be verified at registration.
  /// </summary>
  public bool VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the type of verification tokens to be sent
  /// </summary>
  public VerificationTypes VerificationType { get; set; }

  /// <summary>
  /// Allow sign up/sign in flow to resume in a different browser
  /// </summary>
  public bool AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public int CodeLength { get; set; }
}


