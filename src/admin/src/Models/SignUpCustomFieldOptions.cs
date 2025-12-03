namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The SignUp Custom Field Options response class
/// </summary>
public class SignUpCustomFieldOptions
{
  /// <summary>
  /// Specifies if the users are allowed to enter the claim at the time of signup.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Specifies if the claim is required at the time of signup.
  /// </summary>
  public bool Required { get; set; }

  /// <summary>
  /// Specifies the name for the claim.
  /// </summary>
  public string ClaimName { get; set; }

  /// <summary>
  /// Specifies the claim value type.
  /// </summary>
  public ValueTypes ValueType { get; set; }

  /// <summary>
  /// Specifies the label to be used for the claim at the time of signup.
  /// </summary>
  public string Label { get; set; }
}


