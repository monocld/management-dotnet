namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Logout Options response class
/// </summary>
public class LogoutOptions
{
  /// <summary>
  /// Specifies whether the user should be automatically redirected to the client specified URL after sign out.
  /// </summary>
  public bool AutomaticRedirectAfterLogout { get; set; }

  /// <summary>
  /// Specifies whether there should be a prompt before log out.
  /// </summary>
  public bool ShowLogoutPrompt { get; set; }
}


