namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Communication Email Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationEmailOptionsRequest>))]
public class PatchCommunicationEmailOptionsRequest
{
  /// <summary>
  /// SendGrid Email Options
  /// </summary>
  public Optional<PatchCommunicationEmailSendGridOptionsRequest?> SendGrid { get; set; }

  /// <summary>
  /// Provider used to send Emails
  /// </summary>
  public Optional<EmailProviders> Provider { get; set; }
}


