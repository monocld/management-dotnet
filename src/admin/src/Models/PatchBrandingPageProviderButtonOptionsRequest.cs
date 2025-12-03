namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Provider Button Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageProviderButtonOptionsRequest>))]
public class PatchBrandingPageProviderButtonOptionsRequest
{
  /// <summary>
  /// Specifies the border radius (in Pixels) of the login provider buttons
  /// </summary>
  public Optional<int> BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the login provider buttons
  /// </summary>
  public Optional<string> BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the login provider buttons
  /// </summary>
  public Optional<float> BorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the login provider buttons
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> Shadow { get; set; }

  /// <summary>
  /// Specifies the background of the login provider buttons
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> Background { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the login provider buttons
  /// </summary>
  public Optional<string> TextColor { get; set; }

  /// <summary>
  /// Specifies the alignment of the text contained in the login provider buttons
  /// </summary>
  public Optional<string> TextAlignment { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the login provider buttons when in the hover state
  /// </summary>
  public Optional<string> HoverBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the login provider buttons when in the hover state
  /// </summary>
  public Optional<float> HoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the login provider buttons when in the hover state
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> HoverShadow { get; set; }

  /// <summary>
  /// Specifies the background of the login provider buttons when in the hover state
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> HoverBackground { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the login provider buttons when in the hover state
  /// </summary>
  public Optional<string> HoverTextColor { get; set; }
}


