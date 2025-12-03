namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Communication Sms Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationSmsOptionsRequest>))]
public class PatchCommunicationSmsOptionsRequest
{
  /// <summary>
  /// Twilio Options
  /// </summary>
  public Optional<PatchCommunicationSmsTwilioOptionsRequest?> Twilio { get; set; }

  /// <summary>
  /// Provider used to send Sms
  /// </summary>
  public Optional<SmsProviders> Provider { get; set; }
}


