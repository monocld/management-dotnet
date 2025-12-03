namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Communicaiton Email SendGrid Options response class
/// </summary>
public class CommunicationEmailSendGridOptions
{
  /// <summary>
  /// SendGrid Api Key
  /// </summary>
  public string ApiKey { get; set; }

  /// <summary>
  /// From Email Address
  /// </summary>
  public string FromEmail { get; set; }

  /// <summary>
  /// From Name
  /// </summary>
  public string? FromName { get; set; }
}


