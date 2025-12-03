namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Link Options response class
/// </summary>
public class BrandingPageLinkOptions
{
  /// <summary>
  /// Specifies the color (in Hex) of the link text
  /// </summary>
  public string Color { get; set; }

  /// <summary>
  /// Specifies the text decoration to be applied on the link text
  /// </summary>
  public string Decoration { get; set; }

  /// <summary>
  /// Specifies the color of the link text when it is in the hover state
  /// </summary>
  public string HoverColor { get; set; }

  /// <summary>
  /// Specifies the text decoration to be applied on the link text when it is in the hover state
  /// </summary>
  public string HoverDecoration { get; set; }
}


