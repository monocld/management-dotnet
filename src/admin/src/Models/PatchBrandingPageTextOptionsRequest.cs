namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Text Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageTextOptionsRequest>))]
public class PatchBrandingPageTextOptionsRequest
{
  /// <summary>
  /// Specifies the font size (in Rem) of the regular text
  /// </summary>
  public Optional<float> RegularFontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the regule text
  /// </summary>
  public Optional<int> RegularFontWeight { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the small text
  /// </summary>
  public Optional<float> SmallFontSize { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the extra-small text
  /// </summary>
  public Optional<float> ExtraSmallFontSize { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the regular text
  /// </summary>
  public Optional<string> TextColor { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the error text
  /// </summary>
  public Optional<string> ErrorColor { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of an error element when it is in the hover state
  /// </summary>
  public Optional<string> ErrorHoverColor { get; set; }

  /// <summary>
  /// Specifies the alignment of the heading text relative to the card
  /// </summary>
  public Optional<string> HeadingAlignment { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the heading text
  /// </summary>
  public Optional<float> HeadingFontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the heading text
  /// </summary>
  public Optional<int> HeadingFontWeight { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the sub-heading text
  /// </summary>
  public Optional<float> SubHeadingFontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the sub-heading text
  /// </summary>
  public Optional<int> SubHeadingFontWeight { get; set; }
}


