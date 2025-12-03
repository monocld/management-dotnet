namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Email Options response class
/// </summary>
public class BrandingEmailOptions
{
  /// <summary>
  /// Welcome Email Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions Welcome { get; set; }

  /// <summary>
  /// User Blocked Email Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions UserBlocked { get; set; }

  /// <summary>
  /// Sign In Email Code Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions SignInCode { get; set; }

  /// <summary>
  /// Sign In Email Link Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions SignInLink { get; set; }

  /// <summary>
  /// Sign In Email Code and Link Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions SignInCodeAndLink { get; set; }

  /// <summary>
  /// Verification Email Code Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions VerificationCode { get; set; }

  /// <summary>
  /// Verification Email Link Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions VerificationLink { get; set; }

  /// <summary>
  /// Verification Email Code and Link Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions VerificationCodeAndLink { get; set; }

  /// <summary>
  /// Password Reset Email Code Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions PasswordResetCode { get; set; }

  /// <summary>
  /// Password Reset Email Link Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions PasswordResetLink { get; set; }

  /// <summary>
  /// Password Reset Email Code and Link Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions PasswordResetCodeAndLink { get; set; }

  /// <summary>
  /// Password Updated Email Branding Options
  /// </summary>
  public BrandingGenericEmailTemplateOptions PasswordUpdated { get; set; }
}


