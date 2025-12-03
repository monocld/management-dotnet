namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Email Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingEmailOptionsRequest>))]
public class PatchBrandingEmailOptionsRequest
{
  /// <summary>
  /// Welcome Email Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> Welcome { get; set; }

  /// <summary>
  /// User Blocked Email Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> UserBlocked { get; set; }

  /// <summary>
  /// Sign In Email Code Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> SignInCode { get; set; }

  /// <summary>
  /// Sign In Email Link Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> SignInLink { get; set; }

  /// <summary>
  /// Sign In Email Code and Link Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> SignInCodeAndLink { get; set; }

  /// <summary>
  /// Verification Email Code Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> VerificationCode { get; set; }

  /// <summary>
  /// Verification Email Link Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> VerificationLink { get; set; }

  /// <summary>
  /// Verification Email Code and Link Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> VerificationCodeAndLink { get; set; }

  /// <summary>
  /// Password Reset Email Code Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> PasswordResetCode { get; set; }

  /// <summary>
  /// Password Reset Email Link Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> PasswordResetLink { get; set; }

  /// <summary>
  /// Password Reset Email Code and Link Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> PasswordResetCodeAndLink { get; set; }

  /// <summary>
  /// Password Updated Email Branding Options
  /// </summary>
  public Optional<PatchBrandingGenericCustomEmailOptionsRequest> PasswordUpdated { get; set; }
}


