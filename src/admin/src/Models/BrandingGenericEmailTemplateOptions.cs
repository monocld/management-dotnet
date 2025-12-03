namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Email Generic Template Options response class
/// </summary>
public class BrandingGenericEmailTemplateOptions
{
  /// <summary>
  /// Specifies whether notifications should be send internally.
  /// </summary>
  public bool SendNotifications { get; set; }

  /// <summary>
  /// Specifies the text to be used as the email subject
  /// </summary>
  public string? Subject { get; set; }

  /// <summary>
  /// Specifies the URI for the custom template to be used
  /// </summary>
  public string? TemplateUri { get; set; }
}


