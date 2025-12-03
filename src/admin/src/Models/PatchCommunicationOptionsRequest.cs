namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Communication Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationOptionsRequest>))]
public class PatchCommunicationOptionsRequest
{
  /// <summary>
  /// Email - Communication Options
  /// </summary>
  public Optional<PatchCommunicationEmailOptionsRequest> Email { get; set; }

  /// <summary>
  /// Sms - Communication Options
  /// </summary>
  public Optional<PatchCommunicationSmsOptionsRequest> Sms { get; set; }
}


