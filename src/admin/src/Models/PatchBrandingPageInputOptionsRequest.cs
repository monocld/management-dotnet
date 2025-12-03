namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Input Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageInputOptionsRequest>))]
public class PatchBrandingPageInputOptionsRequest
{
  /// <summary>
  /// Specifies the text font size (in Rem) of the input box
  /// </summary>
  public Optional<float> FontSize { get; set; }

  /// <summary>
  /// Specifies the text color (in Hex) of the input box
  /// </summary>
  public Optional<string> TextColor { get; set; }

  /// <summary>
  /// Specifies the background of the input box
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> Background { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the input box
  /// </summary>
  public Optional<int> BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the input box
  /// </summary>
  public Optional<string> BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the input box
  /// </summary>
  public Optional<float> BorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input box
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> Shadow { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the input box
  /// </summary>
  public Optional<string> FocusBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the input box when it is in the focused state
  /// </summary>
  public Optional<float> FocusBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input box when it is in the focused state
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> FocusShadow { get; set; }

  /// <summary>
  /// Specifies the text color (in Hex) of the input box when it is in the focused state
  /// </summary>
  public Optional<string> FocusTextColor { get; set; }

  /// <summary>
  /// Specifies the label color (in Hex) of the input box
  /// </summary>
  public Optional<string> LabelColor { get; set; }

  /// <summary>
  /// Specifies the label color (in Hex) of the input box when it is in the focused state
  /// </summary>
  public Optional<string> FocusLabelColor { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input box when it is in the error state
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> ErrorShadow { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input when it is in the error and focused state
  /// </summary>
  public Optional<PatchBrandingGenericPageShadowOptionsRequest> ErrorFocusShadow { get; set; }
}


