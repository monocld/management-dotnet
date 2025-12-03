namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Sms Options response class
/// </summary>
public class BrandingSmsOptions
{
  /// <summary>
  /// SignIn Sms Code Branding Options
  /// </summary>
  public BrandingGenericSmsTemplateOptions SignIn { get; set; }

  /// <summary>
  /// Verification Sms Code Branding Options
  /// </summary>
  public BrandingGenericSmsTemplateOptions Verification { get; set; }

  /// <summary>
  /// Password Reset Sms Code Branding Options
  /// </summary>
  public BrandingGenericSmsTemplateOptions PasswordReset { get; set; }
}


