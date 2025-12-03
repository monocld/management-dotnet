namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Pushed Authorization Options response class
/// </summary>
public class PushedAuthorizationOptions
{
  /// <summary>
  /// Specifies whether Pushed Authorization Requests are enabled.
  /// </summary>
  public bool EnablePushedAuthorizationRequests { get; set; }

  /// <summary>
  /// Specifies whether Pushed Authorization Requests are required for authorization.
  /// </summary>
  public bool RequirePushedAuthorizationRequests { get; set; }
}


