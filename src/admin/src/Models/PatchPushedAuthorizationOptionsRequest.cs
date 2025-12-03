namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Pushed Authorization Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPushedAuthorizationOptionsRequest>))]
public class PatchPushedAuthorizationOptionsRequest
{
  /// <summary>
  /// Specifies whether Pushed Authorization Requests are enabled.
  /// </summary>
  public Optional<bool> EnablePushedAuthorizationRequests { get; set; }

  /// <summary>
  /// Specifies whether Pushed Authorization Requests are required for authorization.
  /// </summary>
  public Optional<bool> RequirePushedAuthorizationRequests { get; set; }
}


