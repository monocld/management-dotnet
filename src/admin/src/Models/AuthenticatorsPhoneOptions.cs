namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Phone Authenticator Options response class
/// </summary>
public class AuthenticatorsPhoneOptions
{
  /// <summary>
  /// Enable Phone Sign-in
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Enable Phone Sign-up
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Enable Phone Jit Provisioning
  /// </summary>
  public bool EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public int CodeLength { get; set; }
}


