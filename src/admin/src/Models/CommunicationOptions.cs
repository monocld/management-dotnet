namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Communication Options response class
/// </summary>
public class CommunicationOptions
{
  /// <summary>
  /// Email - Communication Options
  /// </summary>
  public CommunicationEmailOptions Email { get; set; }

  /// <summary>
  /// Sms - Communication Options
  /// </summary>
  public CommunicationSmsOptions Sms { get; set; }
}


