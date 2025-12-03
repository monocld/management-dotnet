namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Phone Recovery Method Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRecoveryMethodsPhoneOptionsRequest>))]
public class PatchRecoveryMethodsPhoneOptionsRequest
{
  /// <summary>
  /// Enable Password recovery through Phone.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public Optional<int> CodeLength { get; set; }
}


