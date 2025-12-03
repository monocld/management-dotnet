namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Phone Recovery Method Options response class
/// </summary>
public class RecoveryMethodsPhoneOptions
{
  /// <summary>
  /// Enable Password recovery through Phone.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Specifies the expiration period of the code (in seconds)
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the length of the code
  /// </summary>
  public int CodeLength { get; set; }
}


