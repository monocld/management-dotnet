namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Layout Options response class
/// </summary>
public class BrandingPageLayoutOptions
{
  /// <summary>
  /// Specifies the background of the page
  /// </summary>
  public BrandingGenericPageBackgroundOptions Background { get; set; }

  /// <summary>
  /// Specifies the size of the card (in Pixels)
  /// </summary>
  public int CardWidth { get; set; }

  /// <summary>
  /// Specifies position of the card relative to the page
  /// </summary>
  public string CardPosition { get; set; }

  /// <summary>
  /// Specifies the column in which the card will be positioned on the grid
  /// </summary>
  public int CardGridColumn { get; set; }

  /// <summary>
  /// Specifies how many columns the card will occupy on the grid
  /// </summary>
  public int CardGridSpan { get; set; }

  /// <summary>
  /// Specifies the offset (in Pixels) used to position the card horizontally on the page
  /// </summary>
  public int CardXOffset { get; set; }

  /// <summary>
  /// Specifies the background of the card
  /// </summary>
  public BrandingGenericPageBackgroundOptions CardBackground { get; set; }

  /// <summary>
  /// Specifies the padding (in Pixels) to be applied to the card
  /// </summary>
  public float CardPadding { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the card
  /// </summary>
  public float CardBorderWidth { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the card
  /// </summary>
  public int CardBorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the card
  /// </summary>
  public string CardBorderColor { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the card
  /// </summary>
  public BrandingGenericPageShadowOptions CardShadow { get; set; }
}


