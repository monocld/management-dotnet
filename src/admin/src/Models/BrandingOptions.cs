namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Options response class
/// </summary>
public class BrandingOptions
{
  /// <summary>
  /// Email Branding Options
  /// </summary>
  public BrandingEmailOptions Email { get; set; }

  /// <summary>
  /// Sms Branding Options
  /// </summary>
  public BrandingSmsOptions Sms { get; set; }

  /// <summary>
  /// Page Branding Options
  /// </summary>
  public BrandingPageOptions Page { get; set; }

  /// <summary>
  /// Specifies the creation time of the Branding Options (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the Branding Options (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


