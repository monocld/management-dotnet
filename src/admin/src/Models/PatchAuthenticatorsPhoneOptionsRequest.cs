namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Phone Authenticator Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsPhoneOptionsRequest>))]
public class PatchAuthenticatorsPhoneOptionsRequest
{
  /// <summary>
  /// Enable Phone Sign-in
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Enable Phone Sign-up
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Enable Phone Jit Provisioning
  /// </summary>
  public Optional<bool> EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public Optional<int> CodeLength { get; set; }
}


