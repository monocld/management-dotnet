namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Specifies the purpose / use of the key
/// </summary>
public enum KeyMaterialUses
{
  /// <summary>
  /// The key can be used for signing new tokens.
  /// </summary>
  Signing,

  /// <summary>
  /// The key can be used for validating the tokens.
  /// </summary>
  Validation
}


