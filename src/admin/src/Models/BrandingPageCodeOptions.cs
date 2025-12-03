namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Code Options response class
/// </summary>
public class BrandingPageCodeOptions
{
  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the the code box
  /// </summary>
  public string TextColor { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the text contained in the the code box
  /// </summary>
  public float FontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the text contained in the the code box
  /// </summary>
  public int FontWeight { get; set; }

  /// <summary>
  /// Specifies the space between the code characters (in em) in the code box
  /// </summary>
  public float LetterSpacing { get; set; }

  /// <summary>
  /// Specifies the background of the code box
  /// </summary>
  public BrandingGenericPageBackgroundOptions Background { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the code box
  /// </summary>
  public float BorderWidth { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the code box
  /// </summary>
  public string BorderColor { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the code box
  /// </summary>
  public int BorderRadius { get; set; }
}


