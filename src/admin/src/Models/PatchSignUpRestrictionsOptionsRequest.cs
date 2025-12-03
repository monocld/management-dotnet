namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch SignUp Generic Restrictions Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSignUpRestrictionsOptionsRequest>))]
public class PatchSignUpRestrictionsOptionsRequest
{
  /// <summary>
  /// Specifies whether or not the restriction is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// List of Emails, Phone numbers, and top-level domains to be considered for access control.
  /// </summary>
  public Optional<List<string>> Identifiers { get; set; }
}


