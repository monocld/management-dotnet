namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Communication Sms Twilio Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationSmsTwilioOptionsRequest>))]
public class PatchCommunicationSmsTwilioOptionsRequest
{
  /// <summary>
  /// Twilio SID
  /// </summary>
  public Optional<string> Sid { get; set; }

  /// <summary>
  /// Twilio Auth Token
  /// </summary>
  public Optional<string> AuthToken { get; set; }

  /// <summary>
  /// Twilio Messaging SID
  /// </summary>
  public Optional<string?> MessagingSid { get; set; }

  /// <summary>
  /// Twilio From
  /// </summary>
  public Optional<string?> From { get; set; }
}


