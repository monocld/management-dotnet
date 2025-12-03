namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Password Authenticator Strength Options response class
/// </summary>
public class AuthenticatorsPasswordStrengthOptions
{
  /// <summary>
  /// Specifies the minimum character length of password
  /// </summary>
  public int MinimumLength { get; set; }

  /// <summary>
  /// Specifies the whether a non alphanumeric character is required in the password.
  /// </summary>
  public bool RequireNonAlphanumericCharacter { get; set; }

  /// <summary>
  /// Specifies the whether a digit is required in the password.
  /// </summary>
  public bool RequireDigit { get; set; }

  /// <summary>
  /// Specifies the whether a lowercase character is required in the password.
  /// </summary>
  public bool RequireLowercaseCharacter { get; set; }

  /// <summary>
  /// Specifies the whether a uppercase character is required in the password.
  /// </summary>
  public bool RequireUppercaseCharacter { get; set; }

  /// <summary>
  /// Specifies the number of unique characters required in the password.
  /// </summary>
  public int RequiredUniqueCharactersCount { get; set; }
}


