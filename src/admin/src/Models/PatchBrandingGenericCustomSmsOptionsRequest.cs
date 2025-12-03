namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Generic Branding Custom Sms Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingGenericCustomSmsOptionsRequest>))]
public class PatchBrandingGenericCustomSmsOptionsRequest
{
  /// <summary>
  /// Specifies whether notifications should be send internally.
  /// </summary>
  public Optional<bool> SendNotifications { get; set; }

  /// <summary>
  /// Custom LiquidJS template for the SMS
  /// </summary>
  public Optional<string?> Template { get; set; }
}


