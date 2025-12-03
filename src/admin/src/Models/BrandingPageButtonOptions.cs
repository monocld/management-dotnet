namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Button Options response class
/// </summary>
public class BrandingPageButtonOptions
{
  /// <summary>
  /// Specifies the font size (in Rem) of the text contained in the button
  /// </summary>
  public float FontSize { get; set; }

  /// <summary>
  /// Specifies the vertical padding (in Pixels) of the button
  /// </summary>
  public float PaddingY { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the button
  /// </summary>
  public int BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the button
  /// </summary>
  public string BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the button
  /// </summary>
  public float BorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the button
  /// </summary>
  public BrandingGenericPageShadowOptions Shadow { get; set; }

  /// <summary>
  /// Specifies the background of the button
  /// </summary>
  public BrandingGenericPageBackgroundOptions Background { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the button
  /// </summary>
  public string TextColor { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the button when it is in the hover state
  /// </summary>
  public string HoverBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the button when it is in the hover state
  /// </summary>
  public float HoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the button when it is in the hover state
  /// </summary>
  public BrandingGenericPageShadowOptions HoverShadow { get; set; }

  /// <summary>
  /// Specifies the background of the button when it is in the hover state
  /// </summary>
  public BrandingGenericPageBackgroundOptions HoverBackground { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the button when it is in the hover state
  /// </summary>
  public string HoverTextColor { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the outline type button
  /// </summary>
  public string OutlineBorderColor { get; set; }

  /// <summary>
  /// Specifies border width (in Pixels) of the outline type button
  /// </summary>
  public float OutlineBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the outline type button
  /// </summary>
  public BrandingGenericPageShadowOptions OutlineShadow { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the outline type button
  /// </summary>
  public string OutlineTextColor { get; set; }

  /// <summary>
  /// Specifies border color (in Hex) of the outline type button when it is in the hover state
  /// </summary>
  public string OutlineHoverBorderColor { get; set; }

  /// <summary>
  /// Specifies border width (in Pixels) of the outline type button when it is in the hover state
  /// </summary>
  public float OutlineHoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the outline type button when it is in the hover state
  /// </summary>
  public BrandingGenericPageShadowOptions OutlineHoverShadow { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the outline type button when it is in the hover state
  /// </summary>
  public string OutlineHoverTextColor { get; set; }
}


