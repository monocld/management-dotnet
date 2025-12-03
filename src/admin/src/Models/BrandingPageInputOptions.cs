namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Input Options response class
/// </summary>
public class BrandingPageInputOptions
{
  /// <summary>
  /// Specifies the text font size (in Rem) of the input box
  /// </summary>
  public float FontSize { get; set; }

  /// <summary>
  /// Specifies the text color (in Hex) of the input box
  /// </summary>
  public string TextColor { get; set; }

  /// <summary>
  /// Specifies the background of the input box
  /// </summary>
  public BrandingGenericPageBackgroundOptions Background { get; set; }

  /// <summary>
  /// Specifies the border radius (in Pixels) of the input box
  /// </summary>
  public int BorderRadius { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the input box
  /// </summary>
  public string BorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the input box
  /// </summary>
  public float BorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input box
  /// </summary>
  public BrandingGenericPageShadowOptions Shadow { get; set; }

  /// <summary>
  /// Specifies the border color (in Hex) of the input box
  /// </summary>
  public string FocusBorderColor { get; set; }

  /// <summary>
  /// Specifies the border width (in Pixels) of the input box when it is in the focused state
  /// </summary>
  public float FocusBorderWidth { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input box when it is in the focused state
  /// </summary>
  public BrandingGenericPageShadowOptions FocusShadow { get; set; }

  /// <summary>
  /// Specifies the text color (in Hex) of the input box when it is in the focused state
  /// </summary>
  public string FocusTextColor { get; set; }

  /// <summary>
  /// Specifies the label color (in Hex) of the input box
  /// </summary>
  public string LabelColor { get; set; }

  /// <summary>
  /// Specifies the label color (in Hex) of the input box when it is in the focused state
  /// </summary>
  public string FocusLabelColor { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input box when it is in the error state
  /// </summary>
  public BrandingGenericPageShadowOptions ErrorShadow { get; set; }

  /// <summary>
  /// Specifies the box-shadow of the input when it is in the error and focused state
  /// </summary>
  public BrandingGenericPageShadowOptions ErrorFocusShadow { get; set; }
}


