namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Button Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageButtonOptionsRequest>))]
public class PatchBrandingPageButtonOptionsRequest
{
  /// <summary>
  /// Specifies the font size (in Rem) of the text contained in the button
  /// </summary>
  public Optional<float> FontSize { get; set; }

  /// <summary>
  /// Specifies the vertical padding (in Pixels) of the button
  /// </summary>
  public Optional<float> PaddingY { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the button
  /// </summary>
  public Optional<int> BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the button
  /// </summary>
  public Optional<string> BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the button
  /// </summary>
  public Optional<float> BorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the button
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> Shadow { get; set; }

  /// <summary>
  /// Specifies the background of the button
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> Background { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the button
  /// </summary>
  public Optional<string> TextColor { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the button when it is in the hover state
  /// </summary>
  public Optional<string> HoverBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the button when it is in the hover state
  /// </summary>
  public Optional<float> HoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the button when it is in the hover state
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> HoverShadow { get; set; }

  /// <summary>
  /// Specifies the background of the button when it is in the hover state
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> HoverBackground { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the button when it is in the hover state
  /// </summary>
  public Optional<string> HoverTextColor { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the outline type button
  /// </summary>
  public Optional<string> OutlineBorderColor { get; set; }

  /// <summary>
  /// Specifies border width (in Pixels) of the outline type button
  /// </summary>
  public Optional<float> OutlineBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the outline type button
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> OutlineShadow { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the outline type button
  /// </summary>
  public Optional<string> OutlineTextColor { get; set; }

  /// <summary>
  /// Specifies border color (in Hex) of the outline type button when it is in the hover state
  /// </summary>
  public Optional<string> OutlineHoverBorderColor { get; set; }

  /// <summary>
  /// Specifies border width (in Pixels) of the outline type button when it is in the hover state
  /// </summary>
  public Optional<float> OutlineHoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the outline type button when it is in the hover state
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> OutlineHoverShadow { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the outline type button when it is in the hover state
  /// </summary>
  public Optional<string> OutlineHoverTextColor { get; set; }
}


