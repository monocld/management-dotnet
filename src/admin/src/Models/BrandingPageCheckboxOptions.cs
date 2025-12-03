namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Checkbox Options response class
/// </summary>
public class BrandingPageCheckboxOptions
{
  /// <summary>
  /// Specifies the background of the checkbox
  /// </summary>
  public BrandingGenericPageBackgroundOptions Background { get; set; }

  /// <summary>
  /// Specifies the border radius (in pixels) of the checkbox
  /// </summary>
  public int BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the checkbox
  /// </summary>
  public string BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the checkbox
  /// </summary>
  public float BorderWidth { get; set; }

  /// <summary>
  /// Specifies the background of the checkbox when it is in the hover state
  /// </summary>
  public BrandingGenericPageBackgroundOptions HoverBackground { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the checkbox when it is in the hover state
  /// </summary>
  public string HoverBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the checkbox when it is in the hover state
  /// </summary>
  public float HoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the background of the checkbox when it is in the disabled state
  /// </summary>
  public BrandingGenericPageBackgroundOptions DisabledBackground { get; set; }

  /// <summary>
  /// Specifies the background of the checkbox when it is in the checked state
  /// </summary>
  public BrandingGenericPageBackgroundOptions CheckedBackground { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the checkbox when it is in the checked state
  /// </summary>
  public string CheckedBorderColor { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the check-mark in the checkbox when it is in the checked state
  /// </summary>
  public string CheckMarkColor { get; set; }
}


