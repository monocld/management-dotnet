namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Generic Sms Template Options response class
/// </summary>
public class BrandingGenericSmsTemplateOptions
{
  /// <summary>
  /// Specifies whether notifications should be send internally.
  /// </summary>
  public bool SendNotifications { get; set; }

  /// <summary>
  /// Custom LiquidJS template for the SMS
  /// </summary>
  public string? Template { get; set; }
}


