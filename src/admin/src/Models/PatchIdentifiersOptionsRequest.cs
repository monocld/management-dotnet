namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Identifiers Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersOptionsRequest>))]
public class PatchIdentifiersOptionsRequest
{
  /// <summary>
  /// Email Identifier Options
  /// </summary>
  public Optional<PatchIdentifiersEmailOptionsRequest> Email { get; set; }

  /// <summary>
  /// Phone Identifier Options
  /// </summary>
  public Optional<PatchIdentifiersPhoneOptionsRequest> Phone { get; set; }

  /// <summary>
  /// Username Identifier Options
  /// </summary>
  public Optional<PatchIdentifiersUsernameOptionsRequest> Username { get; set; }
}


