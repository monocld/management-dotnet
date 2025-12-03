namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Password Authenticator Strength Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsPasswordStrengthOptionsRequest>))]
public class PatchAuthenticatorsPasswordStrengthOptionsRequest
{
  /// <summary>
  /// Specifies the minimum character length of password
  /// </summary>
  public Optional<int> MinimumLength { get; set; }

  /// <summary>
  /// Specifies the whether a non alphanumeric character is required in the password.
  /// </summary>
  public Optional<bool> RequireNonAlphanumericCharacter { get; set; }

  /// <summary>
  /// Specifies the whether a digit is required in the password.
  /// </summary>
  public Optional<bool> RequireDigit { get; set; }

  /// <summary>
  /// Specifies the whether a lowercase character is required in the password.
  /// </summary>
  public Optional<bool> RequireLowercaseCharacter { get; set; }

  /// <summary>
  /// Specifies the whether a uppercase character is required in the password.
  /// </summary>
  public Optional<bool> RequireUppercaseCharacter { get; set; }

  /// <summary>
  /// Specifies the number of unique characters required in the password.
  /// </summary>
  public Optional<int> RequiredUniqueCharactersCount { get; set; }
}


