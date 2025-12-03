namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Recovery Methods Options response class
/// </summary>
public class RecoveryMethodsOptions
{
  /// <summary>
  /// Recovery Methods Email Options
  /// </summary>
  public RecoveryMethodsEmailOptions Email { get; set; }

  /// <summary>
  /// Recovery Methods Phone Options
  /// </summary>
  public RecoveryMethodsPhoneOptions Phone { get; set; }
}


