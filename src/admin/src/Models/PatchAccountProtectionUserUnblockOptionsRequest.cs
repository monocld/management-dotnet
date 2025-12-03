namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch account protection user unblock options request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserUnblockOptionsRequest>))]
public class PatchAccountProtectionUserUnblockOptionsRequest
{
  /// <summary>
  /// User Unblock Email Options
  /// </summary>
  public Optional<PatchAccountProtectionUserUnblockEmailOptionsRequest> Email { get; set; }
}


