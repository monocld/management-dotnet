namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Layout Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageLayoutOptionsRequest>))]
public class PatchBrandingPageLayoutOptionsRequest
{
  /// <summary>
  /// Specifies the background of the page
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> Background { get; set; }

  /// <summary>
  /// Specifies the size of the card (in Pixels)
  /// </summary>
  public Optional<int> CardWidth { get; set; }

  /// <summary>
  /// Specifies position of the card relative to the page
  /// </summary>
  public Optional<string> CardPosition { get; set; }

  /// <summary>
  /// Specifies the column in which the card will be positioned on the grid
  /// </summary>
  public Optional<int> CardGridColumn { get; set; }

  /// <summary>
  /// Specifies how many columns the card will occupy on the grid
  /// </summary>
  public Optional<int> CardGridSpan { get; set; }

  /// <summary>
  /// Specifies the offset (in Pixels) used to position the card horizontally on the page
  /// </summary>
  public Optional<int> CardXOffset { get; set; }

  /// <summary>
  /// Specifies the background of the card
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> CardBackground { get; set; }

  /// <summary>
  /// Specifies the padding (in Pixels) to be applied to the card
  /// </summary>
  public Optional<float> CardPadding { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the card
  /// </summary>
  public Optional<float> CardBorderWidth { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the card
  /// </summary>
  public Optional<int> CardBorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the card
  /// </summary>
  public Optional<string> CardBorderColor { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the card
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> CardShadow { get; set; }
}


