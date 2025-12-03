namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Logout Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchLogoutOptionsRequest>))]
public class PatchLogoutOptionsRequest
{
  /// <summary>
  /// Specifies whether the user should be automatically redirected to the client specified URL after sign out.
  /// </summary>
  public Optional<bool> AutomaticRedirectAfterLogout { get; set; }

  /// <summary>
  /// Specifies whether there should be a prompt before log out.
  /// </summary>
  public Optional<bool> ShowLogoutPrompt { get; set; }
}


