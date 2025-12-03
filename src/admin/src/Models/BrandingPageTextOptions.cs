namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Text Options response class
/// </summary>
public class BrandingPageTextOptions
{
  /// <summary>
  /// Specifies the font size (in Rem) of the regular text
  /// </summary>
  public float RegularFontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the regule text
  /// </summary>
  public int RegularFontWeight { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the small text
  /// </summary>
  public float SmallFontSize { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the extra-small text
  /// </summary>
  public float ExtraSmallFontSize { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the regular text
  /// </summary>
  public string TextColor { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the error text
  /// </summary>
  public string ErrorColor { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of an error element when it is in the hover state
  /// </summary>
  public string ErrorHoverColor { get; set; }

  /// <summary>
  /// Specifies the alignment of the heading text relative to the card
  /// </summary>
  public string HeadingAlignment { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the heading text
  /// </summary>
  public float HeadingFontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the heading text
  /// </summary>
  public int HeadingFontWeight { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the sub-heading text
  /// </summary>
  public float SubHeadingFontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the sub-heading text
  /// </summary>
  public int SubHeadingFontWeight { get; set; }
}


