namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch account protection user unblock email options request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserUnblockEmailOptionsRequest>))]
public class PatchAccountProtectionUserUnblockEmailOptionsRequest
{
  /// <summary>
  /// Email expiration time in seconds.
  /// </summary>
  public Optional<int> Expiry { get; set; }
}


