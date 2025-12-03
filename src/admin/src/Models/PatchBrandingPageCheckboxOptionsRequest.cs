namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Checkbox Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageCheckboxOptionsRequest>))]
public class PatchBrandingPageCheckboxOptionsRequest
{
  /// <summary>
  /// Specifies the background of the checkbox
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> Background { get; set; }

  /// <summary>
  /// Specifies the border radius (in pixels) of the checkbox
  /// </summary>
  public Optional<int> BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the checkbox
  /// </summary>
  public Optional<string> BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the checkbox
  /// </summary>
  public Optional<float> BorderWidth { get; set; }

  /// <summary>
  /// Specifies the background of the checkbox when it is in the hover state
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> HoverBackground { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the checkbox when it is in the hover state
  /// </summary>
  public Optional<string> HoverBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the checkbox when it is in the hover state
  /// </summary>
  public Optional<float> HoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the background of the checkbox when it is in the disabled state
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> DisabledBackground { get; set; }

  /// <summary>
  /// Specifies the background of the checkbox when it is in the checked state
  /// </summary>
  public Optional<PatchBrandingGenericPageBackgroundOptionsRequest> CheckedBackground { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the checkbox when it is in the checked state
  /// </summary>
  public Optional<string> CheckedBorderColor { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the check-mark in the checkbox when it is in the checked state
  /// </summary>
  public Optional<string> CheckMarkColor { get; set; }
}


