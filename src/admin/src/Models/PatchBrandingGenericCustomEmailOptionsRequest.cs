namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Generic Branding Custom Email Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingGenericCustomEmailOptionsRequest>))]
public class PatchBrandingGenericCustomEmailOptionsRequest
{
  /// <summary>
  /// Specifies whether notifications should be send internally.
  /// </summary>
  public Optional<bool> SendNotifications { get; set; }

  /// <summary>
  /// Specifies the text to be used as the email subject
  /// </summary>
  public Optional<string?> Subject { get; set; }

  /// <summary>
  /// Specifies the URI for the custom template to be used
  /// </summary>
  public Optional<string?> TemplateUri { get; set; }
}


