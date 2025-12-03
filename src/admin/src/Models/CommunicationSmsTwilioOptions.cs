namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Communication Sms Twilio Options response class
/// </summary>
public class CommunicationSmsTwilioOptions
{
  /// <summary>
  /// Twilio SID
  /// </summary>
  public string Sid { get; set; }

  /// <summary>
  /// Twilio Auth Token
  /// </summary>
  public string AuthToken { get; set; }

  /// <summary>
  /// Twilio Messaging SID
  /// </summary>
  public string? MessagingSid { get; set; }

  /// <summary>
  /// Twilio From
  /// </summary>
  public string? From { get; set; }
}


