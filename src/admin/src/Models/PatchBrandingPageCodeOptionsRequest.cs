namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Code Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageCodeOptionsRequest>))]
public class PatchBrandingPageCodeOptionsRequest
{
  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the the code box
  /// </summary>
  public Optional<string> TextColor { get; set; }

  /// <summary>
  /// Specifies the font size (in Rem) of the text contained in the the code box
  /// </summary>
  public Optional<float> FontSize { get; set; }

  /// <summary>
  /// Specifies the font weight of the text contained in the the code box
  /// </summary>
  public Optional<int> FontWeight { get; set; }

  /// <summary>
  /// Specifies the space between the code characters (in em) in the code box
  /// </summary>
  public Optional<float> LetterSpacing { get; set; }

  /// <summary>
  /// Specifies the background of the code box
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> Background { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the code box
  /// </summary>
  public Optional<float> BorderWidth { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the code box
  /// </summary>
  public Optional<string> BorderColor { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the code box
  /// </summary>
  public Optional<int> BorderRadius { get; set; }
}


