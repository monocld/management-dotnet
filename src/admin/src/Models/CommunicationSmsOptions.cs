namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Communication Sms Options response class
/// </summary>
public class CommunicationSmsOptions
{
  /// <summary>
  /// Twilio Options
  /// </summary>
  public CommunicationSmsTwilioOptions? Twilio { get; set; }

  /// <summary>
  /// Provider used to send Sms
  /// </summary>
  public SmsProviders Provider { get; set; }
}


