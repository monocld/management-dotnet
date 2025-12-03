namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Identifiers Options response class
/// </summary>
public class IdentifiersOptions
{
  /// <summary>
  /// Email Identifier Options
  /// </summary>
  public IdentifiersEmailOptions Email { get; set; }

  /// <summary>
  /// Phone Identifier Options
  /// </summary>
  public IdentifiersPhoneOptions Phone { get; set; }

  /// <summary>
  /// Username Identifier Options
  /// </summary>
  public IdentifiersUsernameOptions Username { get; set; }
}


