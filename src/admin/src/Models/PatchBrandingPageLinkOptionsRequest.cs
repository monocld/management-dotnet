namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Link Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageLinkOptionsRequest>))]
public class PatchBrandingPageLinkOptionsRequest
{
  /// <summary>
  /// Specifies the color (in Hex) of the link text
  /// </summary>
  public Optional<string> Color { get; set; }

  /// <summary>
  /// Specifies the text decoration to be applied on the link text
  /// </summary>
  public Optional<string> Decoration { get; set; }

  /// <summary>
  /// Specifies the color of the link text when it is in the hover state
  /// </summary>
  public Optional<string> HoverColor { get; set; }

  /// <summary>
  /// Specifies the text decoration to be applied on the link text when it is in the hover state
  /// </summary>
  public Optional<string> HoverDecoration { get; set; }
}


