namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Generic Page Shadow Options response class
/// </summary>
public class BrandingGenericPageShadowOptions
{
  /// <summary>
  /// Specifies the horizontal offset of the shadow (in Pixels)
  /// </summary>
  public float HOffset { get; set; }

  /// <summary>
  /// Specifies the vertical offset of the shadow (in Pixels)
  /// </summary>
  public float VOffset { get; set; }

  /// <summary>
  /// Specifies the blur radius (in Pixels)
  /// </summary>
  public float Blur { get; set; }

  /// <summary>
  /// Specifies the spread radius (in Pixels)
  /// </summary>
  public float Spread { get; set; }

  /// <summary>
  /// Specifies the color of the shadow (in Hex)
  /// </summary>
  public string Color { get; set; }

  /// <summary>
  /// Specifies if the shadow is an inner shadow
  /// </summary>
  public bool Inset { get; set; }
}


