namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Provider Button Options response class
/// </summary>
public class BrandingPageProviderButtonOptions
{
  /// <summary>
  /// Specifies the border radius (in Pixels) of the login provider buttons
  /// </summary>
  public int BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the login provider buttons
  /// </summary>
  public string BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the login provider buttons
  /// </summary>
  public float BorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the login provider buttons
  /// </summary>
  public BrandingGenericPageShadowOptions Shadow { get; set; }

  /// <summary>
  /// Specifies the background of the login provider buttons
  /// </summary>
  public BrandingGenericPageBackgroundOptions Background { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the login provider buttons
  /// </summary>
  public string TextColor { get; set; }

  /// <summary>
  /// Specifies the alignment of the text contained in the login provider buttons
  /// </summary>
  public string TextAlignment { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the login provider buttons when in the hover state
  /// </summary>
  public string HoverBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the login provider buttons when in the hover state
  /// </summary>
  public float HoverBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the login provider buttons when in the hover state
  /// </summary>
  public BrandingGenericPageShadowOptions HoverShadow { get; set; }

  /// <summary>
  /// Specifies the background of the login provider buttons when in the hover state
  /// </summary>
  public BrandingGenericPageBackgroundOptions HoverBackground { get; set; }

  /// <summary>
  /// Specifies the color (in Hex) of the text contained in the login provider buttons when in the hover state
  /// </summary>
  public string HoverTextColor { get; set; }
}


